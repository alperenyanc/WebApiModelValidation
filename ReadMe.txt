Model Validation

web api içerisinde bir request body'sin aldýðýmýzda zorunluluk kontrollerini yapacaðýmýz sistemdir. DataAnotition üzerinde tanýmlýdýr ve model üzerinden gerçekleþtirebiilirsiniz. Þifre alanlarýnýn mail kýsmýmlarýnýn zorunluluklarýnýn yapýlmasý gibidir.


------------------------------web Api Türleri------------------------------------------------------------------------------
	1- Required
	2- Range:uzunluk
	3- CreditCard
	4- EmailAdress
	5- Compare: þifre alanýn iki defa yazýlmasý

	6- Url: kayýt yapýldýðýnda url isteyen olabilir. ve bu gerçekten url mi ona bakar.
	7- StringLenght: min max deðere aaralýðý belirlenir. karakter sayýsýný bakar
	8- REgularExpression: gerekli expressiýn yazularak doðrulamalar yapýlýr
	9- Phone: telefon numarasý ile ilgili kontrollerç
	
-------------------------------&&&&&&&&&&&&&&&&-----------------------------------------------------------------------------
	         Model Valitadion Kullaným Türleri
-----------------------------------------------------------------------------------------------------------------------------
	1- ModelStat: modalstate is valid mi ona bakar.
	2- Validatete Model: model attribute ile kontrol saðlanýyor.
	3- Validate model Filter : web api içerisinde oluþturduðumuz attrubuteleri filterlar eklediðimizde bir controller'a eklemeden hangi action üzerinden filter doðrulmasýý yapýlmasý.
-------------------------------&&&&&&&&&&&&&&&&------------------------------------------------------------------------------
-- MVC tarafýndan model is valid 'i kullandýk - altýnda hataa masajlarý cýkarma gibi.!