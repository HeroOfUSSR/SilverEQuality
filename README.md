Так как приложение во время рецензирования будет запускаться на компьютере, не подключённом к локальной сети, необходимо установить на персональный компьютер базу данных и поменять строку подключения программы к ней. 
Программа не скомпилирована, поэтому чтобы не потеряться в файлах проекта, далее будет описана данная процедура.

<h1>1)	Необходимо найти файл скрипта базы данных. Находится он по следующему пути:</h1>
\SilverEQuality\SilverEQuality_Context\DatabaseScript\SilverEQ.sql

 <h1 align="center">![image](https://github.com/HeroOfUSSR/SilverEQuality/assets/104492239/8350fc73-98d9-4573-b195-d1d8912cbf1e)</h1>
Рис.1 – Скрипт базы данных

<h1>2)	Запустить SQL Server Management и установить базу данных из скрипта</h1>
<h1>3)	Открыть конфигурационный файл программы. Называется он appsettings.json и лежит по пути:</h1>
\SilverEQuality\SilverEQuality_Context\appsettings.json

<h1 align="center"> ![image](https://github.com/HeroOfUSSR/SilverEQuality/assets/104492239/8eb17f58-c8bd-4d81-bb6d-b972dc42eb90)</h1>
Рис.2 – Конфигурационный файл выделен жёлтым

<h1>4)	После открытия необходимо заменить строку подключения по следующему шаблону:  </h1>
Если сервер БД запущена с проверкой подлинности Windows:  
"Server = «Название сервера»; Database = «Название базы данных»; Trusted_Connection = true"
Если сервер БД запущена с проверкой SQL Server:  
"Server = «Название сервера»; Database = «Название базы данных»; Trusted_Connection = true"

<h1>5)	Запустить программу через .exe файл. Путь приложения:   </h1>
\SilverEQuality\SilverEQuality\bin\Debug\net6.0-windows\SilverEQuality.exe
