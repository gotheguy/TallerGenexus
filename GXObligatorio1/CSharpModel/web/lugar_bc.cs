/*
               File: Lugar_BC
        Description: Lugar
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/17/2020 21:44:20.8
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class lugar_bc : GXHttpHandler, IGxSilentTrn
   {
      public lugar_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public lugar_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow034( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey034( ) ;
         standaloneModal( ) ;
         AddRow034( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               Z8LugarId = A8LugarId;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_030( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls034( ) ;
            }
            else
            {
               CheckExtendedTable034( ) ;
               if ( AnyError == 0 )
               {
                  ZM034( 2) ;
                  ZM034( 3) ;
               }
               CloseExtendedTableCursors034( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12032( )
      {
         /* Start Routine */
      }

      protected void E11032( )
      {
         /* After Trn Routine */
      }

      protected void ZM034( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z9LugarNombre = A9LugarNombre;
            Z1PaisId = A1PaisId;
            Z4CiudadId = A4CiudadId;
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z2PaisNombre = A2PaisNombre;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z5CiudadNombre = A5CiudadNombre;
         }
         if ( GX_JID == -1 )
         {
            Z8LugarId = A8LugarId;
            Z9LugarNombre = A9LugarNombre;
            Z10LugarFoto = A10LugarFoto;
            Z40000LugarFoto_GXI = A40000LugarFoto_GXI;
            Z1PaisId = A1PaisId;
            Z4CiudadId = A4CiudadId;
            Z2PaisNombre = A2PaisNombre;
            Z3PaisBandera = A3PaisBandera;
            Z40001PaisBandera_GXI = A40001PaisBandera_GXI;
            Z5CiudadNombre = A5CiudadNombre;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load034( )
      {
         /* Using cursor BC00036 */
         pr_default.execute(4, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound4 = 1;
            A9LugarNombre = BC00036_A9LugarNombre[0];
            A40000LugarFoto_GXI = BC00036_A40000LugarFoto_GXI[0];
            A2PaisNombre = BC00036_A2PaisNombre[0];
            A40001PaisBandera_GXI = BC00036_A40001PaisBandera_GXI[0];
            A5CiudadNombre = BC00036_A5CiudadNombre[0];
            A1PaisId = BC00036_A1PaisId[0];
            A4CiudadId = BC00036_A4CiudadId[0];
            A10LugarFoto = BC00036_A10LugarFoto[0];
            A3PaisBandera = BC00036_A3PaisBandera[0];
            ZM034( -1) ;
         }
         pr_default.close(4);
         OnLoadActions034( ) ;
      }

      protected void OnLoadActions034( )
      {
      }

      protected void CheckExtendedTable034( )
      {
         nIsDirty_4 = 0;
         standaloneModal( ) ;
         /* Using cursor BC00034 */
         pr_default.execute(2, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
         }
         A2PaisNombre = BC00034_A2PaisNombre[0];
         A40001PaisBandera_GXI = BC00034_A40001PaisBandera_GXI[0];
         A3PaisBandera = BC00034_A3PaisBandera[0];
         pr_default.close(2);
         /* Using cursor BC00035 */
         pr_default.execute(3, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Ciudad'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
         }
         A5CiudadNombre = BC00035_A5CiudadNombre[0];
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors034( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey034( )
      {
         /* Using cursor BC00037 */
         pr_default.execute(5, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00033 */
         pr_default.execute(1, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM034( 1) ;
            RcdFound4 = 1;
            A8LugarId = BC00033_A8LugarId[0];
            A9LugarNombre = BC00033_A9LugarNombre[0];
            A40000LugarFoto_GXI = BC00033_A40000LugarFoto_GXI[0];
            A1PaisId = BC00033_A1PaisId[0];
            A4CiudadId = BC00033_A4CiudadId[0];
            A10LugarFoto = BC00033_A10LugarFoto[0];
            Z8LugarId = A8LugarId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load034( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey034( ) ;
            }
            Gx_mode = sMode4;
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey034( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode4;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey034( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_030( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency034( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor BC00032 */
            pr_default.execute(0, new Object[] {A8LugarId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Lugar"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z9LugarNombre, BC00032_A9LugarNombre[0]) != 0 ) || ( Z1PaisId != BC00032_A1PaisId[0] ) || ( Z4CiudadId != BC00032_A4CiudadId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Lugar"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM034( 0) ;
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00038 */
                     pr_default.execute(6, new Object[] {A8LugarId, A9LugarNombre, A10LugarFoto, A40000LugarFoto_GXI, A1PaisId, A4CiudadId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
                     if ( (pr_default.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load034( ) ;
            }
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void Update034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00039 */
                     pr_default.execute(7, new Object[] {A9LugarNombre, A1PaisId, A4CiudadId, A8LugarId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Lugar"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate034( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void DeferredUpdate034( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC000310 */
            pr_default.execute(8, new Object[] {A10LugarFoto, A40000LugarFoto_GXI, A8LugarId});
            pr_default.close(8);
            dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls034( ) ;
            AfterConfirm034( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete034( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000311 */
                  pr_default.execute(9, new Object[] {A8LugarId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel034( ) ;
         Gx_mode = sMode4;
      }

      protected void OnDeleteControls034( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000312 */
            pr_default.execute(10, new Object[] {A1PaisId});
            A2PaisNombre = BC000312_A2PaisNombre[0];
            A40001PaisBandera_GXI = BC000312_A40001PaisBandera_GXI[0];
            A3PaisBandera = BC000312_A3PaisBandera[0];
            pr_default.close(10);
            /* Using cursor BC000313 */
            pr_default.execute(11, new Object[] {A1PaisId, A4CiudadId});
            A5CiudadNombre = BC000313_A5CiudadNombre[0];
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000314 */
            pr_default.execute(12, new Object[] {A8LugarId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Espectaculo"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel034( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete034( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart034( )
      {
         /* Scan By routine */
         /* Using cursor BC000315 */
         pr_default.execute(13, new Object[] {A8LugarId});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound4 = 1;
            A8LugarId = BC000315_A8LugarId[0];
            A9LugarNombre = BC000315_A9LugarNombre[0];
            A40000LugarFoto_GXI = BC000315_A40000LugarFoto_GXI[0];
            A2PaisNombre = BC000315_A2PaisNombre[0];
            A40001PaisBandera_GXI = BC000315_A40001PaisBandera_GXI[0];
            A5CiudadNombre = BC000315_A5CiudadNombre[0];
            A1PaisId = BC000315_A1PaisId[0];
            A4CiudadId = BC000315_A4CiudadId[0];
            A10LugarFoto = BC000315_A10LugarFoto[0];
            A3PaisBandera = BC000315_A3PaisBandera[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext034( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound4 = 0;
         ScanKeyLoad034( ) ;
      }

      protected void ScanKeyLoad034( )
      {
         sMode4 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound4 = 1;
            A8LugarId = BC000315_A8LugarId[0];
            A9LugarNombre = BC000315_A9LugarNombre[0];
            A40000LugarFoto_GXI = BC000315_A40000LugarFoto_GXI[0];
            A2PaisNombre = BC000315_A2PaisNombre[0];
            A40001PaisBandera_GXI = BC000315_A40001PaisBandera_GXI[0];
            A5CiudadNombre = BC000315_A5CiudadNombre[0];
            A1PaisId = BC000315_A1PaisId[0];
            A4CiudadId = BC000315_A4CiudadId[0];
            A10LugarFoto = BC000315_A10LugarFoto[0];
            A3PaisBandera = BC000315_A3PaisBandera[0];
         }
         Gx_mode = sMode4;
      }

      protected void ScanKeyEnd034( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm034( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert034( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate034( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete034( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete034( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate034( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes034( )
      {
      }

      protected void send_integrity_lvl_hashes034( )
      {
      }

      protected void AddRow034( )
      {
         VarsToRow4( bcLugar) ;
      }

      protected void ReadRow034( )
      {
         RowToVars4( bcLugar, 1) ;
      }

      protected void InitializeNonKey034( )
      {
         A9LugarNombre = "";
         A10LugarFoto = "";
         A40000LugarFoto_GXI = "";
         A1PaisId = 0;
         A2PaisNombre = "";
         A3PaisBandera = "";
         A40001PaisBandera_GXI = "";
         A4CiudadId = 0;
         A5CiudadNombre = "";
         Z9LugarNombre = "";
         Z1PaisId = 0;
         Z4CiudadId = 0;
      }

      protected void InitAll034( )
      {
         A8LugarId = 0;
         InitializeNonKey034( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public void VarsToRow4( SdtLugar obj4 )
      {
         obj4.gxTpr_Mode = Gx_mode;
         obj4.gxTpr_Lugarnombre = A9LugarNombre;
         obj4.gxTpr_Lugarfoto = A10LugarFoto;
         obj4.gxTpr_Lugarfoto_gxi = A40000LugarFoto_GXI;
         obj4.gxTpr_Paisid = A1PaisId;
         obj4.gxTpr_Paisnombre = A2PaisNombre;
         obj4.gxTpr_Paisbandera = A3PaisBandera;
         obj4.gxTpr_Paisbandera_gxi = A40001PaisBandera_GXI;
         obj4.gxTpr_Ciudadid = A4CiudadId;
         obj4.gxTpr_Ciudadnombre = A5CiudadNombre;
         obj4.gxTpr_Lugarid = A8LugarId;
         obj4.gxTpr_Lugarid_Z = Z8LugarId;
         obj4.gxTpr_Lugarnombre_Z = Z9LugarNombre;
         obj4.gxTpr_Paisid_Z = Z1PaisId;
         obj4.gxTpr_Paisnombre_Z = Z2PaisNombre;
         obj4.gxTpr_Ciudadid_Z = Z4CiudadId;
         obj4.gxTpr_Ciudadnombre_Z = Z5CiudadNombre;
         obj4.gxTpr_Lugarfoto_gxi_Z = Z40000LugarFoto_GXI;
         obj4.gxTpr_Paisbandera_gxi_Z = Z40001PaisBandera_GXI;
         obj4.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow4( SdtLugar obj4 )
      {
         obj4.gxTpr_Lugarid = A8LugarId;
         return  ;
      }

      public void RowToVars4( SdtLugar obj4 ,
                              int forceLoad )
      {
         Gx_mode = obj4.gxTpr_Mode;
         A9LugarNombre = obj4.gxTpr_Lugarnombre;
         A10LugarFoto = obj4.gxTpr_Lugarfoto;
         A40000LugarFoto_GXI = obj4.gxTpr_Lugarfoto_gxi;
         A1PaisId = obj4.gxTpr_Paisid;
         A2PaisNombre = obj4.gxTpr_Paisnombre;
         A3PaisBandera = obj4.gxTpr_Paisbandera;
         A40001PaisBandera_GXI = obj4.gxTpr_Paisbandera_gxi;
         A4CiudadId = obj4.gxTpr_Ciudadid;
         A5CiudadNombre = obj4.gxTpr_Ciudadnombre;
         A8LugarId = obj4.gxTpr_Lugarid;
         Z8LugarId = obj4.gxTpr_Lugarid_Z;
         Z9LugarNombre = obj4.gxTpr_Lugarnombre_Z;
         Z1PaisId = obj4.gxTpr_Paisid_Z;
         Z2PaisNombre = obj4.gxTpr_Paisnombre_Z;
         Z4CiudadId = obj4.gxTpr_Ciudadid_Z;
         Z5CiudadNombre = obj4.gxTpr_Ciudadnombre_Z;
         Z40000LugarFoto_GXI = obj4.gxTpr_Lugarfoto_gxi_Z;
         Z40001PaisBandera_GXI = obj4.gxTpr_Paisbandera_gxi_Z;
         Gx_mode = obj4.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A8LugarId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey034( ) ;
         ScanKeyStart034( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z8LugarId = A8LugarId;
         }
         ZM034( -1) ;
         OnLoadActions034( ) ;
         AddRow034( ) ;
         ScanKeyEnd034( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars4( bcLugar, 0) ;
         ScanKeyStart034( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z8LugarId = A8LugarId;
         }
         ZM034( -1) ;
         OnLoadActions034( ) ;
         AddRow034( ) ;
         ScanKeyEnd034( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey034( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            Insert034( ) ;
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A8LugarId != Z8LugarId )
               {
                  A8LugarId = Z8LugarId;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update034( ) ;
               }
            }
            else
            {
               if ( IsDlt( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A8LugarId != Z8LugarId )
                  {
                     if ( IsUpd( ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert034( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert034( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars4( bcLugar, 0) ;
         SaveImpl( ) ;
         VarsToRow4( bcLugar) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars4( bcLugar, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert034( ) ;
         AfterTrn( ) ;
         VarsToRow4( bcLugar) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( IsUpd( ) )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtLugar auxBC = new SdtLugar(context) ;
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            auxBC.Load(A8LugarId);
            if ( auxTrn.Errors() == 0 )
            {
               auxBC.UpdateDirties(bcLugar);
               auxBC.Save();
            }
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            context.GX_msglist = LclMsgLst;
            if ( auxTrn.Errors() == 0 )
            {
               Gx_mode = auxTrn.GetMode();
               AfterTrn( ) ;
            }
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars4( bcLugar, 0) ;
         UpdateImpl( ) ;
         VarsToRow4( bcLugar) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars4( bcLugar, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert034( ) ;
         if ( AnyError == 1 )
         {
            if ( StringUtil.StrCmp(context.GX_msglist.getItemValue(1), "DuplicatePrimaryKey") == 0 )
            {
               AnyError = 0;
               context.GX_msglist.removeAllItems();
               UpdateImpl( ) ;
            }
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow4( bcLugar) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars4( bcLugar, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey034( ) ;
         if ( RcdFound4 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A8LugarId != Z8LugarId )
            {
               A8LugarId = Z8LugarId;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( IsDlt( ) )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A8LugarId != Z8LugarId )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( IsUpd( ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(10);
         pr_default.close(11);
         context.RollbackDataStores("lugar_bc",pr_default);
         VarsToRow4( bcLugar) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcLugar.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcLugar.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcLugar )
         {
            bcLugar = (SdtLugar)(sdt);
            if ( StringUtil.StrCmp(bcLugar.gxTpr_Mode, "") == 0 )
            {
               bcLugar.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow4( bcLugar) ;
            }
            else
            {
               RowToVars4( bcLugar, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcLugar.gxTpr_Mode, "") == 0 )
            {
               bcLugar.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars4( bcLugar, 1) ;
         return  ;
      }

      public void ForceCommitOnExit( )
      {
         mustCommit = true;
         return  ;
      }

      public SdtLugar Lugar_BC
      {
         get {
            return bcLugar ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(10);
         pr_default.close(11);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z9LugarNombre = "";
         A9LugarNombre = "";
         Z2PaisNombre = "";
         A2PaisNombre = "";
         Z5CiudadNombre = "";
         A5CiudadNombre = "";
         Z10LugarFoto = "";
         A10LugarFoto = "";
         Z40000LugarFoto_GXI = "";
         A40000LugarFoto_GXI = "";
         Z3PaisBandera = "";
         A3PaisBandera = "";
         Z40001PaisBandera_GXI = "";
         A40001PaisBandera_GXI = "";
         BC00036_A8LugarId = new short[1] ;
         BC00036_A9LugarNombre = new String[] {""} ;
         BC00036_A40000LugarFoto_GXI = new String[] {""} ;
         BC00036_A2PaisNombre = new String[] {""} ;
         BC00036_A40001PaisBandera_GXI = new String[] {""} ;
         BC00036_A5CiudadNombre = new String[] {""} ;
         BC00036_A1PaisId = new short[1] ;
         BC00036_A4CiudadId = new short[1] ;
         BC00036_A10LugarFoto = new String[] {""} ;
         BC00036_A3PaisBandera = new String[] {""} ;
         BC00034_A2PaisNombre = new String[] {""} ;
         BC00034_A40001PaisBandera_GXI = new String[] {""} ;
         BC00034_A3PaisBandera = new String[] {""} ;
         BC00035_A5CiudadNombre = new String[] {""} ;
         BC00037_A8LugarId = new short[1] ;
         BC00033_A8LugarId = new short[1] ;
         BC00033_A9LugarNombre = new String[] {""} ;
         BC00033_A40000LugarFoto_GXI = new String[] {""} ;
         BC00033_A1PaisId = new short[1] ;
         BC00033_A4CiudadId = new short[1] ;
         BC00033_A10LugarFoto = new String[] {""} ;
         sMode4 = "";
         BC00032_A8LugarId = new short[1] ;
         BC00032_A9LugarNombre = new String[] {""} ;
         BC00032_A40000LugarFoto_GXI = new String[] {""} ;
         BC00032_A1PaisId = new short[1] ;
         BC00032_A4CiudadId = new short[1] ;
         BC00032_A10LugarFoto = new String[] {""} ;
         BC000312_A2PaisNombre = new String[] {""} ;
         BC000312_A40001PaisBandera_GXI = new String[] {""} ;
         BC000312_A3PaisBandera = new String[] {""} ;
         BC000313_A5CiudadNombre = new String[] {""} ;
         BC000314_A34EspectaculoId = new short[1] ;
         BC000315_A8LugarId = new short[1] ;
         BC000315_A9LugarNombre = new String[] {""} ;
         BC000315_A40000LugarFoto_GXI = new String[] {""} ;
         BC000315_A2PaisNombre = new String[] {""} ;
         BC000315_A40001PaisBandera_GXI = new String[] {""} ;
         BC000315_A5CiudadNombre = new String[] {""} ;
         BC000315_A1PaisId = new short[1] ;
         BC000315_A4CiudadId = new short[1] ;
         BC000315_A10LugarFoto = new String[] {""} ;
         BC000315_A3PaisBandera = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.lugar_bc__default(),
            new Object[][] {
                new Object[] {
               BC00032_A8LugarId, BC00032_A9LugarNombre, BC00032_A40000LugarFoto_GXI, BC00032_A1PaisId, BC00032_A4CiudadId, BC00032_A10LugarFoto
               }
               , new Object[] {
               BC00033_A8LugarId, BC00033_A9LugarNombre, BC00033_A40000LugarFoto_GXI, BC00033_A1PaisId, BC00033_A4CiudadId, BC00033_A10LugarFoto
               }
               , new Object[] {
               BC00034_A2PaisNombre, BC00034_A40001PaisBandera_GXI, BC00034_A3PaisBandera
               }
               , new Object[] {
               BC00035_A5CiudadNombre
               }
               , new Object[] {
               BC00036_A8LugarId, BC00036_A9LugarNombre, BC00036_A40000LugarFoto_GXI, BC00036_A2PaisNombre, BC00036_A40001PaisBandera_GXI, BC00036_A5CiudadNombre, BC00036_A1PaisId, BC00036_A4CiudadId, BC00036_A10LugarFoto, BC00036_A3PaisBandera
               }
               , new Object[] {
               BC00037_A8LugarId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000312_A2PaisNombre, BC000312_A40001PaisBandera_GXI, BC000312_A3PaisBandera
               }
               , new Object[] {
               BC000313_A5CiudadNombre
               }
               , new Object[] {
               BC000314_A34EspectaculoId
               }
               , new Object[] {
               BC000315_A8LugarId, BC000315_A9LugarNombre, BC000315_A40000LugarFoto_GXI, BC000315_A2PaisNombre, BC000315_A40001PaisBandera_GXI, BC000315_A5CiudadNombre, BC000315_A1PaisId, BC000315_A4CiudadId, BC000315_A10LugarFoto, BC000315_A3PaisBandera
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12032 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z8LugarId ;
      private short A8LugarId ;
      private short GX_JID ;
      private short Z1PaisId ;
      private short A1PaisId ;
      private short Z4CiudadId ;
      private short A4CiudadId ;
      private short RcdFound4 ;
      private short nIsDirty_4 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String Z9LugarNombre ;
      private String A9LugarNombre ;
      private String Z2PaisNombre ;
      private String A2PaisNombre ;
      private String Z5CiudadNombre ;
      private String A5CiudadNombre ;
      private String sMode4 ;
      private bool mustCommit ;
      private String Z40000LugarFoto_GXI ;
      private String A40000LugarFoto_GXI ;
      private String Z40001PaisBandera_GXI ;
      private String A40001PaisBandera_GXI ;
      private String Z10LugarFoto ;
      private String A10LugarFoto ;
      private String Z3PaisBandera ;
      private String A3PaisBandera ;
      private SdtLugar bcLugar ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00036_A8LugarId ;
      private String[] BC00036_A9LugarNombre ;
      private String[] BC00036_A40000LugarFoto_GXI ;
      private String[] BC00036_A2PaisNombre ;
      private String[] BC00036_A40001PaisBandera_GXI ;
      private String[] BC00036_A5CiudadNombre ;
      private short[] BC00036_A1PaisId ;
      private short[] BC00036_A4CiudadId ;
      private String[] BC00036_A10LugarFoto ;
      private String[] BC00036_A3PaisBandera ;
      private String[] BC00034_A2PaisNombre ;
      private String[] BC00034_A40001PaisBandera_GXI ;
      private String[] BC00034_A3PaisBandera ;
      private String[] BC00035_A5CiudadNombre ;
      private short[] BC00037_A8LugarId ;
      private short[] BC00033_A8LugarId ;
      private String[] BC00033_A9LugarNombre ;
      private String[] BC00033_A40000LugarFoto_GXI ;
      private short[] BC00033_A1PaisId ;
      private short[] BC00033_A4CiudadId ;
      private String[] BC00033_A10LugarFoto ;
      private short[] BC00032_A8LugarId ;
      private String[] BC00032_A9LugarNombre ;
      private String[] BC00032_A40000LugarFoto_GXI ;
      private short[] BC00032_A1PaisId ;
      private short[] BC00032_A4CiudadId ;
      private String[] BC00032_A10LugarFoto ;
      private String[] BC000312_A2PaisNombre ;
      private String[] BC000312_A40001PaisBandera_GXI ;
      private String[] BC000312_A3PaisBandera ;
      private String[] BC000313_A5CiudadNombre ;
      private short[] BC000314_A34EspectaculoId ;
      private short[] BC000315_A8LugarId ;
      private String[] BC000315_A9LugarNombre ;
      private String[] BC000315_A40000LugarFoto_GXI ;
      private String[] BC000315_A2PaisNombre ;
      private String[] BC000315_A40001PaisBandera_GXI ;
      private String[] BC000315_A5CiudadNombre ;
      private short[] BC000315_A1PaisId ;
      private short[] BC000315_A4CiudadId ;
      private String[] BC000315_A10LugarFoto ;
      private String[] BC000315_A3PaisBandera ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class lugar_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00036 ;
          prmBC00036 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00034 ;
          prmBC00034 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00035 ;
          prmBC00035 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00037 ;
          prmBC00037 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00033 ;
          prmBC00033 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00032 ;
          prmBC00032 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00038 ;
          prmBC00038 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LugarFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@LugarFoto_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00039 ;
          prmBC00039 = new Object[] {
          new Object[] {"@LugarNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000310 ;
          prmBC000310 = new Object[] {
          new Object[] {"@LugarFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@LugarFoto_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000311 ;
          prmBC000311 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000312 ;
          prmBC000312 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000313 ;
          prmBC000313 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000314 ;
          prmBC000314 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000315 ;
          prmBC000315 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00032", "SELECT [LugarId], [LugarNombre], [LugarFoto_GXI], [PaisId], [CiudadId], [LugarFoto] FROM [Lugar] WITH (UPDLOCK) WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00032,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00033", "SELECT [LugarId], [LugarNombre], [LugarFoto_GXI], [PaisId], [CiudadId], [LugarFoto] FROM [Lugar] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00033,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00034", "SELECT [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00034,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00035", "SELECT [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00035,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00036", "SELECT TM1.[LugarId], TM1.[LugarNombre], TM1.[LugarFoto_GXI], T2.[PaisNombre], T2.[PaisBandera_GXI], T3.[CiudadNombre], TM1.[PaisId], TM1.[CiudadId], TM1.[LugarFoto], T2.[PaisBandera] FROM (([Lugar] TM1 INNER JOIN [Pais] T2 ON T2.[PaisId] = TM1.[PaisId]) INNER JOIN [PaisCiudad] T3 ON T3.[PaisId] = TM1.[PaisId] AND T3.[CiudadId] = TM1.[CiudadId]) WHERE TM1.[LugarId] = @LugarId ORDER BY TM1.[LugarId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00036,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00037", "SELECT [LugarId] FROM [Lugar] WHERE [LugarId] = @LugarId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00037,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00038", "INSERT INTO [Lugar]([LugarId], [LugarNombre], [LugarFoto], [LugarFoto_GXI], [PaisId], [CiudadId]) VALUES(@LugarId, @LugarNombre, @LugarFoto, @LugarFoto_GXI, @PaisId, @CiudadId)", GxErrorMask.GX_NOMASK,prmBC00038)
             ,new CursorDef("BC00039", "UPDATE [Lugar] SET [LugarNombre]=@LugarNombre, [PaisId]=@PaisId, [CiudadId]=@CiudadId  WHERE [LugarId] = @LugarId", GxErrorMask.GX_NOMASK,prmBC00039)
             ,new CursorDef("BC000310", "UPDATE [Lugar] SET [LugarFoto]=@LugarFoto, [LugarFoto_GXI]=@LugarFoto_GXI  WHERE [LugarId] = @LugarId", GxErrorMask.GX_NOMASK,prmBC000310)
             ,new CursorDef("BC000311", "DELETE FROM [Lugar]  WHERE [LugarId] = @LugarId", GxErrorMask.GX_NOMASK,prmBC000311)
             ,new CursorDef("BC000312", "SELECT [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000312,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000313", "SELECT [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000313,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000314", "SELECT TOP 1 [EspectaculoId] FROM [Espectaculo] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000314,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("BC000315", "SELECT TM1.[LugarId], TM1.[LugarNombre], TM1.[LugarFoto_GXI], T2.[PaisNombre], T2.[PaisBandera_GXI], T3.[CiudadNombre], TM1.[PaisId], TM1.[CiudadId], TM1.[LugarFoto], T2.[PaisBandera] FROM (([Lugar] TM1 INNER JOIN [Pais] T2 ON T2.[PaisId] = TM1.[PaisId]) INNER JOIN [PaisCiudad] T3 ON T3.[PaisId] = TM1.[PaisId] AND T3.[CiudadId] = TM1.[CiudadId]) WHERE TM1.[LugarId] = @LugarId ORDER BY TM1.[LugarId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000315,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((String[]) buf[4])[0] = rslt.getMultimediaUri(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(3)) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(5)) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((String[]) buf[4])[0] = rslt.getMultimediaUri(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(3)) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(5)) ;
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
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterBlob(3, (String)parms[2], false);
                stmt.SetParameterMultimedia(4, (String)parms[3], (String)parms[2], "Lugar", "LugarFoto");
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 8 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Lugar", "LugarFoto");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
