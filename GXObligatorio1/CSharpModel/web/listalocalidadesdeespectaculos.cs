/*
               File: ListaLocalidadesDeEspectaculos
        Description: Lista Localidades De Espectaculos
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:22.35
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
   public class listalocalidadesdeespectaculos : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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

      public listalocalidadesdeespectaculos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public listalocalidadesdeespectaculos( IGxContext context )
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
         listalocalidadesdeespectaculos objlistalocalidadesdeespectaculos;
         objlistalocalidadesdeespectaculos = new listalocalidadesdeespectaculos();
         objlistalocalidadesdeespectaculos.context.SetSubmitInitialConfig(context);
         objlistalocalidadesdeespectaculos.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlistalocalidadesdeespectaculos);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listalocalidadesdeespectaculos)stateInfo).executePrivate();
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
            H0G0( false, 67) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(context.localUtil.Format( Gx_date, "99/99/99"), 733, Gx_line+17, 800, Gx_line+32, 1, 0, 0, 1) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 16, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Localidades de espectáculos", 292, Gx_line+17, 617, Gx_line+44, 0, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+67);
            H0G0( false, 46) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Id", 150, Gx_line+17, 162, Gx_line+35, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Nombre", 258, Gx_line+17, 310, Gx_line+35, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Foto", 667, Gx_line+17, 696, Gx_line+35, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Lugar", 550, Gx_line+17, 586, Gx_line+35, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawLine(125, Gx_line+33, 725, Gx_line+33, 1, 0, 0, 0, 0) ;
            getPrinter().GxDrawText("Fecha", 400, Gx_line+17, 441, Gx_line+35, 0+256, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+46);
            AV5GXLvl3 = 0;
            /* Using cursor P000G2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A8LugarId = P000G2_A8LugarId[0];
               A34EspectaculoId = P000G2_A34EspectaculoId[0];
               A40000LugarFoto_GXI = P000G2_A40000LugarFoto_GXI[0];
               A35EspectaculoNombre = P000G2_A35EspectaculoNombre[0];
               A36EspectaculoFecha = P000G2_A36EspectaculoFecha[0];
               A9LugarNombre = P000G2_A9LugarNombre[0];
               A10LugarFoto = P000G2_A10LugarFoto[0];
               A40000LugarFoto_GXI = P000G2_A40000LugarFoto_GXI[0];
               A9LugarNombre = P000G2_A9LugarNombre[0];
               A10LugarFoto = P000G2_A10LugarFoto[0];
               AV5GXLvl3 = 1;
               H0G0( false, 67) ;
               sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : A10LugarFoto);
               getPrinter().GxDrawBitMap(sImgUrl, 650, Gx_line+0, 708, Gx_line+50) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A9LugarNombre, "")), 508, Gx_line+0, 625, Gx_line+50, 1, 0, 0, 1) ;
               getPrinter().GxDrawText(context.localUtil.Format( A36EspectaculoFecha, "99/99/9999"), 367, Gx_line+0, 484, Gx_line+50, 1, 0, 0, 1) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), 208, Gx_line+0, 358, Gx_line+50, 1, 0, 0, 1) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), 117, Gx_line+0, 200, Gx_line+50, 1, 0, 0, 1) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+67);
               H0G0( false, 46) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Precio", 467, Gx_line+17, 509, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawLine(192, Gx_line+33, 659, Gx_line+33, 1, 0, 0, 0, 0) ;
               getPrinter().GxDrawText("Disponibles", 558, Gx_line+17, 634, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Localidad", 325, Gx_line+17, 389, Gx_line+35, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText("Id", 225, Gx_line+17, 237, Gx_line+35, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+46);
               AV6GXLvl6 = 0;
               /* Using cursor P000G3 */
               pr_default.execute(1, new Object[] {A34EspectaculoId});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A14LocalidadPrecio = P000G3_A14LocalidadPrecio[0];
                  A12LocalidadNombre = P000G3_A12LocalidadNombre[0];
                  A11LocalidadId = P000G3_A11LocalidadId[0];
                  A13LocalidadCapacidad = P000G3_A13LocalidadCapacidad[0];
                  A16LocalidadesDisponibles = A13LocalidadCapacidad;
                  AV6GXLvl6 = 1;
                  H0G0( false, 66) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12LocalidadNombre, "")), 283, Gx_line+0, 433, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")), 450, Gx_line+0, 533, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9")), 200, Gx_line+0, 267, Gx_line+50, 1, 0, 0, 1) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")), 558, Gx_line+0, 641, Gx_line+50, 1, 0, 0, 1) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+66);
                  pr_default.readNext(1);
               }
               pr_default.close(1);
               if ( AV6GXLvl6 == 0 )
               {
                  H0G0( false, 32) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("No se encontraron localidades", 283, Gx_line+0, 476, Gx_line+18, 0+256, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+32);
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            if ( AV5GXLvl3 == 0 )
            {
               H0G0( false, 31) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("No se encontraron espectáculos", 117, Gx_line+0, 320, Gx_line+18, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+31);
            }
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H0G0( true, 0) ;
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

      protected void H0G0( bool bFoot ,
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
         P000G2_A8LugarId = new short[1] ;
         P000G2_A34EspectaculoId = new short[1] ;
         P000G2_A40000LugarFoto_GXI = new String[] {""} ;
         P000G2_A35EspectaculoNombre = new String[] {""} ;
         P000G2_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         P000G2_A9LugarNombre = new String[] {""} ;
         P000G2_A10LugarFoto = new String[] {""} ;
         A40000LugarFoto_GXI = "";
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A9LugarNombre = "";
         A10LugarFoto = "";
         sImgUrl = "";
         P000G3_A34EspectaculoId = new short[1] ;
         P000G3_A14LocalidadPrecio = new decimal[1] ;
         P000G3_A12LocalidadNombre = new String[] {""} ;
         P000G3_A11LocalidadId = new short[1] ;
         P000G3_A13LocalidadCapacidad = new int[1] ;
         A12LocalidadNombre = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.listalocalidadesdeespectaculos__default(),
            new Object[][] {
                new Object[] {
               P000G2_A8LugarId, P000G2_A34EspectaculoId, P000G2_A40000LugarFoto_GXI, P000G2_A35EspectaculoNombre, P000G2_A36EspectaculoFecha, P000G2_A9LugarNombre, P000G2_A10LugarFoto
               }
               , new Object[] {
               P000G3_A34EspectaculoId, P000G3_A14LocalidadPrecio, P000G3_A12LocalidadNombre, P000G3_A11LocalidadId, P000G3_A13LocalidadCapacidad
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
      private short AV5GXLvl3 ;
      private short A8LugarId ;
      private short A34EspectaculoId ;
      private short AV6GXLvl6 ;
      private short A11LocalidadId ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private int A13LocalidadCapacidad ;
      private int A16LocalidadesDisponibles ;
      private decimal A14LocalidadPrecio ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A35EspectaculoNombre ;
      private String A9LugarNombre ;
      private String sImgUrl ;
      private String A12LocalidadNombre ;
      private DateTime Gx_date ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private String A40000LugarFoto_GXI ;
      private String A10LugarFoto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000G2_A8LugarId ;
      private short[] P000G2_A34EspectaculoId ;
      private String[] P000G2_A40000LugarFoto_GXI ;
      private String[] P000G2_A35EspectaculoNombre ;
      private DateTime[] P000G2_A36EspectaculoFecha ;
      private String[] P000G2_A9LugarNombre ;
      private String[] P000G2_A10LugarFoto ;
      private short[] P000G3_A34EspectaculoId ;
      private decimal[] P000G3_A14LocalidadPrecio ;
      private String[] P000G3_A12LocalidadNombre ;
      private short[] P000G3_A11LocalidadId ;
      private int[] P000G3_A13LocalidadCapacidad ;
   }

   public class listalocalidadesdeespectaculos__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000G2 ;
          prmP000G2 = new Object[] {
          } ;
          Object[] prmP000G3 ;
          prmP000G3 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000G2", "SELECT T1.[LugarId], T1.[EspectaculoId], T2.[LugarFoto_GXI], T1.[EspectaculoNombre], T1.[EspectaculoFecha], T2.[LugarNombre], T2.[LugarFoto] FROM ([Espectaculo] T1 INNER JOIN [Lugar] T2 ON T2.[LugarId] = T1.[LugarId]) ORDER BY T1.[EspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G2,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("P000G3", "SELECT [EspectaculoId], [LocalidadPrecio], [LocalidadNombre], [LocalidadId], [LocalidadCapacidad] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId ORDER BY [EspectaculoId], [LocalidadId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G3,100, GxCacheFrequency.OFF ,false,false )
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
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(3)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
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
