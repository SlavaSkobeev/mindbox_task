/* 
В БД находятся 3 таблицы 
1) Categories, со следующими полями id(уникальный идентификатор категории), nameCat (имя категории)
2) Product, со следующими полями id(уникальный идентификатор продукта), nameProd (имя продукта)
3) ProdToCat, со следующими полями idProd(внешний ключ к Product), idCat (внешний ключ к Categories)
*/

SELECT pr.nameProd, cat.nameCat
FROM Product pr LEFT JOIN ProdToCat ptc ON pr.id = ptc.idProd
                LEFT JOIN Categories cat ON cat.id=ptc.idCat
