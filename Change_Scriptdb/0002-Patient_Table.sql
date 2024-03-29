/*
   Wednesday, June 29, 20222:20:41 PM
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
ALTER TABLE dbo.Patient_Table
	DROP CONSTRAINT PK_Patient_Table
GO
ALTER TABLE dbo.Patient_Table ADD CONSTRAINT
	PK_Patient_Table PRIMARY KEY CLUSTERED 
	(
	Name,
	Last_Name,
	National_Code,
	ID,
	Birth_Date,
	Gender,
	Phone_Num,
	Address,
	Vaccine_Name,
	Doses_Num,
	Dose1_Date,
	Dose2_Date
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Patient_Table SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
