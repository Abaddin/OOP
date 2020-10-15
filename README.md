# Черкаський національний університет ім. Б. Хмельницького
## Лабораторні та практичні роботи ООП C#
### Л1. ОБРОБКА МАСИВІВ У C#(Lab_1)
Варіант 8
1. У прямокутній матриці B, що містить лише нулі та одиниці, обчислити кількість
нулів у кожному рядку і записати отримані кількості в одновимірний масив P.
Створити матрицю Z, кількість стовпчиків у кожному рядку якої визначається
відповідним значенням з масиву P. В кожен рядок матриці Z записати підряд
індекси нулів з відповідних рядків матриці B. Інвертувати порядок елементів у
кожному рядку матриці Z.
2. Створити клас TTriangle для подання трикутника. Поля (protected) повинні містити дані про довжини сторін (для кожної з трьох сторін своє поле). Потрібно реалізувати:
* конструктор, який заповнює всі три довжини (перевіряючи можливість існування такого трикутника);
* отримання (get) довжини сторони (три окремі методи, для кожної сторони свій);
* задання (set) довжини сторони (три окремі методи, для кожної сторони свій; перевіряти можливість існування такого трикутника, де ця одна сторона змінена, а решта дві лишаються, які були);
* отримання периметру трикутника
* отримання площі трикутника (через формулу Герона)

### Л2. ІНКАПСУЛЯЦІЯ. ВЛАСТИВОСТІ ТА ІНДЕКСАТОРИ. УСПАДКУВАННЯ(Lab_3)
Варіант 8
1. Реалізувати клас, що представляє квадратне рівняння і містить опис індексатора,
який дозволяє одержувати перший та другий розв’язки (якщо вони існують).
Передбачити методи введення/виведення, перевірки існування розв’язків.
2. а) Описати клас, який містить вказані поля і методи:<br>
	- Клас "коло" - TCircle;<br>
	- Поля - для зберігання радіуса;<br>
	- Методи:
		- конструктор без параметрів, конструктор з параметрами, конструктор копіювання;<br>
		- override public string ToString();
		- введення/виведення даних;
		- визначення площі круга (обмеженого колом), площі сектора (кут є параметром);<br>
		- визначення довжини кола;
		- порівняння з іншим колом;
		- перевантаження операторів + (додавання радіусів), – (віднімання радіусів; при
		від’ємному результаті брати за модулем), * (множення радіуса на число; забезпечити, щоб
		домноження могло відбуватися хоч як «число * коло», хоч як «коло * число»).
		<br>
б) Створити клас-нащадок TBall(куля) на основі класу TDisk. Додати поле третьої
координати центра, метод знаходження об’єму кулі та перевизначити відповідні методи.<br>
в) Створити програму-клієнт для тестування.

### Л3. Тема(Lab_2)
Реалізуйте клас MyMatrix, який зберігає прямокутну числову матрицю і вміє виконувати дії
додавання матриць та множення матриць.
Матриця повинна містити єдине приватне поле — масив із власне елементами матриці (типу
double[,]) .<br>
Слід реалізувати такі конструктори, оператори, властивості та методи (усі публічні, якщо
тільки не вказано іншого):
- Конструктори:<br> 
	- копіюючий з іншого примірника цього самого класу MyMatrix;
	- з двовимірного масиву типу double[,];
	- з «зубчастого» масиву double-ів, якщо він фактично прямокутний;
	- з масиву рядків, якщо фактично ці рядки містять записані через пробіли та/або
	числа, а кількість цих чисел однакова.
	- з рядка, що містить як пробіли та/або табуляції (їх трактувати як роздільники
	чисел у одному рядку матриці), так і символи переведення рядка (їх трактувати
	як роздільники рядків) — якщо фактичні дані того рядка утворюють прямокутну
	числову матрицю; зокрема, щоб цим конструктором можна було створити
	матрицю з рядка, раніше сформованого методом ToString (див. далі))<br>

* operator + додавання двох матриць (якщо вони мають однаковий розмір)
* operator * множення двох матриць (якщо кількість стовпчиків першої дорівнює
кількості рядків другої)
* Властивості (Properties) Height та Width, що дозволяють взнати (але не дозволяють
змінити) «висоту» (кількість рядків) та «ширину» (кількість стовпчиків)
* Java-style getter-и (без setter-ів) кількості рядків getHeight() та кількості
стовпчиків getWidth()
* Індексатори, що дозволяють публічно доступатися до будь-якого окремого елемента
матриці (як взнавати його значення, так і змінювати)
* Java-style getter та setter для окремого елемента (getter має два параметри — номер
рядка і номер стовпчика, setter має три параметра — номер рядка, номер стовпчика, і
значення, яке записати у той рядок і стовпчик)
* Метод override public String ToString(), перевантажений так, щоб
формував (табуляціями та переведеннями рядка) зручне для сприйняття людиною
прямокутне подання числової матриці; це повинен бути метод саме з вищенаведеним
заголовком, бо саме так вдається забезпечити, щоб примірники цього класу можна
було виводити просто через Console.WriteLine(A) (де A – примірник цього
самого класу MyMatrix)
* Метод (не статичний; private або protected) GetTransponedArray(), що повертає
новостворений масив double[,] (не MyMatrix, а просто масив), у якому вміст
елементів транспонований відносно тієї матриці, для якої він викликався
* Метод (не статичний) MyMatrix GetTransponedCopy(), який би створював
новий примірник MyMatrix, у якому вміст матриці транспонований відносно тієї,
для якої він викликався; технічну роботу по власне транспонуванню не повторювати,
а використати результат GetTransponedArray()**
* Метод (не статичний) void TransponeMe(), який би замінював матрицю, для якої
викликається, на транспоновану (теж використати GetTransponedArray(), але
щоб результат змінився сам this-примірник MyMatrix).
<br>
В усіх випадках неправильних даних (намагання створити матрицю з фактично
не прямокутного «зубчастого» масиву; намагання створити матрицю з масиву рядків, який
фактично містить взагалі не числа; намагання доступитися до неіснуючого елемента;
намагання додати матриці різного розміру, тощо) як базовий (стандартний) спосіб
пропонується, щоб виконання програми просто аварійно завершувалося. Рятування ситуації
шляхом коректної роботи з exception-ами – правильний підхід, вітається (хоч і
не вимагається). Намагання нівелювати ці помилки будь-якими іншими засобами –
неправильний підхід, категорично забороняється.

### Л4. Тема

### Л5. Тема

### Л6. Тема

### Л7. Тема

### Л8. Тема

### Л9. Тема

### Л10. Тема

### Л11. Тема

### Л12. Тема
