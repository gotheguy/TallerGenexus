/*
               File: LugarConversion
        Description: Conversion for table Lugar
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:17:43.67
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class lugarconversion : GXProcedure
   {
      public lugarconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public lugarconversion( IGxContext context )
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

      public void executeSubmit( )
      {
         lugarconversion objlugarconversion;
         objlugarconversion = new lugarconversion();
         objlugarconversion.context.SetSubmitInitialConfig(context);
         objlugarconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlugarconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((lugarconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         cmdBuffer=" SET IDENTITY_INSERT [GXA0004] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor LUGARCONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A42CantEspectaculosLugar = LUGARCONVE2_A42CantEspectaculosLugar[0];
            n42CantEspectaculosLugar = LUGARCONVE2_n42CantEspectaculosLugar[0];
            A4CiudadId = LUGARCONVE2_A4CiudadId[0];
            A1PaisId = LUGARCONVE2_A1PaisId[0];
            A9LugarNombre = LUGARCONVE2_A9LugarNombre[0];
            A8LugarId = LUGARCONVE2_A8LugarId[0];
            A40000LugarFoto_GXI = LUGARCONVE2_A40000LugarFoto_GXI[0];
            A10LugarFoto = LUGARCONVE2_A10LugarFoto[0];
            /*
               INSERT RECORD ON TABLE GXA0004

            */
            AV2LugarId = A8LugarId;
            AV3LugarNombre = A9LugarNombre;
            AV4LugarFoto = A10LugarFoto;
            AV5LugarFoto_GXI = A40000LugarFoto_GXI;
            AV5LugarFoto_GXI = A40000LugarFoto_GXI;
            AV6PaisId = A1PaisId;
            AV7CiudadId = A4CiudadId;
            if ( LUGARCONVE2_n42CantEspectaculosLugar[0] )
            {
               AV8CantEspectaculosLugar = 0;
            }
            else
            {
               AV8CantEspectaculosLugar = A42CantEspectaculosLugar;
            }
            /* Using cursor LUGARCONVE3 */
            pr_default.execute(1, new Object[] {AV2LugarId, AV3LugarNombre, AV4LugarFoto, AV5LugarFoto_GXI, AV6PaisId, AV7CiudadId, AV8CantEspectaculosLugar});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0004") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         cmdBuffer=" SET IDENTITY_INSERT [GXA0004] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         cmdBuffer = "";
         scmdbuf = "";
         LUGARCONVE2_A42CantEspectaculosLugar = new short[1] ;
         LUGARCONVE2_n42CantEspectaculosLugar = new bool[] {false} ;
         LUGARCONVE2_A4CiudadId = new short[1] ;
         LUGARCONVE2_A1PaisId = new short[1] ;
         LUGARCONVE2_A9LugarNombre = new String[] {""} ;
         LUGARCONVE2_A8LugarId = new short[1] ;
         LUGARCONVE2_A40000LugarFoto_GXI = new String[] {""} ;
         LUGARCONVE2_A10LugarFoto = new String[] {""} ;
         A9LugarNombre = "";
         A40000LugarFoto_GXI = "";
         A10LugarFoto = "";
         AV3LugarNombre = "";
         AV4LugarFoto = "";
         AV5LugarFoto_GXI = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.lugarconversion__default(),
            new Object[][] {
                new Object[] {
               LUGARCONVE2_A42CantEspectaculosLugar, LUGARCONVE2_n42CantEspectaculosLugar, LUGARCONVE2_A4CiudadId, LUGARCONVE2_A1PaisId, LUGARCONVE2_A9LugarNombre, LUGARCONVE2_A8LugarId, LUGARCONVE2_A40000LugarFoto_GXI, LUGARCONVE2_A10LugarFoto
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A42CantEspectaculosLugar ;
      private short A4CiudadId ;
      private short A1PaisId ;
      private short A8LugarId ;
      private short AV2LugarId ;
      private short AV6PaisId ;
      private short AV7CiudadId ;
      private short AV8CantEspectaculosLugar ;
      private int GIGXA0004 ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String A9LugarNombre ;
      private String AV3LugarNombre ;
      private String Gx_emsg ;
      private bool n42CantEspectaculosLugar ;
      private String A40000LugarFoto_GXI ;
      private String AV5LugarFoto_GXI ;
      private String A10LugarFoto ;
      private String AV4LugarFoto ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private short[] LUGARCONVE2_A42CantEspectaculosLugar ;
      private bool[] LUGARCONVE2_n42CantEspectaculosLugar ;
      private short[] LUGARCONVE2_A4CiudadId ;
      private short[] LUGARCONVE2_A1PaisId ;
      private String[] LUGARCONVE2_A9LugarNombre ;
      private short[] LUGARCONVE2_A8LugarId ;
      private String[] LUGARCONVE2_A40000LugarFoto_GXI ;
      private String[] LUGARCONVE2_A10LugarFoto ;
   }

   public class lugarconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmLUGARCONVE2 ;
          prmLUGARCONVE2 = new Object[] {
          } ;
          Object[] prmLUGARCONVE3 ;
          prmLUGARCONVE3 = new Object[] {
          new Object[] {"@AV2LugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3LugarNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@AV4LugarFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@AV5LugarFoto_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@AV6PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7CiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8CantEspectaculosLugar",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("LUGARCONVE2", "SELECT [CantEspectaculosLugar], [CiudadId], [PaisId], [LugarNombre], [LugarId], [LugarFoto_GXI], [LugarFoto] FROM [Lugar] ORDER BY [LugarId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLUGARCONVE2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("LUGARCONVE3", "INSERT INTO [GXA0004]([LugarId], [LugarNombre], [LugarFoto], [LugarFoto_GXI], [PaisId], [CiudadId], [CantEspectaculosLugar]) VALUES(@AV2LugarId, @AV3LugarNombre, @AV4LugarFoto, @AV5LugarFoto_GXI, @AV6PaisId, @AV7CiudadId, @AV8CantEspectaculosLugar)", GxErrorMask.GX_NOMASK,prmLUGARCONVE3)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 100) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(6) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(6)) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterBlob(3, (String)parms[2], false);
                stmt.SetParameterMultimedia(4, (String)parms[3], (String)parms[2], "GXA0004", "LugarFoto");
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
       }
    }

 }

}
