pushd
cd .\SqlDocumentor\SqlDocumentor\bin\Debug\

$sql = "
SELECT TABLE_NAME as tbl
FROM (
	Select TABLE_NAME from INFORMATION_SCHEMA.tables
) [subselect]
"
& .\SqlDocumentor.exe $sql  | out-file -encoding utf8 -file "subselect.xml" 


$sql = "
WITH [cte_tbls] as (
	Select TABLE_NAME from INFORMATION_SCHEMA.tables
)
SELECT TABLE_NAME as tbl
FROM [cte_tbls]
"

& .\SqlDocumentor.exe  $sql | out-file -encoding utf8 -file "cte.xml"


$sql = "
SELECT 
    TABLE_SCHEMA,
	TABLE_NAME as tbl,
    CONCAT(TABLE_SCHEMA, '.', TABLE_NAME) as tbl_full_name, 
    CONCAT(INFORMATION_SCHEMA.ts.TABLE_SCHEMA, '.', ts.TABLE_NAME) as tbl_full_name2, 
    CONCAT([INFORMATION_SCHEMA].[ts].[TABLE_SCHEMA], '.', [ts].[TABLE_NAME]) as tbl_full_name3, 
    1 as [one1],
    1 [one2],
    1 one3,
    1 as one3,
    *,
    (select 2) as [two],
    ROW_NUMBER() OVER(ORDER BY TABLE_NAME ASC) AS Row
FROM INFORMATION_SCHEMA.tables ts
"

& .\SqlDocumentor.exe  $sql | out-file -encoding utf8 -file "multiColumnSelect.xml"

popd