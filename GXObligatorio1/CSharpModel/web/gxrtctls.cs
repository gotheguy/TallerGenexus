/*
               File: GXRTCtls
        Description: Run time reorganization controls
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/24/2020 15:45:26.33
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
   public class gxrtctls : GXProcedure
   {
      public gxrtctls( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gxrtctls( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_Status )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
      }

      public short executeUdp( )
      {
         execute(out aP0_Status);
         return AV2Status ;
      }

      public void executeSubmit( out short aP0_Status )
      {
         gxrtctls objgxrtctls;
         objgxrtctls = new gxrtctls();
         objgxrtctls.AV2Status = 0 ;
         objgxrtctls.context.SetSubmitInitialConfig(context);
         objgxrtctls.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgxrtctls);
         aP0_Status=this.AV2Status;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gxrtctls)stateInfo).executePrivate();
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
         AV2Status = 0;
         Console.WriteLine( "=== Starting run time controls" );
         Console.WriteLine( "Searching EspectaculoLocalidadSector for duplicate values on new unique index on SectorNombre" );
         /* Using cursor LTCTLS2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRKR012 = false;
            A18SectorNombre = LTCTLS2_A18SectorNombre[0];
            A34EspectaculoId = LTCTLS2_A34EspectaculoId[0];
            A11LocalidadId = LTCTLS2_A11LocalidadId[0];
            A17SectorId = LTCTLS2_A17SectorId[0];
            AV3Count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(LTCTLS2_A18SectorNombre[0], A18SectorNombre) == 0 ) )
            {
               BRKR012 = false;
               A34EspectaculoId = LTCTLS2_A34EspectaculoId[0];
               A11LocalidadId = LTCTLS2_A11LocalidadId[0];
               A17SectorId = LTCTLS2_A17SectorId[0];
               if ( AV3Count != 0 )
               {
                  AV2Status = 1;
                  Console.WriteLine( "Fail: Duplicates found. The first non unique value found follows." );
                  Console.WriteLine( "SectorNombre: "+StringUtil.RTrim( A18SectorNombre) );
                  Console.WriteLine( "Recovery: See recovery information for reorganization message rgz0020." );
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               AV3Count = (int)(AV3Count+1);
               BRKR012 = true;
               pr_default.readNext(0);
            }
            if ( AV2Status != 0 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRKR012 )
            {
               BRKR012 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
         if ( AV2Status == 0 )
         {
            Console.WriteLine( "Success: No duplicates found for SectorNombre" );
         }
         Console.WriteLine( "====================" );
         Console.WriteLine( "=== End of run time controls" );
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
         LTCTLS2_A18SectorNombre = new String[] {""} ;
         LTCTLS2_A34EspectaculoId = new short[1] ;
         LTCTLS2_A11LocalidadId = new short[1] ;
         LTCTLS2_A17SectorId = new short[1] ;
         A18SectorNombre = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gxrtctls__default(),
            new Object[][] {
                new Object[] {
               LTCTLS2_A18SectorNombre, LTCTLS2_A34EspectaculoId, LTCTLS2_A11LocalidadId, LTCTLS2_A17SectorId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV2Status ;
      private short A34EspectaculoId ;
      private short A11LocalidadId ;
      private short A17SectorId ;
      private int AV3Count ;
      private String scmdbuf ;
      private String A18SectorNombre ;
      private bool BRKR012 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] LTCTLS2_A18SectorNombre ;
      private short[] LTCTLS2_A34EspectaculoId ;
      private short[] LTCTLS2_A11LocalidadId ;
      private short[] LTCTLS2_A17SectorId ;
      private short aP0_Status ;
   }

   public class gxrtctls__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmLTCTLS2 ;
          prmLTCTLS2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("LTCTLS2", "SELECT [SectorNombre], [EspectaculoId], [LocalidadId], [SectorId] FROM [EspectaculoLocalidadSector] ORDER BY [SectorNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCTLS2,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
