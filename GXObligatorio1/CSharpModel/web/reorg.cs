/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:44:0.24
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public reorg( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         SetCreateDataBase( ) ;
         CreateDataBase( ) ;
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void CreateDataBase( )
      {
         DS = (GxDataStore)(context.GetDataStore( "Default"));
         ErrCode = DS.Connection.FullConnect();
         DataBaseName = DS.Connection.Database;
         if ( ErrCode != 0 )
         {
            DS.Connection.Database = "";
            ErrCode = DS.Connection.FullConnect();
            if ( ErrCode == 0 )
            {
               try
               {
                  GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("GXM_dbcrea")+ " " +DataBaseName , null);
                  cmdBuffer = "CREATE DATABASE " + "[" + DataBaseName + "]";
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
                  Count = 1;
               }
               catch ( Exception ex )
               {
                  ErrCode = 1;
                  GeneXus.Reorg.GXReorganization.AddMsg( ex.Message , null);
                  throw ex ;
               }
               ErrCode = DS.Connection.Disconnect();
               DS.Connection.Database = DataBaseName;
               ErrCode = DS.Connection.FullConnect();
               while ( ( ErrCode != 0 ) && ( Count > 0 ) && ( Count < 30 ) )
               {
                  Res = GXUtil.Sleep( 1);
                  ErrCode = DS.Connection.FullConnect();
                  Count = (short)(Count+1);
               }
               setupDB = 0;
               if ( ( setupDB == 1 ) || GeneXus.Configuration.Preferences.MustSetupDB( ) )
               {
                  defaultUsers = GXUtil.DefaultWebUser( context);
                  short gxidx ;
                  gxidx = 1;
                  while ( gxidx <= defaultUsers.Count )
                  {
                     defaultUser = ((String)defaultUsers.Item(gxidx));
                     try
                     {
                        GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("GXM_dbadduser", new   object[]  {defaultUser, DataBaseName}) , null);
                        cmdBuffer = "CREATE LOGIN " + "[" + defaultUser + "]" + " FROM WINDOWS";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "CREATE USER " + "[" + defaultUser + "]" + " FOR LOGIN " + "[" + defaultUser + "]";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "EXEC sp_addrolemember N'db_datareader', N'" + defaultUser + "'";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "EXEC sp_addrolemember N'db_datawriter', N'" + defaultUser + "'";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     gxidx = (short)(gxidx+1);
                  }
               }
            }
            if ( ErrCode != 0 )
            {
               ErrMsg = DS.ErrDescription;
               GeneXus.Reorg.GXReorganization.AddMsg( ErrMsg , null);
               ErrCode = 1;
               throw new Exception( ErrMsg) ;
            }
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void CreateEspectaculoLocalidadSector( )
      {
         String cmdBuffer = "" ;
         /* Indices for table EspectaculoLocalidadSector */
         try
         {
            cmdBuffer=" CREATE TABLE [EspectaculoLocalidadSector] ([EspectaculoId] smallint NOT NULL , [LocalidadId] smallint NOT NULL , [SectorId] smallint NOT NULL , [SectorNombre] nchar(100) NOT NULL , PRIMARY KEY([EspectaculoId], [LocalidadId], [SectorId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[EspectaculoLocalidadSector]") ;
               cmdBuffer=" DROP TABLE [EspectaculoLocalidadSector] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[EspectaculoLocalidadSector]") ;
                  cmdBuffer=" DROP VIEW [EspectaculoLocalidadSector] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[EspectaculoLocalidadSector]") ;
                     cmdBuffer=" DROP FUNCTION [EspectaculoLocalidadSector] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [EspectaculoLocalidadSector] ([EspectaculoId] smallint NOT NULL , [LocalidadId] smallint NOT NULL , [SectorId] smallint NOT NULL , [SectorNombre] nchar(100) NOT NULL , PRIMARY KEY([EspectaculoId], [LocalidadId], [SectorId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE UNIQUE NONCLUSTERED INDEX [UESPECTACULOLOCALIDADSECTOR] ON [EspectaculoLocalidadSector] ([SectorNombre] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [UESPECTACULOLOCALIDADSECTOR] ON [EspectaculoLocalidadSector] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE UNIQUE NONCLUSTERED INDEX [UESPECTACULOLOCALIDADSECTOR] ON [EspectaculoLocalidadSector] ([SectorNombre] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateEspectaculoLocalidad( )
      {
         String cmdBuffer = "" ;
         /* Indices for table EspectaculoLocalidad */
         try
         {
            cmdBuffer=" CREATE TABLE [EspectaculoLocalidad] ([EspectaculoId] smallint NOT NULL , [LocalidadId] smallint NOT NULL , [LocalidadNombre] nchar(100) NOT NULL , [LocalidadCapacidad] int NOT NULL , [LocalidadPrecio] money NOT NULL , [LocalidadesVendidas] int NOT NULL , PRIMARY KEY([EspectaculoId], [LocalidadId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[EspectaculoLocalidad]") ;
               cmdBuffer=" DROP TABLE [EspectaculoLocalidad] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[EspectaculoLocalidad]") ;
                  cmdBuffer=" DROP VIEW [EspectaculoLocalidad] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[EspectaculoLocalidad]") ;
                     cmdBuffer=" DROP FUNCTION [EspectaculoLocalidad] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [EspectaculoLocalidad] ([EspectaculoId] smallint NOT NULL , [LocalidadId] smallint NOT NULL , [LocalidadNombre] nchar(100) NOT NULL , [LocalidadCapacidad] int NOT NULL , [LocalidadPrecio] money NOT NULL , [LocalidadesVendidas] int NOT NULL , PRIMARY KEY([EspectaculoId], [LocalidadId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateTipoEspectaculo( )
      {
         String cmdBuffer = "" ;
         /* Indices for table TipoEspectaculo */
         try
         {
            cmdBuffer=" CREATE TABLE [TipoEspectaculo] ([TipoEspectaculoId] smallint NOT NULL IDENTITY(1,1), [TipoEspectaculoNombre] nchar(100) NOT NULL , PRIMARY KEY([TipoEspectaculoId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[TipoEspectaculo]") ;
               cmdBuffer=" DROP TABLE [TipoEspectaculo] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[TipoEspectaculo]") ;
                  cmdBuffer=" DROP VIEW [TipoEspectaculo] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[TipoEspectaculo]") ;
                     cmdBuffer=" DROP FUNCTION [TipoEspectaculo] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [TipoEspectaculo] ([TipoEspectaculoId] smallint NOT NULL IDENTITY(1,1), [TipoEspectaculoNombre] nchar(100) NOT NULL , PRIMARY KEY([TipoEspectaculoId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE UNIQUE NONCLUSTERED INDEX [UTIPOESPECTACULO] ON [TipoEspectaculo] ([TipoEspectaculoNombre] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [UTIPOESPECTACULO] ON [TipoEspectaculo] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE UNIQUE NONCLUSTERED INDEX [UTIPOESPECTACULO] ON [TipoEspectaculo] ([TipoEspectaculoNombre] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateVenta( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Venta */
         try
         {
            cmdBuffer=" CREATE TABLE [Venta] ([VentaId] smallint NOT NULL IDENTITY(1,1), [VentaFecha] datetime NOT NULL , [EspectaculoId] smallint NOT NULL , [VentaCantidadEntradas] smallint NOT NULL , [LocalidadId] smallint NOT NULL , [SectorId] smallint NOT NULL , PRIMARY KEY([VentaId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Venta]") ;
               cmdBuffer=" DROP TABLE [Venta] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Venta]") ;
                  cmdBuffer=" DROP VIEW [Venta] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Venta]") ;
                     cmdBuffer=" DROP FUNCTION [Venta] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Venta] ([VentaId] smallint NOT NULL IDENTITY(1,1), [VentaFecha] datetime NOT NULL , [EspectaculoId] smallint NOT NULL , [VentaCantidadEntradas] smallint NOT NULL , [LocalidadId] smallint NOT NULL , [SectorId] smallint NOT NULL , PRIMARY KEY([VentaId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IVENTA2] ON [Venta] ([EspectaculoId] ,[LocalidadId] ,[SectorId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [IVENTA2] ON [Venta] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IVENTA2] ON [Venta] ([EspectaculoId] ,[LocalidadId] ,[SectorId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateEspectaculo( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Espectaculo */
         try
         {
            cmdBuffer=" CREATE TABLE [Espectaculo] ([EspectaculoId] smallint NOT NULL IDENTITY(1,1), [EspectaculoNombre] nchar(100) NOT NULL , [EspectaculoFecha] datetime NOT NULL , [LugarId] smallint NOT NULL , [TipoEspectaculoId] smallint NOT NULL , PRIMARY KEY([EspectaculoId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Espectaculo]") ;
               cmdBuffer=" DROP TABLE [Espectaculo] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Espectaculo]") ;
                  cmdBuffer=" DROP VIEW [Espectaculo] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Espectaculo]") ;
                     cmdBuffer=" DROP FUNCTION [Espectaculo] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Espectaculo] ([EspectaculoId] smallint NOT NULL IDENTITY(1,1), [EspectaculoNombre] nchar(100) NOT NULL , [EspectaculoFecha] datetime NOT NULL , [LugarId] smallint NOT NULL , [TipoEspectaculoId] smallint NOT NULL , PRIMARY KEY([EspectaculoId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IESPECTACULO4] ON [Espectaculo] ([LugarId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [IESPECTACULO4] ON [Espectaculo] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IESPECTACULO4] ON [Espectaculo] ([LugarId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IESPECTACULO3] ON [Espectaculo] ([TipoEspectaculoId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [IESPECTACULO3] ON [Espectaculo] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IESPECTACULO3] ON [Espectaculo] ([TipoEspectaculoId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateLugar( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Lugar */
         try
         {
            cmdBuffer=" CREATE TABLE [Lugar] ([LugarId] smallint NOT NULL IDENTITY(1,1), [LugarNombre] nchar(100) NOT NULL , [LugarFoto] VARBINARY(MAX) NOT NULL , [LugarFoto_GXI] varchar(2048) NULL , [PaisId] smallint NOT NULL , [CiudadId] smallint NOT NULL , PRIMARY KEY([LugarId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Lugar]") ;
               cmdBuffer=" DROP TABLE [Lugar] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Lugar]") ;
                  cmdBuffer=" DROP VIEW [Lugar] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Lugar]") ;
                     cmdBuffer=" DROP FUNCTION [Lugar] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Lugar] ([LugarId] smallint NOT NULL IDENTITY(1,1), [LugarNombre] nchar(100) NOT NULL , [LugarFoto] VARBINARY(MAX) NOT NULL , [LugarFoto_GXI] varchar(2048) NULL , [PaisId] smallint NOT NULL , [CiudadId] smallint NOT NULL , PRIMARY KEY([LugarId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ILUGAR1] ON [Lugar] ([PaisId] ,[CiudadId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [ILUGAR1] ON [Lugar] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ILUGAR1] ON [Lugar] ([PaisId] ,[CiudadId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreatePaisCiudad( )
      {
         String cmdBuffer = "" ;
         /* Indices for table PaisCiudad */
         try
         {
            cmdBuffer=" CREATE TABLE [PaisCiudad] ([PaisId] smallint NOT NULL , [CiudadId] smallint NOT NULL , [CiudadNombre] nchar(100) NOT NULL , PRIMARY KEY([PaisId], [CiudadId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[PaisCiudad]") ;
               cmdBuffer=" DROP TABLE [PaisCiudad] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[PaisCiudad]") ;
                  cmdBuffer=" DROP VIEW [PaisCiudad] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[PaisCiudad]") ;
                     cmdBuffer=" DROP FUNCTION [PaisCiudad] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [PaisCiudad] ([PaisId] smallint NOT NULL , [CiudadId] smallint NOT NULL , [CiudadNombre] nchar(100) NOT NULL , PRIMARY KEY([PaisId], [CiudadId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreatePais( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Pais */
         try
         {
            cmdBuffer=" CREATE TABLE [Pais] ([PaisId] smallint NOT NULL IDENTITY(1,1), [PaisNombre] nchar(100) NOT NULL , [PaisBandera] VARBINARY(MAX) NOT NULL , [PaisBandera_GXI] varchar(2048) NULL , PRIMARY KEY([PaisId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Pais]") ;
               cmdBuffer=" DROP TABLE [Pais] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Pais]") ;
                  cmdBuffer=" DROP VIEW [Pais] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Pais]") ;
                     cmdBuffer=" DROP FUNCTION [Pais] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Pais] ([PaisId] smallint NOT NULL IDENTITY(1,1), [PaisNombre] nchar(100) NOT NULL , [PaisBandera] VARBINARY(MAX) NOT NULL , [PaisBandera_GXI] varchar(2048) NULL , PRIMARY KEY([PaisId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE UNIQUE NONCLUSTERED INDEX [UPAIS] ON [Pais] ([PaisNombre] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [UPAIS] ON [Pais] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE UNIQUE NONCLUSTERED INDEX [UPAIS] ON [Pais] ([PaisNombre] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIPaisCiudadPais( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [PaisCiudad] ADD CONSTRAINT [IPAISCIUDAD1] FOREIGN KEY ([PaisId]) REFERENCES [Pais] ([PaisId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [PaisCiudad] DROP CONSTRAINT [IPAISCIUDAD1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [PaisCiudad] ADD CONSTRAINT [IPAISCIUDAD1] FOREIGN KEY ([PaisId]) REFERENCES [Pais] ([PaisId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RILugarPaisCiudad( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Lugar] ADD CONSTRAINT [ILUGAR1] FOREIGN KEY ([PaisId], [CiudadId]) REFERENCES [PaisCiudad] ([PaisId], [CiudadId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Lugar] DROP CONSTRAINT [ILUGAR1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Lugar] ADD CONSTRAINT [ILUGAR1] FOREIGN KEY ([PaisId], [CiudadId]) REFERENCES [PaisCiudad] ([PaisId], [CiudadId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIEspectaculoLugar( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Espectaculo] ADD CONSTRAINT [IESPECTACULO4] FOREIGN KEY ([LugarId]) REFERENCES [Lugar] ([LugarId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Espectaculo] DROP CONSTRAINT [IESPECTACULO4] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Espectaculo] ADD CONSTRAINT [IESPECTACULO4] FOREIGN KEY ([LugarId]) REFERENCES [Lugar] ([LugarId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIEspectaculoTipoEspectaculo( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Espectaculo] ADD CONSTRAINT [IESPECTACULO3] FOREIGN KEY ([TipoEspectaculoId]) REFERENCES [TipoEspectaculo] ([TipoEspectaculoId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Espectaculo] DROP CONSTRAINT [IESPECTACULO3] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Espectaculo] ADD CONSTRAINT [IESPECTACULO3] FOREIGN KEY ([TipoEspectaculoId]) REFERENCES [TipoEspectaculo] ([TipoEspectaculoId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIVentaEspectaculoLocalidadSector( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Venta] ADD CONSTRAINT [IVENTA2] FOREIGN KEY ([EspectaculoId], [LocalidadId], [SectorId]) REFERENCES [EspectaculoLocalidadSector] ([EspectaculoId], [LocalidadId], [SectorId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Venta] DROP CONSTRAINT [IVENTA2] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Venta] ADD CONSTRAINT [IVENTA2] FOREIGN KEY ([EspectaculoId], [LocalidadId], [SectorId]) REFERENCES [EspectaculoLocalidadSector] ([EspectaculoId], [LocalidadId], [SectorId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIEspectaculoLocalidadEspectaculo( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [EspectaculoLocalidad] ADD CONSTRAINT [IESPECTACULOLOCALIDAD1] FOREIGN KEY ([EspectaculoId]) REFERENCES [Espectaculo] ([EspectaculoId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [EspectaculoLocalidad] DROP CONSTRAINT [IESPECTACULOLOCALIDAD1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [EspectaculoLocalidad] ADD CONSTRAINT [IESPECTACULOLOCALIDAD1] FOREIGN KEY ([EspectaculoId]) REFERENCES [Espectaculo] ([EspectaculoId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIEspectaculoLocalidadSectorEspectaculoLocalidad( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [EspectaculoLocalidadSector] ADD CONSTRAINT [IESPECTACULOLOCALIDADSECTOR1] FOREIGN KEY ([EspectaculoId], [LocalidadId]) REFERENCES [EspectaculoLocalidad] ([EspectaculoId], [LocalidadId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [EspectaculoLocalidadSector] DROP CONSTRAINT [IESPECTACULOLOCALIDADSECTOR1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [EspectaculoLocalidadSector] ADD CONSTRAINT [IESPECTACULOLOCALIDADSECTOR1] FOREIGN KEY ([EspectaculoId], [LocalidadId]) REFERENCES [EspectaculoLocalidad] ([EspectaculoId], [LocalidadId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               sSchemaVar = P00012_AsSchemaVar[0];
               nsSchemaVar = P00012_nsSchemaVar[0];
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P00023 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00023_AsSchemaVar[0];
               nsSchemaVar = P00023_nsSchemaVar[0];
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         return true ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "CreateEspectaculoLocalidadSector" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "CreateEspectaculoLocalidad" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 3 ,  "CreateTipoEspectaculo" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 4 ,  "CreateVenta" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 5 ,  "CreateEspectaculo" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 6 ,  "CreateLugar" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 7 ,  "CreatePaisCiudad" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 8 ,  "CreatePais" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 9 ,  "RIPaisCiudadPais" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 10 ,  "RILugarPaisCiudad" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 11 ,  "RIEspectaculoLugar" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 12 ,  "RIEspectaculoTipoEspectaculo" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 13 ,  "RIVentaEspectaculoLocalidadSector" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 14 ,  "RIEspectaculoLocalidadEspectaculo" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 15 ,  "RIEspectaculoLocalidadSectorEspectaculoLocalidad" , new Object[]{ });
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"EspectaculoLocalidadSector", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateEspectaculoLocalidadSector" ,  "CreateEspectaculoLocalidad" );
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"EspectaculoLocalidad", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateEspectaculoLocalidad" ,  "CreateEspectaculo" );
         GXReorganization.SetMsg( 3 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"TipoEspectaculo", ""}) );
         GXReorganization.SetMsg( 4 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Venta", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateVenta" ,  "CreateEspectaculoLocalidadSector" );
         GXReorganization.SetMsg( 5 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Espectaculo", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateEspectaculo" ,  "CreateLugar" );
         ReorgExecute.RegisterPrecedence( "CreateEspectaculo" ,  "CreateTipoEspectaculo" );
         GXReorganization.SetMsg( 6 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Lugar", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateLugar" ,  "CreatePaisCiudad" );
         GXReorganization.SetMsg( 7 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"PaisCiudad", ""}) );
         ReorgExecute.RegisterPrecedence( "CreatePaisCiudad" ,  "CreatePais" );
         GXReorganization.SetMsg( 8 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Pais", ""}) );
      }

      private void SetPrecedenceris( )
      {
         GXReorganization.SetMsg( 9 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IPAISCIUDAD1]"}) );
         ReorgExecute.RegisterPrecedence( "RIPaisCiudadPais" ,  "CreatePaisCiudad" );
         ReorgExecute.RegisterPrecedence( "RIPaisCiudadPais" ,  "CreatePais" );
         GXReorganization.SetMsg( 10 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[ILUGAR1]"}) );
         ReorgExecute.RegisterPrecedence( "RILugarPaisCiudad" ,  "CreateLugar" );
         ReorgExecute.RegisterPrecedence( "RILugarPaisCiudad" ,  "CreatePaisCiudad" );
         GXReorganization.SetMsg( 11 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IESPECTACULO4]"}) );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoLugar" ,  "CreateEspectaculo" );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoLugar" ,  "CreateLugar" );
         GXReorganization.SetMsg( 12 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IESPECTACULO3]"}) );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoTipoEspectaculo" ,  "CreateEspectaculo" );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoTipoEspectaculo" ,  "CreateTipoEspectaculo" );
         GXReorganization.SetMsg( 13 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IVENTA2]"}) );
         ReorgExecute.RegisterPrecedence( "RIVentaEspectaculoLocalidadSector" ,  "CreateVenta" );
         ReorgExecute.RegisterPrecedence( "RIVentaEspectaculoLocalidadSector" ,  "CreateEspectaculoLocalidadSector" );
         GXReorganization.SetMsg( 14 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IESPECTACULOLOCALIDAD1]"}) );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoLocalidadEspectaculo" ,  "CreateEspectaculoLocalidad" );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoLocalidadEspectaculo" ,  "CreateEspectaculo" );
         GXReorganization.SetMsg( 15 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IESPECTACULOLOCALIDADSECTOR1]"}) );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoLocalidadSectorEspectaculoLocalidad" ,  "CreateEspectaculoLocalidadSector" );
         ReorgExecute.RegisterPrecedence( "RIEspectaculoLocalidadSectorEspectaculoLocalidad" ,  "CreateEspectaculoLocalidad" );
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public void DropTableConstraints( String sTableName )
      {
         String cmdBuffer ;
         /* Using cursor P00034 */
         pr_default.execute(2, new Object[] {sTableName});
         while ( (pr_default.getStatus(2) != 101) )
         {
            constid = P00034_Aconstid[0];
            nconstid = P00034_nconstid[0];
            fkeyid = P00034_Afkeyid[0];
            nfkeyid = P00034_nfkeyid[0];
            rkeyid = P00034_Arkeyid[0];
            nrkeyid = P00034_nrkeyid[0];
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         DS = new GxDataStore();
         ErrMsg = "";
         DataBaseName = "";
         defaultUsers = new GeneXus.Utils.GxStringCollection();
         defaultUser = "";
         sSchemaVar = "";
         nsSchemaVar = false;
         scmdbuf = "";
         P00012_AsSchemaVar = new String[] {""} ;
         P00012_nsSchemaVar = new bool[] {false} ;
         P00023_AsSchemaVar = new String[] {""} ;
         P00023_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         constid = "";
         nconstid = false;
         fkeyid = "";
         nfkeyid = false;
         P00034_Aconstid = new String[] {""} ;
         P00034_nconstid = new bool[] {false} ;
         P00034_Afkeyid = new String[] {""} ;
         P00034_nfkeyid = new bool[] {false} ;
         P00034_Arkeyid = new int[1] ;
         P00034_nrkeyid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AsSchemaVar
               }
               , new Object[] {
               P00023_AsSchemaVar
               }
               , new Object[] {
               P00034_Aconstid, P00034_Afkeyid, P00034_Arkeyid
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected short Count ;
      protected short Res ;
      protected short setupDB ;
      protected int rkeyid ;
      protected String ErrMsg ;
      protected String DataBaseName ;
      protected String cmdBuffer ;
      protected String defaultUser ;
      protected String sSchemaVar ;
      protected String scmdbuf ;
      protected String sTableName ;
      protected bool nsSchemaVar ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected String constid ;
      protected String fkeyid ;
      protected GeneXus.Utils.GxStringCollection defaultUsers ;
      protected GxDataStore DS ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected String[] P00012_AsSchemaVar ;
      protected bool[] P00012_nsSchemaVar ;
      protected String[] P00023_AsSchemaVar ;
      protected bool[] P00023_nsSchemaVar ;
      protected String[] P00034_Aconstid ;
      protected bool[] P00034_nconstid ;
      protected String[] P00034_Afkeyid ;
      protected bool[] P00034_nfkeyid ;
      protected int[] P00034_Arkeyid ;
      protected bool[] P00034_nrkeyid ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.NChar,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00023", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P00034", "SELECT OBJECT_NAME(object_id), OBJECT_NAME(parent_object_id), referenced_object_id FROM sys.foreign_keys WHERE referenced_object_id = OBJECT_ID(RTRIM(LTRIM(@sTableName))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
