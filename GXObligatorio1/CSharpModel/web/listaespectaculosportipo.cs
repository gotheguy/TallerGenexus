/*
               File: ListaEspectaculosPorTipo
        Description: Lista Espectaculos Por Tipo
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:21.95
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
   public class listaespectaculosportipo : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public listaespectaculosportipo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public listaespectaculosportipo( IGxContext context )
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
         listaespectaculosportipo objlistaespectaculosportipo;
         objlistaespectaculosportipo = new listaespectaculosportipo();
         objlistaespectaculosportipo.context.SetSubmitInitialConfig(context);
         objlistaespectaculosportipo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlistaespectaculosportipo);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listaespectaculosportipo)stateInfo).executePrivate();
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
            H0F0( false, 66) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 16, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Espectáculos por tipo", 292, Gx_line+17, 542, Gx_line+44, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(context.localUtil.Format( Gx_date, "99/99/99"), 733, Gx_line+17, 800, Gx_line+32, 1, 0, 0, 1) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+66);
            /* Using cursor P000F2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A6TipoEspectaculoId = P000F2_A6TipoEspectaculoId[0];
               A7TipoEspectaculoNombre = P000F2_A7TipoEspectaculoNombre[0];
               H0F0( false, 49) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A7TipoEspectaculoNombre, "")), 33, Gx_line+17, 183, Gx_line+37, 0, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+49);
               H0F0( false, 49) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha", 383, Gx_line+17, 424, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawLine(92, Gx_line+33, 717, Gx_line+33, 1, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Lugar", 517, Gx_line+17, 553, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Foto", 633, Gx_line+17, 662, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Nombre", 225, Gx_line+17, 277, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Id", 125, Gx_line+17, 137, Gx_line+35, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+49);
               AV6GXLvl5 = 0;
               /* Using cursor P000F3 */
               pr_default.execute(1, new Object[] {A6TipoEspectaculoId});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A8LugarId = P000F3_A8LugarId[0];
                  A40000LugarFoto_GXI = P000F3_A40000LugarFoto_GXI[0];
                  A9LugarNombre = P000F3_A9LugarNombre[0];
                  A36EspectaculoFecha = P000F3_A36EspectaculoFecha[0];
                  A35EspectaculoNombre = P000F3_A35EspectaculoNombre[0];
                  A34EspectaculoId = P000F3_A34EspectaculoId[0];
                  A10LugarFoto = P000F3_A10LugarFoto[0];
                  A40000LugarFoto_GXI = P000F3_A40000LugarFoto_GXI[0];
                  A9LugarNombre = P000F3_A9LugarNombre[0];
                  A10LugarFoto = P000F3_A10LugarFoto[0];
                  AV6GXLvl5 = 1;
                  H0F0( false, 66) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), 92, Gx_line+0, 175, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), 183, Gx_line+0, 333, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A36EspectaculoFecha, "99/99/9999"), 342, Gx_line+0, 459, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A9LugarNombre, "")), 483, Gx_line+0, 600, Gx_line+50, 1, 0, 0, 1) ;
                  sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : A10LugarFoto);
                  getPrinter().GxDrawBitMap(sImgUrl, 625, Gx_line+0, 683, Gx_line+50) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+66);
                  pr_default.readNext(1);
               }
               pr_default.close(1);
               if ( AV6GXLvl5 == 0 )
               {
                  H0F0( false, 31) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("No se encontraron resultados", 100, Gx_line+0, 284, Gx_line+18, 0+256, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+31);
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H0F0( true, 0) ;
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

      protected void H0F0( bool bFoot ,
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
         P000F2_A6TipoEspectaculoId = new short[1] ;
         P000F2_A7TipoEspectaculoNombre = new String[] {""} ;
         A7TipoEspectaculoNombre = "";
         P000F3_A8LugarId = new short[1] ;
         P000F3_A6TipoEspectaculoId = new short[1] ;
         P000F3_A40000LugarFoto_GXI = new String[] {""} ;
         P000F3_A9LugarNombre = new String[] {""} ;
         P000F3_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         P000F3_A35EspectaculoNombre = new String[] {""} ;
         P000F3_A34EspectaculoId = new short[1] ;
         P000F3_A10LugarFoto = new String[] {""} ;
         A40000LugarFoto_GXI = "";
         A9LugarNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A35EspectaculoNombre = "";
         A10LugarFoto = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.listaespectaculosportipo__default(),
            new Object[][] {
                new Object[] {
               P000F2_A6TipoEspectaculoId, P000F2_A7TipoEspectaculoNombre
               }
               , new Object[] {
               P000F3_A8LugarId, P000F3_A6TipoEspectaculoId, P000F3_A40000LugarFoto_GXI, P000F3_A9LugarNombre, P000F3_A36EspectaculoFecha, P000F3_A35EspectaculoNombre, P000F3_A34EspectaculoId, P000F3_A10LugarFoto
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
      private short GxWebError ;
      private short A6TipoEspectaculoId ;
      private short AV6GXLvl5 ;
      private short A8LugarId ;
      private short A34EspectaculoId ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A7TipoEspectaculoNombre ;
      private String A9LugarNombre ;
      private String A35EspectaculoNombre ;
      private String sImgUrl ;
      private DateTime Gx_date ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private String A40000LugarFoto_GXI ;
      private String A10LugarFoto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000F2_A6TipoEspectaculoId ;
      private String[] P000F2_A7TipoEspectaculoNombre ;
      private short[] P000F3_A8LugarId ;
      private short[] P000F3_A6TipoEspectaculoId ;
      private String[] P000F3_A40000LugarFoto_GXI ;
      private String[] P000F3_A9LugarNombre ;
      private DateTime[] P000F3_A36EspectaculoFecha ;
      private String[] P000F3_A35EspectaculoNombre ;
      private short[] P000F3_A34EspectaculoId ;
      private String[] P000F3_A10LugarFoto ;
   }

   public class listaespectaculosportipo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000F2 ;
          prmP000F2 = new Object[] {
          } ;
          Object[] prmP000F3 ;
          prmP000F3 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000F2", "SELECT [TipoEspectaculoId], [TipoEspectaculoNombre] FROM [TipoEspectaculo] ORDER BY [TipoEspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P000F3", "SELECT T1.[LugarId], T1.[TipoEspectaculoId], T2.[LugarFoto_GXI], T2.[LugarNombre], T1.[EspectaculoFecha], T1.[EspectaculoNombre], T1.[EspectaculoId], T2.[LugarFoto] FROM ([Espectaculo] T1 INNER JOIN [Lugar] T2 ON T2.[LugarId] = T1.[LugarId]) WHERE T1.[TipoEspectaculoId] = @TipoEspectaculoId ORDER BY T1.[EspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F3,100, GxCacheFrequency.OFF ,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(3)) ;
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
                return;
       }
    }

 }

}
