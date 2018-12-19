use Chinook

--2)
--select * from Artist

--3) select Name as ArtistName 
--from Artist  
--Order By Name

--4) -- KOLLA OSCARS LÖSNING PÅ DENNA
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
--Where Title LIKE '[aeiouyåäö]%'

--8)
--select Artist.Name, Album.Title
--from Artist 
--full join Album
--on Artist.ArtistId = Album.ArtistId

--9)
-- innerjoin: endast de rader med fulla värden (ej null) joinas
-- left join: åtminstone hela vänstra (den första) tabellen kommer med (även om den har null värden)
-- right join: samma som ovan men för den andra tabellen
-- full join: båda tabellerna joinas, inkl null-värden

--10
--select top 10 Name as ArtistName, Count(Name) As NumberOfAlbums
--from Artist
--join Album
--on Artist.ArtistId = Album.ArtistId
--Group by Name
--Order by NumberOfAlbums DESC

--11) Lista namn på alla album som är Jazz eller Blues. Ett album ska bara finnas i listan en gång. (AlbumTitle)
--select distinct Album.Title, Genre.Name
--from Album
--join Track
--on Album.AlbumId = Track.AlbumId
--join Genre
--on Track.GenreId = Genre.GenreId
--where Genre.Name = 'Jazz'or Genre.Name = 'Blues'

--12) Modifiera tabellen Track så att den innehåller spårnummer, uppdatera track med värde för spårnumret i albumet Let there be rock
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

----För att skriva ut alla låtarna i albumet så man ser vilket id de har
--Select album.Title, Track.Name, Track.TrackId, Track.Number
--From Album
--join Track
--on Album.AlbumId = Track.AlbumId
--where Album.Title = 'Let there be rock'

--13)
--Lista genre och antal tracks i den genren. Visa den genre som har flest tracks först och sedan i nedåtstigande ordning. 
--Visa endast de genres som har fler än 100 tracks. (GenreName, NrOfTracks)

--Select Genre.Name as GenreName, count (Genre.Name) as NrOfTracks
--from Track
--join Genre
--on Track.GenreId = Genre.GenreId
--group by Genre.Name
--having count (Genre.Name) > 100
--order by NrOfTracks DESC

-- 14)
--Skapa en variabel som sparar CustomerId utifrån kunden "Leonie Köhler"
-- Använd denna variabel för att lista alla datum när en faktura till Leonie Köhler gått iväg (InvoiceDate)

--declare @customerId int;
--select @customerId = Customer.CustomerId
--from Customer
--where Customer.FirstName = 'Leonie' and Customer.LastName = 'Köhler'

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
--Lista alla anställda som har en chef och deras chef.
-- Resultatet ska vara två kolumner (ej 4) med den anställdes och chefens fullständiga namn
-- (EmployeeName, BossName)

--SELECT Employee.FirstName + Employee.LastName as EmployeeName, Employee2.FirstName + Employee2.LastName as BossName
--FROM Employee
--JOIN Employee AS Employee2
--ON Employee.ReportsTo = Employee2.EmployeeId

--SELECT *
--FROM employee

--17)
-- Ta reda på hur många tecken den längsta epostadressen har bland alla kunder (LongestMail)

--select top 1 with ties CustomerId, Email, len(Email) as EmailLength
--from Customer
--order by len(Email) desc

--18
--Ta reda på den eller de låtar som pågår längst tid 
--	Resultatet ska vara en rad med låttitel och längden på låten (Name, Minutes)

--select top 1 with ties Name, (Milliseconds/(1000*60)) as Minutes
--from Track
--order by (Milliseconds) desc

--19)
-- Skriv ett script som gör en av kolumner i Customer unique. Motivera ditt val

-- Valde att göra email unik, många konton hos hemsidor som bygger på att man bara kan ha en mailadress per person "Den här mailadressen finns redan registrerad"
--alter table Customer
--add unique (Email);

--select *
--from Customer

--insert into Customer(FirstName, LastName, Email)
--values ('Rebecka','Carlsson','aaronmitchell@yahoo.ca')
-- Funkar ej då mailadressen redan finns registerad

--20)
-- Lista hur mycket som har fakturerat för varje år (2009-2013). 
-- Sortera så senaste åren visas först (2013) (Year, Sum)

--select year(InvoiceDate) as Year, sum(Total) as Sum 
--from Invoice
--group by year(InvoiceDate)
--order by year(InvoiceDate) desc

--21)
-- Ta fram längsta spellistan. (Name, TotalLengthInHours)

--select top 1 PlayList.Name as Name, sum(Track.Milliseconds/(1000.0*3600.0)) as TotalLengthInHours
--from Playlist
--join PlaylistTrack
--on PlayList.PlaylistId = PlaylistTrack.PlaylistId
--join Track
--on PlaylistTrack.TrackId = Track.TrackId
--group by PlaylistTrack.PLayListId,PlayList.Name
--order by TotalLengthInHours desc

--22)
-- Lista alla anställda som har en chef och deras chefs chef. 
-- (EmployeeName, BossesBossName)

--SELECT Employee.FirstName + ' ' + Employee.LastName as EmployeeName, Employee3.FirstName + ' ' + Employee3.LastName as BossesBossName
--FROM Employee
--JOIN Employee AS Employee2
--ON Employee.ReportsTo = Employee2.EmployeeId
--JOIN Employee AS Employee3
--ON Employee.ReportsTo = Employee3.EmployeeId

--23)
--Skapa en ny tabell så varje album kan ha en recension
--Lägg till en review på albumet "Black Sabbath"

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