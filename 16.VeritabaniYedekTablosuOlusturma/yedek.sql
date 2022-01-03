create trigger yedek
on Kitaplar
after delete
as 

declare @kitapad varchar(50)
declare @kitapyazar varchar(50)
declare @kitapsayfa char(3)
declare @kitapyayinevi varchar(20)
declare @kitaptur varchar(20)

select @kitapad = KitapAd,@kitapyazar=KitapYazar, @kitapsayfa=KitapSayfa,@kitapyayinevi=KitapYayinEvi, @kitaptur=KitapTur from deleted
insert into KitapYedek(KitapAd,KitapYazar,KitapSayfa,KitapYayinEvi,KitapTur) values(@kitapad, @kitapyazar,@kitapsayfa, @kitapyayinevi, @kitaptur)