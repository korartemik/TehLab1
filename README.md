# TehLab1
Laboratory №1 on programming technologies
## Task1
1)Java

Вызвать с или с++ код можно с помощью подключения библиотеки Dll написанной на соответственном языке с использованием java native interface. JNI создаёт заголовочный файл, в котором объявляются функции и аргументы для этой функции, которые потом надо определить уже на выбранном языке(с или с++). 
Объявление функций:
![image](https://user-images.githubusercontent.com/54327287/156578026-4a5166f1-e70a-4e35-8c4e-cbc6a49883a8.png)

Определение функций:

![image](https://user-images.githubusercontent.com/54327287/156578275-b14ab805-58b3-40ce-9f65-db2885e05415.png)

Вызов фукнции на(в) Жабе:

![image](https://user-images.githubusercontent.com/54327287/156578537-5ac34e49-19ab-400a-bdd6-27e1c2befd38.png)

Проблема заключается в том, что для каждой архитектуры нужно создавать свою dll, а также если dll будет динамической, в которой она будет ссылаеться на другую dll,то при компиляции в жабе может произойти так, что часть dll возьмётся для 64х, а часть для 86х и ничего не запустится.

2)С#

Запускается также как и в Java, с помощью подключения dll

Проблема такая как и в жабе, нужно знать архитектуру на которй будет запускаться. Но процесс интеропа между C->C# намного легче чем на Java.

## Task2
1. Декомпиляция scala в java

![image](https://user-images.githubusercontent.com/54327287/156582284-8369d04f-cac7-4cb1-aafb-df2ab99b5bfd.png)

Код превращается в код с синтаксисом Java

2. Декомпиляция f# в с#

![image](https://user-images.githubusercontent.com/54327287/156581524-2d25d5ff-7826-4031-a9e5-86aa7c6d8860.png)

Остаётся синтаксис f#

## Task3

1. Используем Maven
Создаём Maven проект и компилируем jar файл, с помощью Maven. указывая парметры в pom.xml
Подключаем созданный jar в другом проекте java добавив в параметры pom.xml зависимость на созданный jar
  <dependencies>
  
        <dependency>
          
            <groupId>org.example</groupId>
          
            <artifactId>BFSandDFS</artifactId>
          
            <version>1.0-SNAPSHOT</version>
          
            <scope>system</scope>
          
            <systemPath>C:/Users/Артём/Downloads/New/BFSandDFS/target/BFSandDFS-1.0-SNAPSHOT.jar</systemPath>
          
        </dependency>
  
    </dependencies>
    
Также можно было создать локальную репозиторию куда закинуть созданный jar, и потом вместо указания пути к jar, укзать путь к локальному репозиторию, а в зависимостях только название

При подключение в Scala проекте, также добавляется зависимость на созданный jar, но также ещё очень много разных зависимостей для Scala

## Task4

1)C#

Время

![image](https://user-images.githubusercontent.com/54327287/156624732-6075e0d4-8c7e-4c66-af16-b72cd66ac995.png)

Память

![image](https://user-images.githubusercontent.com/54327287/156625839-5a0025f4-331b-47b0-b098-57846aebc3ca.png)

Как можно заметить встроенная сортировка самая быстра, а MergeSort требует больше всего памяти и также медленее всех работает.

2)Java
Java Microbenchmark Harness — набор библиотек для тестирования производительности небольших функций (то есть тех, где пауза GC увеличивает время работы в разы).

![image](https://user-images.githubusercontent.com/54327287/156637123-42d370ae-dba1-4a3c-9a2d-e6758eac26ee.png)

Результаты аналогичны результатам на C#

## Task 5
