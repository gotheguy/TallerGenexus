/*
               File: Lugar_DataProvider
        Description: Lugar_Data Provider
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:22.51
       Program type: Main program
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
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
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class alugar_dataprovider : GXProcedure
   {
      public alugar_dataprovider( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public alugar_dataprovider( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBCCollection<SdtLugar> aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GXBCCollection<SdtLugar>( context, "Lugar", "GXObligatorio1") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public GXBCCollection<SdtLugar> executeUdp( )
      {
         execute(out aP0_Gxm2rootcol);
         return Gxm2rootcol ;
      }

      public void executeSubmit( out GXBCCollection<SdtLugar> aP0_Gxm2rootcol )
      {
         alugar_dataprovider objalugar_dataprovider;
         objalugar_dataprovider = new alugar_dataprovider();
         objalugar_dataprovider.Gxm2rootcol = new GXBCCollection<SdtLugar>( context, "Lugar", "GXObligatorio1") ;
         objalugar_dataprovider.context.SetSubmitInitialConfig(context);
         objalugar_dataprovider.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objalugar_dataprovider);
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((alugar_dataprovider)stateInfo).executePrivate();
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
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 1;
         Gxm1lugar.gxTpr_Lugarnombre = "Estadio Centenario";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "fe908e58-606c-4016-a504-c91950445765", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 1;
         Gxm1lugar.gxTpr_Ciudadid = 1;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 2;
         Gxm1lugar.gxTpr_Lugarnombre = "Sodre";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "2e093598-e052-4983-bf14-1156d8cac273", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 1;
         Gxm1lugar.gxTpr_Ciudadid = 1;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 3;
         Gxm1lugar.gxTpr_Lugarnombre = "Teatro Solís";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "932e972d-af15-4a46-9847-f77700f32625", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 1;
         Gxm1lugar.gxTpr_Ciudadid = 1;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 4;
         Gxm1lugar.gxTpr_Lugarnombre = "Teatro São Pedro";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "31e0faaf-a8ea-429d-ad08-85675ea4e920", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 2;
         Gxm1lugar.gxTpr_Ciudadid = 4;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 5;
         Gxm1lugar.gxTpr_Lugarnombre = "Luna Park";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "870a60be-f36f-4f28-bccb-d0d38e6bf4ac", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 3;
         Gxm1lugar.gxTpr_Ciudadid = 9;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 6;
         Gxm1lugar.gxTpr_Lugarnombre = "Teatro Colon";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "219eb53e-4e2e-4207-9591-2a846652d71f", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 3;
         Gxm1lugar.gxTpr_Ciudadid = 9;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 7;
         Gxm1lugar.gxTpr_Lugarnombre = "Auditorio Nacional";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "b9e3aeaf-6103-40a7-a6db-044d791df861", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 4;
         Gxm1lugar.gxTpr_Ciudadid = 12;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 8;
         Gxm1lugar.gxTpr_Lugarnombre = "Estadio Nacional";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "61066ff5-672d-4ca2-a93f-9474c45ea0d0", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 5;
         Gxm1lugar.gxTpr_Ciudadid = 16;
         Gxm1lugar = new SdtLugar(context);
         Gxm2rootcol.Add(Gxm1lugar, 0);
         Gxm1lugar.gxTpr_Lugarid = 9;
         Gxm1lugar.gxTpr_Lugarnombre = "Municipal de Santiago";
         Gxm1lugar.gxTpr_Lugarfoto = context.convertURL( (String)(context.GetImagePath( "b0900d39-63bd-422f-8446-3474de67f6c7", "", context.GetTheme( ))));
         Gxm1lugar.gxTpr_Paisid = 5;
         Gxm1lugar.gxTpr_Ciudadid = 16;
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
         Gxm1lugar = new SdtLugar(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private GXBCCollection<SdtLugar> aP0_Gxm2rootcol ;
      private GXBCCollection<SdtLugar> Gxm2rootcol ;
      private SdtLugar Gxm1lugar ;
   }

}
