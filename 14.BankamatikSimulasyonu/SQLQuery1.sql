select (g.kisiAd + ' '+g.kisiSoyad) as 'Gonderen',  (a.kisiAd + ' '+a.kisiSoyad) as 'Alici', h.Tutar 
From Hareket h
inner join Kisiler g
on h.Gonderen=g.KisiHesapNo
inner join Kisiler a
on h.Alici = a.KisiHesapNo where g.KisiHesapNo = 766144 or a.KisiHesapNo=766144