<h3>Так как приложение во время рецензирования будет запускаться на компьютере, не подключённом к локальной сети, необходимо установить на персональный компьютер базу данных и поменять строку подключения программы к ней. 
Программа не скомпилирована, поэтому чтобы не потеряться в файлах проекта, далее будет описана данная процедура.</h3>

<h2>1)	Необходимо найти файл скрипта базы данных. Находится он по следующему пути:</h2>
\SilverEQuality\SilverEQuality_Context\DatabaseScript\SilverEQ.sql  <br>

  
![image](https://github.com/HeroOfUSSR/SilverEQuality/assets/104492239/8350fc73-98d9-4573-b195-d1d8912cbf1e)  
  
<h2>2)	Запустить SQL Server Management и установить базу данных из скрипта</h2>
<h2>3)	Открыть конфигурационный файл программы. Называется он appsettings.json и лежит по пути:</h2>
\SilverEQuality\SilverEQuality_Context\appsettings.json  <br>

  
![image](https://github.com/HeroOfUSSR/SilverEQuality/assets/104492239/8eb17f58-c8bd-4d81-bb6d-b972dc42eb90)

<h2>4)	После открытия необходимо заменить строку подключения по следующему шаблону:  </h2>
Если сервер БД запущена с проверкой подлинности Windows:  <br>
"Server = «Название сервера»; Database = «Название базы данных»; Trusted_Connection = true"<br>
<br>
Если сервер БД запущена с проверкой SQL Server:  <br>
"Server = «Название сервера»; Database = «Название базы данных»; User ID = «Логин пользователя»; Password = «Пароль пользователя»"<br>

<h2>5)	Запустить программу через .exe файл. Путь приложения:   </h2>
\SilverEQuality\SilverEQuality\bin\Debug\net6.0-windows\SilverEQuality.exe
