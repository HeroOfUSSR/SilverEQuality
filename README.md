Так как приложение во время рецензирования будет запускаться на компьютере, не подключённом к локальной сети, необходимо установить на персональный компьютер базу данных и поменять строку подключения программы к ней. 
Программа не скомпилирована, поэтому чтобы не потеряться в файлах проекта, далее будет описана данная процедура.

1)	Необходимо найти файл скрипта базы данных. Находится он по следующему пути:
\SilverEQuality\SilverEQuality_Context\DatabaseScript\SilverEQ.sql

 ![image](https://github.com/HeroOfUSSR/SilverEQuality/assets/104492239/8350fc73-98d9-4573-b195-d1d8912cbf1e)
Рис.1 – Скрипт базы данных

2)	Запустить SQL Server Management и установить базу данных из скрипта
3)	Открыть конфигурационный файл программы. Называется он appsettings.json и лежит по пути:
\SilverEQuality\SilverEQuality_Context\appsettings.json

 ![image](https://github.com/HeroOfUSSR/SilverEQuality/assets/104492239/8eb17f58-c8bd-4d81-bb6d-b972dc42eb90)
Рис.2 – Конфигурационный файл выделен жёлтым

4)	После открытия необходимо заменить строку подключения по следующему шаблону:
Если сервер БД запущена с проверкой подлинности Windows:
"Server = «Название сервера»; Database = «Название базы данных»; Trusted_Connection = true"
Если сервер БД запущена с проверкой SQL Server:
"Server = «Название сервера»; Database = «Название базы данных»; Trusted_Connection = true"

5)	Запустить программу через .exe файл. Путь приложения:
\SilverEQuality\SilverEQuality\bin\Debug\net6.0-windows\SilverEQuality.exe
