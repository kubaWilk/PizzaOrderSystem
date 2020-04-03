# PizzaOrderSystem
Project supposed to show my skills for recruitment process

Prosta aplikacja symulująca zamawianie w pizzerii. Posiada możliwość rejestracji użytkownika jak i jego zalogowanie,
złożenie zamówienia czy przejrzenie historii składanych przez użytkownika zamówień. 
Do działania aplikacja wymaga SQL Server 2019(na tej wersji była testowana).
Projekt bazy danych zawiera skrypt DBProj.publish.xml, który powinien zająć się odpowiednim zorganizowaniem bazy danych.
W razie problemów ze skryptem proszę o kontakt.<br/><br/>

Cała konfiguracja dostępna w pliku PiizzeriaOrderApp/App.Config:<br/>
  connectionString <- jak nazwa wskazuje - należy uzupełnić o wymagany do połączenia z bazą danych connectionString
  (pole name musi mieć wartość "MainDB")<br/>
  MailSenderUserName <- login do konta E - mail, z którego aplikacja ma wysłać wiadomość<br/>
  MailSenderPassword <- hasło do tego konta<br/>
  MailSenderSmtpServer <- Serwer SMTP, z którego wysyłamy maila (ustawiony port 587)<br/>
  FromEmail <- E-mail, który ma być wpisany w pole "Od: " w wysyłanej wiadomości<br/>
  FromDisplayName <- Nazwa, która będzie się wyświetlać jako nadawca wiadomości<br/>
  <br/><br/>
Very basic app that simulates placing an order in a pizzeria. It has a functionality of registering a user, logging in, placing an order
or looking through orders history.
To work application needs SQL Server 2019(at least that's the version the app was tested on)
A project of data base contains a script DBProj.publish.xml which should take care of organizing a default database.
Should any problems occur please contact me.

Whole configuration available in PiizzeriaOrderApp/App.Config:<br/>
  connectionString <- as the name suggests - should be filled with a connectionString required for connection with a database
  (name field should have a value of "MainDB")<br/>
  MailSenderUserName <- E-Mail from which the application sends an email<br/>
  MailSenderPassword <- Password to that E-Mail<br/>
  MailSenderSmtpServer <- SMTP server from which a message is sent (port set in application is 587)<br/>
  FromEmail <- E-mail, which is going to be shown as "From"<br/>
  FromDisplayName <- Display Name "From" in the message<br/>
