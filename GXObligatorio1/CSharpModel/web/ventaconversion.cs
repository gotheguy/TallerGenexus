/*
               File: VentaConversion
        Description: Conversion for table Venta
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/22/2020 21:5:3.58
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
   public class ventaconversion : GXProcedure
   {
      public ventaconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ventaconversion( IGxContext context )
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
         ventaconversion objventaconversion;
         objventaconversion = new ventaconversion();
         objventaconversion.context.SetSubmitInitialConfig(context);
         objventaconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objventaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ventaconversion)stateInfo).executePrivate();
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0008] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor VENTACONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A40VentaTotal = VENTACONVE2_A40VentaTotal[0];
            A22EspectaculoCiudadId = VENTACONVE2_A22EspectaculoCiudadId[0];
            A19EspectaculoPaisId = VENTACONVE2_A19EspectaculoPaisId[0];
            A27VentaCiudadId = VENTACONVE2_A27VentaCiudadId[0];
            A24VentaPaisId = VENTACONVE2_A24VentaPaisId[0];
            A34EspectaculoId = VENTACONVE2_A34EspectaculoId[0];
            A37VentaId = VENTACONVE2_A37VentaId[0];
            A40000VentaFecha_GXI = VENTACONVE2_A40000VentaFecha_GXI[0];
            A38VentaFecha = VENTACONVE2_A38VentaFecha[0];
            A40005GXC6 = context.localUtil.CToD( A38VentaFecha, 1);
            /*
               INSERT RECORD ON TABLE GXA0008

            */
            AV2VentaId = A37VentaId;
            AV3VentaFecha = A40005GXC6;
            AV4EspectaculoId = A34EspectaculoId;
            AV5VentaPaisId = A24VentaPaisId;
            AV6VentaCiudadId = A27VentaCiudadId;
            AV7EspectaculoPaisId = A19EspectaculoPaisId;
            AV8EspectaculoCiudadId = A22EspectaculoCiudadId;
            AV9VentaTotal = A40VentaTotal;
            /* Using cursor VENTACONVE3 */
            pr_default.execute(1, new Object[] {AV2VentaId, AV3VentaFecha, AV4EspectaculoId, AV5VentaPaisId, AV6VentaCiudadId, AV7EspectaculoPaisId, AV8EspectaculoCiudadId, AV9VentaTotal});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0008") ;
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0008] OFF "
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
         VENTACONVE2_A40VentaTotal = new short[1] ;
         VENTACONVE2_A22EspectaculoCiudadId = new short[1] ;
         VENTACONVE2_A19EspectaculoPaisId = new short[1] ;
         VENTACONVE2_A27VentaCiudadId = new short[1] ;
         VENTACONVE2_A24VentaPaisId = new short[1] ;
         VENTACONVE2_A34EspectaculoId = new short[1] ;
         VENTACONVE2_A37VentaId = new short[1] ;
         VENTACONVE2_A40000VentaFecha_GXI = new String[] {""} ;
         VENTACONVE2_A38VentaFecha = new String[] {""} ;
         A40000VentaFecha_GXI = "";
         A38VentaFecha = "";
         A40005GXC6 = DateTime.MinValue;
         AV3VentaFecha = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ventaconversion__default(),
            new Object[][] {
                new Object[] {
               VENTACONVE2_A40VentaTotal, VENTACONVE2_A22EspectaculoCiudadId, VENTACONVE2_A19EspectaculoPaisId, VENTACONVE2_A27VentaCiudadId, VENTACONVE2_A24VentaPaisId, VENTACONVE2_A34EspectaculoId, VENTACONVE2_A37VentaId, VENTACONVE2_A40000VentaFecha_GXI, VENTACONVE2_A38VentaFecha
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A40VentaTotal ;
      private short A22EspectaculoCiudadId ;
      private short A19EspectaculoPaisId ;
      private short A27VentaCiudadId ;
      private short A24VentaPaisId ;
      private short A34EspectaculoId ;
      private short A37VentaId ;
      private short AV2VentaId ;
      private short AV4EspectaculoId ;
      private short AV5VentaPaisId ;
      private short AV6VentaCiudadId ;
      private short AV7EspectaculoPaisId ;
      private short AV8EspectaculoCiudadId ;
      private short AV9VentaTotal ;
      private int GIGXA0008 ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A40005GXC6 ;
      private DateTime AV3VentaFecha ;
      private String A40000VentaFecha_GXI ;
      private String A38VentaFecha ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private short[] VENTACONVE2_A40VentaTotal ;
      private short[] VENTACONVE2_A22EspectaculoCiudadId ;
      private short[] VENTACONVE2_A19EspectaculoPaisId ;
      private short[] VENTACONVE2_A27VentaCiudadId ;
      private short[] VENTACONVE2_A24VentaPaisId ;
      private short[] VENTACONVE2_A34EspectaculoId ;
      private short[] VENTACONVE2_A37VentaId ;
      private String[] VENTACONVE2_A40000VentaFecha_GXI ;
      private String[] VENTACONVE2_A38VentaFecha ;
   }

   public class ventaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmVENTACONVE2 ;
          prmVENTACONVE2 = new Object[] {
          } ;
          Object[] prmVENTACONVE3 ;
          prmVENTACONVE3 = new Object[] {
          new Object[] {"@AV2VentaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3VentaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV4EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5VentaPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6VentaCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8EspectaculoCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9VentaTotal",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("VENTACONVE2", "SELECT [VentaTotal], [EspectaculoCiudadId], [EspectaculoPaisId], [VentaCiudadId], [VentaPaisId], [EspectaculoId], [VentaId], [VentaFecha_GXI], [VentaFecha] FROM [Venta] ORDER BY [VentaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmVENTACONVE2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("VENTACONVE3", "INSERT INTO [GXA0008]([VentaId], [VentaFecha], [EspectaculoId], [VentaPaisId], [VentaCiudadId], [EspectaculoPaisId], [EspectaculoCiudadId], [VentaTotal]) VALUES(@AV2VentaId, @AV3VentaFecha, @AV4EspectaculoId, @AV5VentaPaisId, @AV6VentaCiudadId, @AV7EspectaculoPaisId, @AV8EspectaculoCiudadId, @AV9VentaTotal)", GxErrorMask.GX_NOMASK,prmVENTACONVE3)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaUri(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(8)) ;
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                return;
       }
    }

 }

}
