import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Scanner;

public class DZ__5 {
    public static void main(String[] args) {
        System.out.println("Введите одну из следующих команд \n" +
                "Add - добавить фамилию и номер \n" +
                "Get - получить список всех номеров по фамилии\n" +
                "Remove - удалить все номера по фамилии\n" +
                "List - Посмотреть все записи\n" +
                "Exit - Завершить программу");
        Scanner scanner = new Scanner(System.in);
        HashMap<String, List> phoneBook = new HashMap<>();
        while (true) {
            String command = scanner.nextLine();
            String [] input = command.split(" ");
            if ("Add".equals(input [0])) {
                addData(phoneBook, command);}
            else if ("Get".equals(input[0])) {
                getBySurname(phoneBook, input);} 
                else if ("Remove".equals(input[0])) {
                removeBySurname(phoneBook, input);}
             else if ("List".equals(input[0])) {
                allData(phoneBook);}
             else if ("Exit".equals(input[0])) {
                System.exit(0);
                break;}
            else {
                System.err.println("Введена некорректая команда.");
                System.exit(0);
            }
        }

    }

    public static void addData (HashMap<String, List> phoneBook, String input){
        String[] name_phone = input.split(" ");
        StringBuilder phoneNumber = new StringBuilder();
        for (int i = 2; i < name_phone.length; i++) {
            phoneNumber.append(name_phone[i]);
        }
        if (phoneBook.containsKey(name_phone[1])) {
            phoneBook.get(name_phone[1]).add(phoneNumber);
        } else {
            List<String> phones = new ArrayList<>();
            phones.add(String.valueOf(phoneNumber));
            phoneBook.put(name_phone[1], phones);
        }
    }

    public static void getBySurname(HashMap<String, List> phoneBook, String[] command) {
        if (phoneBook.containsKey(command[1])) {
            System.out.println(command[1] + " - " + phoneBook.get(command[1]));
        } else {
            System.out.println("Абонент с таким номером не найден");
        }
    }

    public static void removeBySurname(HashMap<String, List> phoneBook, String[] command) {
        if (phoneBook.containsKey(command[1])) {
            phoneBook.remove(command[1]);
        } else {
            System.out.println(command[1] + " такого абонента нет");
        }
    }
    public static void allData(HashMap<String, List> phoneBook) {
        System.out.println(phoneBook);
    }
 }


