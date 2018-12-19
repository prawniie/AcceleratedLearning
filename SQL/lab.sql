use Chinook

--2)
--select * from Artist

--3) select Name as ArtistName 
--from Artist  
--Order By Name

--4) -- KOLLA OSCARS L�SNING P� DENNA
--select top 10 ArtistId, Name
--from Artist
--order by Name

--5) Select * from Artist 
--Where Name LIKE 'Academy%'

--Select Name 
--from Artist
--Where Name LIKE 'Academy%'

--6) Select Title
--From Album
--Where Title LIKE '_ar%'

--7) Select Title
--From Album
--Where Title LIKE '[aeiouy���]%'

--8)
--select Artist.Name, Album.Title
--from Artist 
--full join Album
--on Artist.ArtistId = Album.ArtistId

--9)
-- innerjoin: endast de rader med fulla v�rden (ej null) joinas
-- left join: �tminstone hela v�nstra (den f�rsta) tabellen kommer med (�ven om den har null v�rden)
-- right join: samma som ovan men f�r den andra tabellen
-- full join: b�da tabellerna joinas, inkl null-v�rden

--10
--select top 10 Name as ArtistName, Count(Name) As NumberOfAlbums
--from Artist
--join Album
--on Artist.ArtistId = Album.ArtistId
--Group by Name
--Order by NumberOfAlbums DESC

--11) Lista namn p� alla album som �r Jazz eller Blues. Ett album ska bara finnas i listan en g�ng. (AlbumTitle)
--select distinct Album.Title, Genre.Name
--from Album
--join Track
--on Album.AlbumId = Track.AlbumId
--join Genre
--on Track.GenreId = Genre.GenreId
--where Genre.Name = 'Jazz'or Genre.Name = 'Blues'

--12) Modifiera tabellen Track s� att den inneh�ller sp�rnummer, uppdatera track med v�rde f�r sp�rnumret i albumet Let there be rock
--alter table Track
--add Number int

--Update Track
--Set Number = 1
--Where TrackId = 15

--Update Track
--Set Number = 2
--Where TrackId = 16

--Update Track
--Set Number = 3
--Where TrackId = 17

--Update Track
--Set Number = 4
--Where TrackId = 18

--Update Track
--Set Number = 5
--Where TrackId = 19

--Update Track
--Set Number = 6
--Where TrackId = 20

--Update Track
--Set Number = 7
--Where TrackId = 21

--Update Track
--Set Number = 8
--Where TrackId = 22

----F�r att skriva ut alla l�tarna i albumet s� man ser vilket id de har
--Select album.Title, Track.Name, Track.TrackId, Track.Number
--From Album
--join Track
--on Album.AlbumId = Track.AlbumId
--where Album.Title = 'Let there be rock'

--13)
--Lista genre och antal tracks i den genren. Visa den genre som har flest tracks f�rst och sedan i ned�tstigande ordning. 
--Visa endast de genres som har fler �n 100 tracks. (GenreName, NrOfTracks)

--Select Genre.Name as GenreName, count (Genre.Name) as NrOfTracks
--from Track
--join Genre
--on Track.GenreId = Genre.GenreId
--group by Genre.Name
--having count (Genre.Name) > 100
--order by NrOfTracks DESC

-- 14)
--Skapa en variabel som sparar CustomerId utifr�n kunden "Leonie K�hler"
-- Anv�nd denna variabel f�r att lista alla datum n�r en faktura till Leonie K�hler g�tt iv�g (InvoiceDate)

--declare @customerId int;
--select @customerId = Customer.CustomerId
--from Customer
--where Customer.FirstName = 'Leonie' and Customer.LastName = 'K�hler'

--select invoicedate, Customer.FirstName, Customer.LastName
--from invoice
--full join customer
--on invoice.CustomerId = Customer.CustomerId
--where Customer.CustomerId = @customerId


--15)
--SELECT Customer.FirstName as CustomerFirstName, Customer.LastName as CustomerLastName, Employee.FirstName as SupportFirstName, Employee.LastName as SupportLastName
--INTO #CustomerWithSupport
--FROM Customer
--LEFT JOIN Employee ON Customer.SupportRepId = Employee.EmployeeId;

--SELECT *
--FROM #CustomerWithSupport

--16)
--Lista alla anst�llda som har en chef och deras chef.
-- Resultatet ska vara tv� kolumner (ej 4) med den anst�lldes och chefens fullst�ndiga namn
-- (EmployeeName, BossName)

--SELECT Employee.FirstName + Employee.LastName as EmployeeName, Employee2.FirstName + Employee2.LastName as BossName
--FROM Employee
--JOIN Employee AS Employee2
--ON Employee.ReportsTo = Employee2.EmployeeId

--SELECT *
--FROM employee

--17)
-- Ta reda p� hur m�nga tecken den l�ngsta epostadressen har bland alla kunder (LongestMail)

--select top 1 with ties CustomerId, Email, len(Email) as EmailLength
--from Customer
--order by len(Email) desc

--18
--Ta reda p� den eller de l�tar som p�g�r l�ngst tid 
--	Resultatet ska vara en rad med l�ttitel och l�ngden p� l�ten (Name, Minutes)

--select top 1 with ties Name, (Milliseconds/(1000*60)) as Minutes
--from Track
--order by (Milliseconds) desc

--19)
-- Skriv ett script som g�r en av kolumner i Customer unique. Motivera ditt val

-- Valde att g�ra email unik, m�nga konton hos hemsidor som bygger p� att man bara kan ha en mailadress per person "Den h�r mailadressen finns redan registrerad"
--alter table Customer
--add unique (Email);

--select *
--from Customer

--insert into Customer(FirstName, LastName, Email)
--values ('Rebecka','Carlsson','aaronmitchell@yahoo.ca')
-- Funkar ej d� mailadressen redan finns registerad

--20)
-- Lista hur mycket som har fakturerat f�r varje �r (2009-2013). 
-- Sortera s� senaste �ren visas f�rst (2013) (Year, Sum)

--select year(InvoiceDate) as Year, sum(Total) as Sum 
--from Invoice
--group by year(InvoiceDate)
--order by year(InvoiceDate) desc

--21)
-- Ta fram l�ngsta spellistan. (Name, TotalLengthInHours)

--select top 1 PlayList.Name as Name, sum(Track.Milliseconds/(1000.0*3600.0)) as TotalLengthInHours
--from Playlist
--join PlaylistTrack
--on PlayList.PlaylistId = PlaylistTrack.PlaylistId
--join Track
--on PlaylistTrack.TrackId = Track.TrackId
--group by PlaylistTrack.PLayListId,PlayList.Name
--order by TotalLengthInHours desc

--22)
-- Lista alla anst�llda som har en chef och deras chefs chef. 
-- (EmployeeName, BossesBossName)

--SELECT Employee.FirstName + ' ' + Employee.LastName as EmployeeName, Employee3.FirstName + ' ' + Employee3.LastName as BossesBossName
--FROM Employee
--JOIN Employee AS Employee2
--ON Employee.ReportsTo = Employee2.EmployeeId
--JOIN Employee AS Employee3
--ON Employee.ReportsTo = Employee3.EmployeeId

--23)
--Skapa en ny tabell s� varje album kan ha en recension
--L�gg till en review p� albumet "Black Sabbath"

--create table AlbumReview (
--	AlbumId int,
--	AlbumReview varchar(300)
--);



--insert into AlbumReview (AlbumId, AlbumReview)
--values (16,'hejhej')

--update AlbumReview 
--set AlbumReview = 'bra grejer'
--where AlbumId = 16

--select *
--from AlbumReview
--where AlbumId = 16