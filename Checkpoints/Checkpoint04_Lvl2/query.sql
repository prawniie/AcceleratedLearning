--Info about the churches
select City, YearBuilt, Name
from Church

-- Where the inhabitans live
select Name, City
from Person

-- All inhabitants and the churches that they like + year
select Person.Name, Church.Name, Church.YearBuilt
from Church
join PersonChurch on Church.ChurchId = PersonChurch.ChurchId
join Person on PersonChurch.PersonId = Person.PersonId