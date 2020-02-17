/*
               File: EspectaculoLocalidadConversion
        Description: Conversion for table EspectaculoLocalidad
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 20:50:57.30
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
   public class espectaculolocalidadconversion : GXProcedure
   {
      public espectaculolocalidadconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public espectaculolocalidadconversion( IGxContext context )
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
         espectaculolocalidadconversion objespectaculolocalidadconversion;
         objespectaculolocalidadconversion = new espectaculolocalidadconversion();
         objespectaculolocalidadconversion.context.SetSubmitInitialConfig(context);
         objespectaculolocalidadconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objespectaculolocalidadconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((espectaculolocalidadconversion)stateInfo).executePrivate();
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
         /* Using cursor ESPECTACUL2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A16LocalidadesDisponibles = ESPECTACUL2_A16LocalidadesDisponibles[0];
            A15LocalidadesVendidas = ESPECTACUL2_A15LocalidadesVendidas[0];
            A14LocalidadPrecio = ESPECTACUL2_A14LocalidadPrecio[0];
            A13LocalidadCapacidad = ESPECTACUL2_A13LocalidadCapacidad[0];
            A12LocalidadNombre = ESPECTACUL2_A12LocalidadNombre[0];
            A11LocalidadId = ESPECTACUL2_A11LocalidadId[0];
            A34EspectaculoId = ESPECTACUL2_A34EspectaculoId[0];
            A16LocalidadesDisponibles = ESPECTACUL2_A16LocalidadesDisponibles[0];
            A15LocalidadesVendidas = ESPECTACUL2_A15LocalidadesVendidas[0];
            A14LocalidadPrecio = ESPECTACUL2_A14LocalidadPrecio[0];
            A13LocalidadCapacidad = ESPECTACUL2_A13LocalidadCapacidad[0];
            A12LocalidadNombre = ESPECTACUL2_A12LocalidadNombre[0];
            /*
               INSERT RECORD ON TABLE GXA0012

            */
            AV2EspectaculoId = A34EspectaculoId;
            AV3LocalidadId = A11LocalidadId;
            if ( ESPECTACUL2_n12LocalidadNombre[0] )
            {
               AV4LocalidadNombre = " ";
            }
            else
            {
               AV4LocalidadNombre = A12LocalidadNombre;
            }
            if ( ESPECTACUL2_n13LocalidadCapacidad[0] )
            {
               AV5LocalidadCapacidad = 0;
            }
            else
            {
               AV5LocalidadCapacidad = A13LocalidadCapacidad;
            }
            if ( ESPECTACUL2_n14LocalidadPrecio[0] )
            {
               AV6LocalidadPrecio = 0;
            }
            else
            {
               AV6LocalidadPrecio = A14LocalidadPrecio;
            }
            if ( ESPECTACUL2_n15LocalidadesVendidas[0] )
            {
               AV7LocalidadesVendidas = 0;
            }
            else
            {
               AV7LocalidadesVendidas = A15LocalidadesVendidas;
            }
            if ( ESPECTACUL2_n16LocalidadesDisponibles[0] )
            {
               AV8LocalidadesDisponibles = 0;
            }
            else
            {
               AV8LocalidadesDisponibles = A16LocalidadesDisponibles;
            }
            /* Using cursor ESPECTACUL3 */
            pr_default.execute(1, new Object[] {AV2EspectaculoId, AV3LocalidadId, AV4LocalidadNombre, AV5LocalidadCapacidad, AV6LocalidadPrecio, AV7LocalidadesVendidas, AV8LocalidadesDisponibles});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0012") ;
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
         scmdbuf = "";
         ESPECTACUL2_A16LocalidadesDisponibles = new int[1] ;
         ESPECTACUL2_A15LocalidadesVendidas = new int[1] ;
         ESPECTACUL2_A14LocalidadPrecio = new decimal[1] ;
         ESPECTACUL2_A13LocalidadCapacidad = new int[1] ;
         ESPECTACUL2_A12LocalidadNombre = new String[] {""} ;
         ESPECTACUL2_A11LocalidadId = new short[1] ;
         ESPECTACUL2_A34EspectaculoId = new short[1] ;
         A12LocalidadNombre = "";
         ESPECTACUL2_n12LocalidadNombre = new bool[] {false} ;
         AV4LocalidadNombre = "";
         ESPECTACUL2_n13LocalidadCapacidad = new bool[] {false} ;
         ESPECTACUL2_n14LocalidadPrecio = new bool[] {false} ;
         ESPECTACUL2_n15LocalidadesVendidas = new bool[] {false} ;
         ESPECTACUL2_n16LocalidadesDisponibles = new bool[] {false} ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.espectaculolocalidadconversion__default(),
            new Object[][] {
                new Object[] {
               ESPECTACUL2_A16LocalidadesDisponibles, ESPECTACUL2_A15LocalidadesVendidas, ESPECTACUL2_A14LocalidadPrecio, ESPECTACUL2_A13LocalidadCapacidad, ESPECTACUL2_A12LocalidadNombre, ESPECTACUL2_A11LocalidadId, ESPECTACUL2_A34EspectaculoId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A11LocalidadId ;
      private short A34EspectaculoId ;
      private short AV2EspectaculoId ;
      private short AV3LocalidadId ;
      private int A16LocalidadesDisponibles ;
      private int A15LocalidadesVendidas ;
      private int A13LocalidadCapacidad ;
      private int GIGXA0012 ;
      private int AV5LocalidadCapacidad ;
      private int AV7LocalidadesVendidas ;
      private int AV8LocalidadesDisponibles ;
      private decimal A14LocalidadPrecio ;
      private decimal AV6LocalidadPrecio ;
      private String scmdbuf ;
      private String A12LocalidadNombre ;
      private String AV4LocalidadNombre ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] ESPECTACUL2_A16LocalidadesDisponibles ;
      private int[] ESPECTACUL2_A15LocalidadesVendidas ;
      private decimal[] ESPECTACUL2_A14LocalidadPrecio ;
      private int[] ESPECTACUL2_A13LocalidadCapacidad ;
      private String[] ESPECTACUL2_A12LocalidadNombre ;
      private short[] ESPECTACUL2_A11LocalidadId ;
      private short[] ESPECTACUL2_A34EspectaculoId ;
      private bool[] ESPECTACUL2_n12LocalidadNombre ;
      private bool[] ESPECTACUL2_n13LocalidadCapacidad ;
      private bool[] ESPECTACUL2_n14LocalidadPrecio ;
      private bool[] ESPECTACUL2_n15LocalidadesVendidas ;
      private bool[] ESPECTACUL2_n16LocalidadesDisponibles ;
   }

   public class espectaculolocalidadconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmESPECTACUL2 ;
          prmESPECTACUL2 = new Object[] {
          } ;
          Object[] prmESPECTACUL3 ;
          prmESPECTACUL3 = new Object[] {
          new Object[] {"@AV2EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4LocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@AV5LocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@AV6LocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV7LocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@AV8LocalidadesDisponibles",SqlDbType.Int,5,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("ESPECTACUL2", "SELECT T2.[LocalidadesDisponibles], T2.[LocalidadesVendidas], T2.[LocalidadPrecio], T2.[LocalidadCapacidad], T2.[LocalidadNombre], T1.[LocalidadId], T1.[EspectaculoId] FROM ([EspectaculoLocalidad] T1 INNER JOIN [Localidad] T2 ON T2.[LocalidadId] = T1.[LocalidadId]) ORDER BY T1.[EspectaculoId], T1.[LocalidadId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmESPECTACUL2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("ESPECTACUL3", "INSERT INTO [GXA0012]([EspectaculoId], [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles]) VALUES(@AV2EspectaculoId, @AV3LocalidadId, @AV4LocalidadNombre, @AV5LocalidadCapacidad, @AV6LocalidadPrecio, @AV7LocalidadesVendidas, @AV8LocalidadesDisponibles)", GxErrorMask.GX_NOMASK,prmESPECTACUL3)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
       }
    }

 }

}
