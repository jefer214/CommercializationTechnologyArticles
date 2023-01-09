use CommercializationTechnologyArticles

SELECT art.Id, art.Name, art.InternalIdentifier, art.ManufacturerIdentifier 
FROM Articles art
INNER JOIN 
ArticlesInCategories AS artInCat
ON art.id = artInCat.ArticleId
INNER JOIN 
AttributesInCategories AS attInCat
ON
artInCat.CategoryId = attInCat.CategoryId
WHERE
attInCat.AttributeId = 