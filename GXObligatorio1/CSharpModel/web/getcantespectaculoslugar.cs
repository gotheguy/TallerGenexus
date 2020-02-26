/*
               File: GetCantEspectaculosLugar
        Description: Get Cant Espectaculos Lugar
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:22.50
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
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class getcantespectaculoslugar : GXProcedure
   {
      public getcantespectaculoslugar( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public getcantespectaculoslugar( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_LugarId ,
                           out short aP1_CantEspectaculosLugar )
      {
         this.AV11LugarId = aP0_LugarId;
         this.AV9CantEspectaculosLugar = 0 ;
         initialize();
         executePrivate();
         aP1_CantEspectaculosLugar=this.AV9CantEspectaculosLugar;
      }

      public short executeUdp( short aP0_LugarId )
      {
         execute(aP0_LugarId, out aP1_CantEspectaculosLugar);
         return AV9CantEspectaculosLugar ;
      }

      public void executeSubmit( short aP0_LugarId ,
                                 out short aP1_CantEspectaculosLugar )
      {
         getcantespectaculoslugar objgetcantespectaculoslugar;
         objgetcantespectaculoslugar = new getcantespectaculoslugar();
         objgetcantespectaculoslugar.AV11LugarId = aP0_LugarId;
         objgetcantespectaculoslugar.AV9CantEspectaculosLugar = 0 ;
         objgetcantespectaculoslugar.context.SetSubmitInitialConfig(context);
         objgetcantespectaculoslugar.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgetcantespectaculoslugar);
         aP1_CantEspectaculosLugar=this.AV9CantEspectaculosLugar;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((getcantespectaculoslugar)stateInfo).executePrivate();
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
         /* Using cursor P000D3 */
         pr_default.execute(0, new Object[] {AV11LugarId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6TipoEspectaculoId = P000D3_A6TipoEspectaculoId[0];
            n6TipoEspectaculoId = P000D3_n6TipoEspectaculoId[0];
            A8LugarId = P000D3_A8LugarId[0];
            A40000GXC1 = P000D3_A40000GXC1[0];
            n40000GXC1 = P000D3_n40000GXC1[0];
            A34EspectaculoId = P000D3_A34EspectaculoId[0];
            A40000GXC1 = P000D3_A40000GXC1[0];
            n40000GXC1 = P000D3_n40000GXC1[0];
            AV9CantEspectaculosLugar = (short)(A40000GXC1);
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
         P000D3_A6TipoEspectaculoId = new short[1] ;
         P000D3_n6TipoEspectaculoId = new bool[] {false} ;
         P000D3_A8LugarId = new short[1] ;
         P000D3_A40000GXC1 = new int[1] ;
         P000D3_n40000GXC1 = new bool[] {false} ;
         P000D3_A34EspectaculoId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.getcantespectaculoslugar__default(),
            new Object[][] {
                new Object[] {
               P000D3_A6TipoEspectaculoId, P000D3_n6TipoEspectaculoId, P000D3_A8LugarId, P000D3_A40000GXC1, P000D3_n40000GXC1, P000D3_A34EspectaculoId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV11LugarId ;
      private short AV9CantEspectaculosLugar ;
      private short A6TipoEspectaculoId ;
      private short A8LugarId ;
      private short A34EspectaculoId ;
      private int A40000GXC1 ;
      private String scmdbuf ;
      private bool n6TipoEspectaculoId ;
      private bool n40000GXC1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000D3_A6TipoEspectaculoId ;
      private bool[] P000D3_n6TipoEspectaculoId ;
      private short[] P000D3_A8LugarId ;
      private int[] P000D3_A40000GXC1 ;
      private bool[] P000D3_n40000GXC1 ;
      private short[] P000D3_A34EspectaculoId ;
      private short aP1_CantEspectaculosLugar ;
   }

   public class getcantespectaculoslugar__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000D3 ;
          prmP000D3 = new Object[] {
          new Object[] {"@AV11LugarId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000D3", "SELECT T1.[TipoEspectaculoId], T1.[LugarId], COALESCE( T2.[GXC1], 0) AS GXC1, T1.[EspectaculoId] FROM ([Espectaculo] T1 LEFT JOIN (SELECT COUNT(*) AS GXC1, [TipoEspectaculoId] FROM [Espectaculo] GROUP BY [TipoEspectaculoId] ) T2 ON T2.[TipoEspectaculoId] = T1.[TipoEspectaculoId]) WHERE T1.[LugarId] = @AV11LugarId ORDER BY T1.[LugarId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D3,100, GxCacheFrequency.OFF ,false,false )
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
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
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
       }
    }

 }

}
