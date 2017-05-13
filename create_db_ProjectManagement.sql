/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2017-02-15 16:57:15                          */
/*==============================================================*/

Create database ProjectManagementSystem
go
use ProjectManagementSystem
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROJECTS') and o.name = 'FK_PROJECTS_REFERENCE_PROJECT_')
alter table PROJECTS
   drop constraint FK_PROJECTS_REFERENCE_PROJECT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROJECT_TASKS') and o.name = 'FK_PROJECT__REFERENCE_PROJECTS')
alter table PROJECT_TASKS
   drop constraint FK_PROJECT__REFERENCE_PROJECTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROJECT_TASKS') and o.name = 'FK_PROJECT__REFERENCE_EXPERTS')
alter table PROJECT_TASKS
   drop constraint FK_PROJECT__REFERENCE_EXPERTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROJECT_TASKS') and o.name = 'FK_PROJECT__REFERENCE_TASK_STA')
alter table PROJECT_TASKS
   drop constraint FK_PROJECT__REFERENCE_TASK_STA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXPERTS')
            and   type = 'U')
   drop table EXPERTS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROJECTS')
            and   name  = 'IDX_PROJECT_UQ'
            and   indid > 0
            and   indid < 255)
   drop index PROJECTS.IDX_PROJECT_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROJECTS')
            and   type = 'U')
   drop table PROJECTS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROJECT_STATUS')
            and   name  = 'IDX_PROJECT_STATUS_UQ'
            and   indid > 0
            and   indid < 255)
   drop index PROJECT_STATUS.IDX_PROJECT_STATUS_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROJECT_STATUS')
            and   type = 'U')
   drop table PROJECT_STATUS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROJECT_TASKS')
            and   name  = 'IDX_PROJECT_TASK'
            and   indid > 0
            and   indid < 255)
   drop index PROJECT_TASKS.IDX_PROJECT_TASK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROJECT_TASKS')
            and   type = 'U')
   drop table PROJECT_TASKS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TASK_STATUS')
            and   name  = 'IDX_TASK_STATUS_UQ'
            and   indid > 0
            and   indid < 255)
   drop index TASK_STATUS.IDX_TASK_STATUS_UQ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TASK_STATUS')
            and   type = 'U')
   drop table TASK_STATUS
go

/*==============================================================*/
/* Table: EXPERTS                                               */
/*==============================================================*/
create table EXPERTS (
   EXPRET_ID            numeric              not null IDENTITY(1,1),
   EXPERT_TYPE          char(1)              not null
      constraint CKC_EXPERT_TYPE_EXPERTS check (EXPERT_TYPE in ('I','E')),
   EXPERT_NAME          nvarchar(50)          null,
   EXPERT_SURNAME       nvarchar(50)          null,
   EXPERT_LASTNAME      nvarchar(50)          null,
   constraint PK_EXPERTS primary key (EXPRET_ID)
)
go

/*==============================================================*/
/* Table: PROJECTS                                              */
/*==============================================================*/
create table PROJECTS (
   PROJECT_ID           numeric              not null,
   PROJECT_NAME         nvarchar(100)         not null,
   PROJECT_DESCRIPTION  nvarchar(1000)        null,
   PROJECT_CLIENT       nvarchar(100)         not null,
   PROJECT_BEGIN        date                 not null,
   PROJECT_END          date                 not null,
   PROJECT_STATUS       numeric              not null,
   PROJECT_PAY_PER_HOUR numeric(10,2)        null,
   constraint PK_PROJECTS primary key (PROJECT_ID)
)
go

/*==============================================================*/
/* Index: IDX_PROJECT_UQ                                        */
/*==============================================================*/
create unique index IDX_PROJECT_UQ on PROJECTS (
PROJECT_NAME ASC
)
go

/*==============================================================*/
/* Table: PROJECT_STATUS                                        */
/*==============================================================*/
create table PROJECT_STATUS (
   PSTATUS_ID           numeric              identity,
   PSTATUS_NAME         nvarchar(20)          not null,
   constraint PK_PROJECT_STATUS primary key (PSTATUS_ID)
)
go

/*==============================================================*/
/* Index: IDX_PROJECT_STATUS_UQ                                 */
/*==============================================================*/
create unique index IDX_PROJECT_STATUS_UQ on PROJECT_STATUS (
PSTATUS_NAME ASC
)
go

/*==============================================================*/
/* Table: PROJECT_TASKS                                         */
/*==============================================================*/
create table PROJECT_TASKS (
   TASK_ID              numeric              not null IDENTITY(1,1),
   PROJECT_ID           numeric              not null,
   EXPRET_ID            numeric              not null,
   TASK_NAME            nvarchar(50)          not null,
   TASK_DESCRIPTION     nvarchar(400)         null,
   TAS_DELIVERABLES     nvarchar(400)         null,
   TASK_BEGIN           date                 not null,
   TASK_END             date                 not null,
   TASK_PRIORITY        char(1)              not null
      constraint CKC_TASK_PRIORITY_PROJECT_ check (TASK_PRIORITY in ('H','M','L')),
   TASK_STATUS          numeric              not null,
   TASK_READY           numeric              null,
   TASK_HOURS           numeric              null,
   constraint PK_PROJECT_TASKS primary key (TASK_ID)
)
go

/*==============================================================*/
/* Index: IDX_PROJECT_TASK                                      */
/*==============================================================*/
create unique index IDX_PROJECT_TASK on PROJECT_TASKS (
PROJECT_ID ASC,
TASK_NAME ASC
)
go

/*==============================================================*/
/* Table: TASK_STATUS                                           */
/*==============================================================*/
create table TASK_STATUS (
   STATUS_ID            numeric              identity,
   STATUS_NAME          nvarchar(20)          not null,
   constraint PK_TASK_STATUS primary key (STATUS_ID)
)
go

/*==============================================================*/
/* Index: IDX_TASK_STATUS_UQ                                    */
/*==============================================================*/
create unique index IDX_TASK_STATUS_UQ on TASK_STATUS (
STATUS_NAME ASC
)
go

alter table PROJECTS
   add constraint FK_PROJECTS_REFERENCE_PROJECT_ foreign key (PROJECT_STATUS)
      references PROJECT_STATUS (PSTATUS_ID)
go

alter table PROJECT_TASKS
   add constraint FK_PROJECT__REFERENCE_PROJECTS foreign key (PROJECT_ID)
      references PROJECTS (PROJECT_ID)
go

alter table PROJECT_TASKS
   add constraint FK_PROJECT__REFERENCE_EXPERTS foreign key (EXPRET_ID)
      references EXPERTS (EXPRET_ID)
go

alter table PROJECT_TASKS
   add constraint FK_PROJECT__REFERENCE_TASK_STA foreign key (TASK_STATUS)
      references TASK_STATUS (STATUS_ID)
go

INSERT into TASK_STATUS 
VALUES (N'Планирана'), (N'Очаква одобрение'), (N'Одобрена'), (N'В изпълнение'), (N'Отказана'), (N'Изпълнена');

Insert into PROJECT_STATUS
Values (N'Нов'), (N'В изпълнение'), (N'Прекратен'), (N'Замразен')
