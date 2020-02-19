/*
               File: Pais_DataProvider
        Description: Pais_Data Provider
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/18/2020 22:53:8.83
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
   public class apais_dataprovider : GXProcedure
   {
      public apais_dataprovider( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public apais_dataprovider( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBCCollection<SdtPais> aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GXBCCollection<SdtPais>( context, "Pais", "GXObligatorio1") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public GXBCCollection<SdtPais> executeUdp( )
      {
         execute(out aP0_Gxm2rootcol);
         return Gxm2rootcol ;
      }

      public void executeSubmit( out GXBCCollection<SdtPais> aP0_Gxm2rootcol )
      {
         apais_dataprovider objapais_dataprovider;
         objapais_dataprovider = new apais_dataprovider();
         objapais_dataprovider.Gxm2rootcol = new GXBCCollection<SdtPais>( context, "Pais", "GXObligatorio1") ;
         objapais_dataprovider.context.SetSubmitInitialConfig(context);
         objapais_dataprovider.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objapais_dataprovider);
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((apais_dataprovider)stateInfo).executePrivate();
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
         Gxm1pais = new SdtPais(context);
         Gxm2rootcol.Add(Gxm1pais, 0);
         Gxm1pais.gxTpr_Paisid = 1;
         Gxm1pais.gxTpr_Paisnombre = "Uruguay";
         Gxm1pais.gxTpr_Paisbandera = context.convertURL( (String)(context.GetImagePath( "fb5e7709-5fa0-433b-bf93-6fa156c66b28", "", context.GetTheme( ))));
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 1;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Montevideo";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 2;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Maldonado";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 3;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Canelones";
         Gxm1pais = new SdtPais(context);
         Gxm2rootcol.Add(Gxm1pais, 0);
         Gxm1pais.gxTpr_Paisid = 2;
         Gxm1pais.gxTpr_Paisnombre = "Brasil";
         Gxm1pais.gxTpr_Paisbandera = context.convertURL( (String)(context.GetImagePath( "29cd09e4-7f1c-4f97-b9eb-47f33e756316", "", context.GetTheme( ))));
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 4;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Porto Alegre";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 5;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Río de Janeiro";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 6;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "São Paulo";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 7;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Manaos";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 8;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Curitiba";
         Gxm1pais = new SdtPais(context);
         Gxm2rootcol.Add(Gxm1pais, 0);
         Gxm1pais.gxTpr_Paisid = 3;
         Gxm1pais.gxTpr_Paisnombre = "Argentina";
         Gxm1pais.gxTpr_Paisbandera = context.convertURL( (String)(context.GetImagePath( "ad5d6304-d8ba-469d-a73f-2fd0ca5efb86", "", context.GetTheme( ))));
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 9;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Buenos Aires";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 10;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Rosario";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 11;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Mendoza";
         Gxm1pais = new SdtPais(context);
         Gxm2rootcol.Add(Gxm1pais, 0);
         Gxm1pais.gxTpr_Paisid = 4;
         Gxm1pais.gxTpr_Paisnombre = "Mexico";
         Gxm1pais.gxTpr_Paisbandera = context.convertURL( (String)(context.GetImagePath( "c76203b5-4770-469f-9346-1f6614ca4775", "", context.GetTheme( ))));
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 12;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Ciudad de México";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 13;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Monterrey";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 14;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Guadalajara";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 15;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Cancún";
         Gxm1pais = new SdtPais(context);
         Gxm2rootcol.Add(Gxm1pais, 0);
         Gxm1pais.gxTpr_Paisid = 5;
         Gxm1pais.gxTpr_Paisnombre = "Chile";
         Gxm1pais.gxTpr_Paisbandera = context.convertURL( (String)(context.GetImagePath( "3d796e5e-0646-49b7-9995-28657c90e2e4", "", context.GetTheme( ))));
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 16;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Santiago";
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         Gxm1pais.gxTpr_Ciudad.Add(Gxm3pais_ciudad, 0);
         Gxm3pais_ciudad.gxTpr_Ciudadid = 17;
         Gxm3pais_ciudad.gxTpr_Ciudadnombre = "Viña del Mar";
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
         Gxm1pais = new SdtPais(context);
         Gxm3pais_ciudad = new SdtPais_Ciudad(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private GXBCCollection<SdtPais> aP0_Gxm2rootcol ;
      private GXBCCollection<SdtPais> Gxm2rootcol ;
      private SdtPais Gxm1pais ;
      private SdtPais_Ciudad Gxm3pais_ciudad ;
   }

}
