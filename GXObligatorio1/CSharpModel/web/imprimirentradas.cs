/*
               File: ImprimirEntradas
        Description: Imprimir Entradas
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:22.14
       Program type: HTTP procedure
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class imprimirentradas : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("Carmine");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            if ( ! entryPointCalled )
            {
               A37VentaId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public imprimirentradas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public imprimirentradas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_VentaId )
      {
         this.A37VentaId = aP0_VentaId;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_VentaId )
      {
         imprimirentradas objimprimirentradas;
         objimprimirentradas = new imprimirentradas();
         objimprimirentradas.A37VentaId = aP0_VentaId;
         objimprimirentradas.context.SetSubmitInitialConfig(context);
         objimprimirentradas.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objimprimirentradas);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((imprimirentradas)stateInfo).executePrivate();
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
         M_top = 0;
         M_bot = 6;
         P_lines = (int)(66-M_bot);
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15;
         PrtOffset = 0;
         gxXPage = 100;
         gxYPage = 100;
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 16834, 11909, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6));
            Gx_line = (int)(P_lines+1);
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            H0E0( false, 66) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 16, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Detalle de tu compra", 292, Gx_line+17, 499, Gx_line+44, 0+256, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(context.localUtil.Format( Gx_date, "99/99/99"), 733, Gx_line+17, 800, Gx_line+32, 1, 0, 0, 1) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+66);
            H0E0( false, 47) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Fecha", 42, Gx_line+17, 74, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Espectáculo", 167, Gx_line+17, 229, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Cantidad", 750, Gx_line+17, 795, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Sector", 567, Gx_line+17, 600, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Localidad", 433, Gx_line+17, 482, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Total", 675, Gx_line+17, 701, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawLine(17, Gx_line+33, 817, Gx_line+33, 1, 0, 0, 0, 0) ;
            getPrinter().GxDrawText("Lugar", 317, Gx_line+17, 346, Gx_line+31, 0+256, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+47);
            /* Using cursor P000E2 */
            pr_default.execute(0, new Object[] {A37VentaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A8LugarId = P000E2_A8LugarId[0];
               A11LocalidadId = P000E2_A11LocalidadId[0];
               A17SectorId = P000E2_A17SectorId[0];
               A34EspectaculoId = P000E2_A34EspectaculoId[0];
               A9LugarNombre = P000E2_A9LugarNombre[0];
               A18SectorNombre = P000E2_A18SectorNombre[0];
               A12LocalidadNombre = P000E2_A12LocalidadNombre[0];
               A35EspectaculoNombre = P000E2_A35EspectaculoNombre[0];
               A36EspectaculoFecha = P000E2_A36EspectaculoFecha[0];
               A14LocalidadPrecio = P000E2_A14LocalidadPrecio[0];
               A43VentaCantidadEntradas = P000E2_A43VentaCantidadEntradas[0];
               A8LugarId = P000E2_A8LugarId[0];
               A35EspectaculoNombre = P000E2_A35EspectaculoNombre[0];
               A36EspectaculoFecha = P000E2_A36EspectaculoFecha[0];
               A9LugarNombre = P000E2_A9LugarNombre[0];
               A12LocalidadNombre = P000E2_A12LocalidadNombre[0];
               A14LocalidadPrecio = P000E2_A14LocalidadPrecio[0];
               A18SectorNombre = P000E2_A18SectorNombre[0];
               A40VentaTotal = (decimal)(A14LocalidadPrecio*A43VentaCantidadEntradas);
               /* Using cursor P000E3 */
               pr_default.execute(1, new Object[] {A34EspectaculoId, A37VentaId});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  H0E0( false, 100) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A36EspectaculoFecha, "99/99/9999"), 17, Gx_line+0, 117, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), 133, Gx_line+0, 266, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12LocalidadNombre, "")), 400, Gx_line+0, 517, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A18SectorNombre, "")), 533, Gx_line+0, 641, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A40VentaTotal, "ZZZZZ9.99")), 658, Gx_line+0, 725, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A43VentaCantidadEntradas), "ZZZ9")), 742, Gx_line+0, 800, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A9LugarNombre, "")), 283, Gx_line+0, 383, Gx_line+50, 1, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+100);
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(1);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H0E0( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      protected void H0E0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines;
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0;
               Gx_line = 0;
               Gx_page = (int)(Gx_page+1);
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight));
               /* Print headers */
               getPrinter().GxStartPage() ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0;
               Gx_line = (int)(Gx_line+1);
            }
            ToSkip = (int)(ToSkip-1);
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         base.cleanup();
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
         GXKey = "";
         gxfirstwebparm = "";
         Gx_date = DateTime.MinValue;
         scmdbuf = "";
         P000E2_A8LugarId = new short[1] ;
         P000E2_A11LocalidadId = new short[1] ;
         P000E2_A17SectorId = new short[1] ;
         P000E2_A37VentaId = new short[1] ;
         P000E2_A34EspectaculoId = new short[1] ;
         P000E2_A9LugarNombre = new String[] {""} ;
         P000E2_A18SectorNombre = new String[] {""} ;
         P000E2_A12LocalidadNombre = new String[] {""} ;
         P000E2_A35EspectaculoNombre = new String[] {""} ;
         P000E2_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         P000E2_A14LocalidadPrecio = new decimal[1] ;
         P000E2_A43VentaCantidadEntradas = new short[1] ;
         A9LugarNombre = "";
         A18SectorNombre = "";
         A12LocalidadNombre = "";
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         P000E3_A34EspectaculoId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.imprimirentradas__default(),
            new Object[][] {
                new Object[] {
               P000E2_A8LugarId, P000E2_A11LocalidadId, P000E2_A17SectorId, P000E2_A37VentaId, P000E2_A34EspectaculoId, P000E2_A9LugarNombre, P000E2_A18SectorNombre, P000E2_A12LocalidadNombre, P000E2_A35EspectaculoNombre, P000E2_A36EspectaculoFecha,
               P000E2_A14LocalidadPrecio, P000E2_A43VentaCantidadEntradas
               }
               , new Object[] {
               P000E3_A34EspectaculoId
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_line = 0;
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short A37VentaId ;
      private short GxWebError ;
      private short A8LugarId ;
      private short A11LocalidadId ;
      private short A17SectorId ;
      private short A34EspectaculoId ;
      private short A43VentaCantidadEntradas ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private decimal A14LocalidadPrecio ;
      private decimal A40VentaTotal ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A9LugarNombre ;
      private String A18SectorNombre ;
      private String A12LocalidadNombre ;
      private String A35EspectaculoNombre ;
      private DateTime Gx_date ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000E2_A8LugarId ;
      private short[] P000E2_A11LocalidadId ;
      private short[] P000E2_A17SectorId ;
      private short[] P000E2_A37VentaId ;
      private short[] P000E2_A34EspectaculoId ;
      private String[] P000E2_A9LugarNombre ;
      private String[] P000E2_A18SectorNombre ;
      private String[] P000E2_A12LocalidadNombre ;
      private String[] P000E2_A35EspectaculoNombre ;
      private DateTime[] P000E2_A36EspectaculoFecha ;
      private decimal[] P000E2_A14LocalidadPrecio ;
      private short[] P000E2_A43VentaCantidadEntradas ;
      private short[] P000E3_A34EspectaculoId ;
   }

   public class imprimirentradas__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000E2 ;
          prmP000E2 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000E3 ;
          prmP000E3 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000E2", "SELECT T2.[LugarId], T1.[LocalidadId], T1.[SectorId], T1.[VentaId], T1.[EspectaculoId], T3.[LugarNombre], T5.[SectorNombre], T4.[LocalidadNombre], T2.[EspectaculoNombre], T2.[EspectaculoFecha], T4.[LocalidadPrecio], T1.[VentaCantidadEntradas] FROM (((([Venta] T1 INNER JOIN [Espectaculo] T2 ON T2.[EspectaculoId] = T1.[EspectaculoId]) INNER JOIN [Lugar] T3 ON T3.[LugarId] = T2.[LugarId]) INNER JOIN [EspectaculoLocalidad] T4 ON T4.[EspectaculoId] = T1.[EspectaculoId] AND T4.[LocalidadId] = T1.[LocalidadId]) INNER JOIN [EspectaculoLocalidadSector] T5 ON T5.[EspectaculoId] = T1.[EspectaculoId] AND T5.[LocalidadId] = T1.[LocalidadId] AND T5.[SectorId] = T1.[SectorId]) WHERE T1.[VentaId] = @VentaId ORDER BY T1.[VentaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000E2,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("P000E3", "SELECT [EspectaculoId] FROM [Espectaculo] WHERE ([EspectaculoId] = @EspectaculoId) AND (@VentaId = @VentaId) ORDER BY [EspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000E3,1, GxCacheFrequency.OFF ,false,true )
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
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 100) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 100) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 100) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
