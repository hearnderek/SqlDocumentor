using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestSqlDocumentor
{
    public class ValidQueries
    {
        public static string SimpleStar = "Select * from INFORMATION_SCHEMA.tables";
        public static string TwoSimpleStar = @"
Select * from INFORMATION_SCHEMA.tables
Select * from INFORMATION_SCHEMA.views
";
        public static string GoSeperatedTwoSimpleStar = @"
Select * from INFORMATION_SCHEMA.tables
GO
Select * from INFORMATION_SCHEMA.views
";

        public static string SimpleCTE = @"
WITH [cte_tbls] as (
	Select TABLE_NAME from INFORMATION_SCHEMA.tables
)
SELECT TABLE_NAME as tbl
FROM [cte_tbls]
";
        public static string SimpleSubscript = @"
SELECT TABLE_NAME as tbl
FROM (
	Select TABLE_NAME from INFORMATION_SCHEMA.tables
) subselect
";


        public static string GoSeperatedSimple = @"
Select TABLE_NAME from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME from INFORMATION_SCHEMA.tables as t
GO
Select TABLE_NAME from INFORMATION_SCHEMA.tables t
GO
Select TABLE_NAME as [tbl] from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME as tbl from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME [tbl] from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME tbl from INFORMATION_SCHEMA.tables
";

        public static string ScriptICareAbout = @"
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
";
        /// <summary>
        /// The two CONCAT lines are represented 
        /// SqlScalarRefExpression
        /// SqlColumnRefExpression
        /// 
        /// SqlColumnRefExpression inherits from SqlColumnRefExpression
        /// </summary>
        public static string ScriptICareAbout2 = @"
SELECT 
    CONCAT([INFORMATION_SCHEMA].[ts].[TABLE_SCHEMA], '.', [ts].[TABLE_NAME]) as tbl_full_name,
    CONCAT(INFORMATION_SCHEMA.ts.TABLE_SCHEMA, '.', ts.TABLE_NAME) as tbl_full_name2, 
    *
FROM INFORMATION_SCHEMA.tables ts
";

        public static string SimpleUnion = @"
select TABLE_SCHEMA, TABLE_NAME, TABLE_TYPE
FROM INFORMATION_SCHEMA.tables
UNION ALL
select TABLE_SCHEMA, TABLE_NAME, 'VIEW' as TABLE_TYPE
FROM INFORMATION_SCHEMA.VIEWS
";

        public static string[] GetAll()
        {
            return typeof(ValidQueries).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.FieldType == typeof(string))
                .Select(f => (string)f.GetValue(null))
                .ToArray();
        }
    }

    public static class ValidQueriesAdventureWorks
    {
        public static string Sample1 = @"
SELECT CompanyName
  FROM [SalesLT].[Customer]
 WHERE FirstName='James'
   AND MiddleName='D.'
   AND LastName='Kramer'
";
        public static string Batched1 = @"
SELECT CompanyName
  FROM [SalesLT].[Customer]
 WHERE FirstName='James'
   AND MiddleName='D.'
   AND LastName='Kramer';

GO

SELECT CompanyName
  FROM [SalesLT].[Customer]
";
    }


}
