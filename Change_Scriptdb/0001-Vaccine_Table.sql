/*
   Wednesday, June 29, 20222:16:32 PM
   User: 
   Server: DESKTOP-3HCFNDU\SQLEXPRESS
   Database: Vaccine_Project_db
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Vaccine_Table
	DROP CONSTRAINT PK_Vaccine_Table
GO
ALTER TABLE dbo.Vaccine_Table ADD CONSTRAINT
	PK_Vaccine_Table_1 PRIMARY KEY CLUSTERED 
	(
	Vaccine_Name,
	Doses_Num,
	Country_Of_Export
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Vaccine_Table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
