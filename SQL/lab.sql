use Chinook

--3) select Name as ArtistName from Artist  Order By Name

--select top 10 ArtistId ???? hur skriva ut namn också?
--from Artist Order by Name

--5) Select * from Artist 
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


