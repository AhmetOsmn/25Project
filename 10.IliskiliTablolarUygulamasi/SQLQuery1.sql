
SELECT h.HareketID, u.UrunAd as '�r�n ad�', (m.MusteriAd + ' '+ m.MusteriSoyad) as 'M��teri', (p.PersonelAd + ' ' + p.PersonelSoyad) as 'Personel', h.Fiyat 
From Hareketler h 
inner join Urunler u 
on h.Urun=u.UrunID 
inner join Musteriler m
on h.Musteri=m.MusteriID
inner join Personeller p
on h.Personel=p.PersonelID


select * from Hareketler
