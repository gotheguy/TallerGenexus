/*
               File: TipoEspectaculo_BC
        Description: Tipo Espectaculo
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/17/2020 21:44:21.89
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
   public class tipoespectaculo_bc : GXHttpHandler, IGxSilentTrn
   {
      public tipoespectaculo_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tipoespectaculo_bc( IGxContext context )
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
         ReadRow0811( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0811( ) ;
         standaloneModal( ) ;
         AddRow0811( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               Z6TipoEspectaculoId = A6TipoEspectaculoId;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls0811( ) ;
            }
            else
            {
               CheckExtendedTable0811( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0811( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12082( )
      {
         /* Start Routine */
      }

      protected void E11082( )
      {
         /* After Trn Routine */
      }

      protected void ZM0811( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z7TipoEspectaculoNombre = A7TipoEspectaculoNombre;
         }
         if ( GX_JID == -1 )
         {
            Z6TipoEspectaculoId = A6TipoEspectaculoId;
            Z7TipoEspectaculoNombre = A7TipoEspectaculoNombre;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0811( )
      {
         /* Using cursor BC00084 */
         pr_default.execute(2, new Object[] {A6TipoEspectaculoId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound11 = 1;
            A7TipoEspectaculoNombre = BC00084_A7TipoEspectaculoNombre[0];
            ZM0811( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0811( ) ;
      }

      protected void OnLoadActions0811( )
      {
      }

      protected void CheckExtendedTable0811( )
      {
         nIsDirty_11 = 0;
         standaloneModal( ) ;
         /* Using cursor BC00085 */
         pr_default.execute(3, new Object[] {A7TipoEspectaculoNombre, A6TipoEspectaculoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Tipo Espectaculo Nombre"}), 1, "");
            AnyError = 1;
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0811( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0811( )
      {
         /* Using cursor BC00086 */
         pr_default.execute(4, new Object[] {A6TipoEspectaculoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00083 */
         pr_default.execute(1, new Object[] {A6TipoEspectaculoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0811( 1) ;
            RcdFound11 = 1;
            A6TipoEspectaculoId = BC00083_A6TipoEspectaculoId[0];
            A7TipoEspectaculoNombre = BC00083_A7TipoEspectaculoNombre[0];
            Z6TipoEspectaculoId = A6TipoEspectaculoId;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0811( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0811( ) ;
            }
            Gx_mode = sMode11;
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0811( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode11;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0811( ) ;
         if ( RcdFound11 == 0 )
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
         CONFIRM_080( ) ;
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

      protected void CheckOptimisticConcurrency0811( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor BC00082 */
            pr_default.execute(0, new Object[] {A6TipoEspectaculoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoEspectaculo"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z7TipoEspectaculoNombre, BC00082_A7TipoEspectaculoNombre[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoEspectaculo"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0811( )
      {
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0811( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0811( 0) ;
            CheckOptimisticConcurrency0811( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0811( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0811( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00087 */
                     pr_default.execute(5, new Object[] {A6TipoEspectaculoId, A7TipoEspectaculoNombre});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("TipoEspectaculo") ;
                     if ( (pr_default.getStatus(5) == 1) )
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
               Load0811( ) ;
            }
            EndLevel0811( ) ;
         }
         CloseExtendedTableCursors0811( ) ;
      }

      protected void Update0811( )
      {
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0811( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0811( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0811( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0811( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00088 */
                     pr_default.execute(6, new Object[] {A7TipoEspectaculoNombre, A6TipoEspectaculoId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("TipoEspectaculo") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoEspectaculo"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0811( ) ;
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
            EndLevel0811( ) ;
         }
         CloseExtendedTableCursors0811( ) ;
      }

      protected void DeferredUpdate0811( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0811( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0811( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0811( ) ;
            AfterConfirm0811( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0811( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00089 */
                  pr_default.execute(7, new Object[] {A6TipoEspectaculoId});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("TipoEspectaculo") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0811( ) ;
         Gx_mode = sMode11;
      }

      protected void OnDeleteControls0811( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000810 */
            pr_default.execute(8, new Object[] {A6TipoEspectaculoId});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Espectaculo"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel0811( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0811( ) ;
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

      public void ScanKeyStart0811( )
      {
         /* Scan By routine */
         /* Using cursor BC000811 */
         pr_default.execute(9, new Object[] {A6TipoEspectaculoId});
         RcdFound11 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound11 = 1;
            A6TipoEspectaculoId = BC000811_A6TipoEspectaculoId[0];
            A7TipoEspectaculoNombre = BC000811_A7TipoEspectaculoNombre[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0811( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound11 = 0;
         ScanKeyLoad0811( ) ;
      }

      protected void ScanKeyLoad0811( )
      {
         sMode11 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound11 = 1;
            A6TipoEspectaculoId = BC000811_A6TipoEspectaculoId[0];
            A7TipoEspectaculoNombre = BC000811_A7TipoEspectaculoNombre[0];
         }
         Gx_mode = sMode11;
      }

      protected void ScanKeyEnd0811( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0811( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0811( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0811( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0811( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0811( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0811( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0811( )
      {
      }

      protected void send_integrity_lvl_hashes0811( )
      {
      }

      protected void AddRow0811( )
      {
         VarsToRow11( bcTipoEspectaculo) ;
      }

      protected void ReadRow0811( )
      {
         RowToVars11( bcTipoEspectaculo, 1) ;
      }

      protected void InitializeNonKey0811( )
      {
         A7TipoEspectaculoNombre = "";
         Z7TipoEspectaculoNombre = "";
      }

      protected void InitAll0811( )
      {
         A6TipoEspectaculoId = 0;
         InitializeNonKey0811( ) ;
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

      public void VarsToRow11( SdtTipoEspectaculo obj11 )
      {
         obj11.gxTpr_Mode = Gx_mode;
         obj11.gxTpr_Tipoespectaculonombre = A7TipoEspectaculoNombre;
         obj11.gxTpr_Tipoespectaculoid = A6TipoEspectaculoId;
         obj11.gxTpr_Tipoespectaculoid_Z = Z6TipoEspectaculoId;
         obj11.gxTpr_Tipoespectaculonombre_Z = Z7TipoEspectaculoNombre;
         obj11.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow11( SdtTipoEspectaculo obj11 )
      {
         obj11.gxTpr_Tipoespectaculoid = A6TipoEspectaculoId;
         return  ;
      }

      public void RowToVars11( SdtTipoEspectaculo obj11 ,
                               int forceLoad )
      {
         Gx_mode = obj11.gxTpr_Mode;
         A7TipoEspectaculoNombre = obj11.gxTpr_Tipoespectaculonombre;
         A6TipoEspectaculoId = obj11.gxTpr_Tipoespectaculoid;
         Z6TipoEspectaculoId = obj11.gxTpr_Tipoespectaculoid_Z;
         Z7TipoEspectaculoNombre = obj11.gxTpr_Tipoespectaculonombre_Z;
         Gx_mode = obj11.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A6TipoEspectaculoId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0811( ) ;
         ScanKeyStart0811( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z6TipoEspectaculoId = A6TipoEspectaculoId;
         }
         ZM0811( -1) ;
         OnLoadActions0811( ) ;
         AddRow0811( ) ;
         ScanKeyEnd0811( ) ;
         if ( RcdFound11 == 0 )
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
         RowToVars11( bcTipoEspectaculo, 0) ;
         ScanKeyStart0811( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z6TipoEspectaculoId = A6TipoEspectaculoId;
         }
         ZM0811( -1) ;
         OnLoadActions0811( ) ;
         AddRow0811( ) ;
         ScanKeyEnd0811( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0811( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            Insert0811( ) ;
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A6TipoEspectaculoId != Z6TipoEspectaculoId )
               {
                  A6TipoEspectaculoId = Z6TipoEspectaculoId;
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
                  Update0811( ) ;
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
                  if ( A6TipoEspectaculoId != Z6TipoEspectaculoId )
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
                        Insert0811( ) ;
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
                        Insert0811( ) ;
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
         RowToVars11( bcTipoEspectaculo, 0) ;
         SaveImpl( ) ;
         VarsToRow11( bcTipoEspectaculo) ;
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
         RowToVars11( bcTipoEspectaculo, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0811( ) ;
         AfterTrn( ) ;
         VarsToRow11( bcTipoEspectaculo) ;
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
            SdtTipoEspectaculo auxBC = new SdtTipoEspectaculo(context) ;
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            auxBC.Load(A6TipoEspectaculoId);
            if ( auxTrn.Errors() == 0 )
            {
               auxBC.UpdateDirties(bcTipoEspectaculo);
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
         RowToVars11( bcTipoEspectaculo, 0) ;
         UpdateImpl( ) ;
         VarsToRow11( bcTipoEspectaculo) ;
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
         RowToVars11( bcTipoEspectaculo, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0811( ) ;
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
         VarsToRow11( bcTipoEspectaculo) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars11( bcTipoEspectaculo, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0811( ) ;
         if ( RcdFound11 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A6TipoEspectaculoId != Z6TipoEspectaculoId )
            {
               A6TipoEspectaculoId = Z6TipoEspectaculoId;
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
            if ( A6TipoEspectaculoId != Z6TipoEspectaculoId )
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
         context.RollbackDataStores("tipoespectaculo_bc",pr_default);
         VarsToRow11( bcTipoEspectaculo) ;
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
         Gx_mode = bcTipoEspectaculo.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcTipoEspectaculo.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcTipoEspectaculo )
         {
            bcTipoEspectaculo = (SdtTipoEspectaculo)(sdt);
            if ( StringUtil.StrCmp(bcTipoEspectaculo.gxTpr_Mode, "") == 0 )
            {
               bcTipoEspectaculo.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow11( bcTipoEspectaculo) ;
            }
            else
            {
               RowToVars11( bcTipoEspectaculo, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcTipoEspectaculo.gxTpr_Mode, "") == 0 )
            {
               bcTipoEspectaculo.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars11( bcTipoEspectaculo, 1) ;
         return  ;
      }

      public void ForceCommitOnExit( )
      {
         mustCommit = true;
         return  ;
      }

      public SdtTipoEspectaculo TipoEspectaculo_BC
      {
         get {
            return bcTipoEspectaculo ;
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
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z7TipoEspectaculoNombre = "";
         A7TipoEspectaculoNombre = "";
         BC00084_A6TipoEspectaculoId = new short[1] ;
         BC00084_A7TipoEspectaculoNombre = new String[] {""} ;
         BC00085_A7TipoEspectaculoNombre = new String[] {""} ;
         BC00086_A6TipoEspectaculoId = new short[1] ;
         BC00083_A6TipoEspectaculoId = new short[1] ;
         BC00083_A7TipoEspectaculoNombre = new String[] {""} ;
         sMode11 = "";
         BC00082_A6TipoEspectaculoId = new short[1] ;
         BC00082_A7TipoEspectaculoNombre = new String[] {""} ;
         BC000810_A34EspectaculoId = new short[1] ;
         BC000811_A6TipoEspectaculoId = new short[1] ;
         BC000811_A7TipoEspectaculoNombre = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipoespectaculo_bc__default(),
            new Object[][] {
                new Object[] {
               BC00082_A6TipoEspectaculoId, BC00082_A7TipoEspectaculoNombre
               }
               , new Object[] {
               BC00083_A6TipoEspectaculoId, BC00083_A7TipoEspectaculoNombre
               }
               , new Object[] {
               BC00084_A6TipoEspectaculoId, BC00084_A7TipoEspectaculoNombre
               }
               , new Object[] {
               BC00085_A7TipoEspectaculoNombre
               }
               , new Object[] {
               BC00086_A6TipoEspectaculoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000810_A34EspectaculoId
               }
               , new Object[] {
               BC000811_A6TipoEspectaculoId, BC000811_A7TipoEspectaculoNombre
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12082 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z6TipoEspectaculoId ;
      private short A6TipoEspectaculoId ;
      private short GX_JID ;
      private short RcdFound11 ;
      private short nIsDirty_11 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String Z7TipoEspectaculoNombre ;
      private String A7TipoEspectaculoNombre ;
      private String sMode11 ;
      private bool mustCommit ;
      private SdtTipoEspectaculo bcTipoEspectaculo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00084_A6TipoEspectaculoId ;
      private String[] BC00084_A7TipoEspectaculoNombre ;
      private String[] BC00085_A7TipoEspectaculoNombre ;
      private short[] BC00086_A6TipoEspectaculoId ;
      private short[] BC00083_A6TipoEspectaculoId ;
      private String[] BC00083_A7TipoEspectaculoNombre ;
      private short[] BC00082_A6TipoEspectaculoId ;
      private String[] BC00082_A7TipoEspectaculoNombre ;
      private short[] BC000810_A34EspectaculoId ;
      private short[] BC000811_A6TipoEspectaculoId ;
      private String[] BC000811_A7TipoEspectaculoNombre ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class tipoespectaculo_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00084 ;
          prmBC00084 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00085 ;
          prmBC00085 = new Object[] {
          new Object[] {"@TipoEspectaculoNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00086 ;
          prmBC00086 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00083 ;
          prmBC00083 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00082 ;
          prmBC00082 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00087 ;
          prmBC00087 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoEspectaculoNombre",SqlDbType.NChar,100,0}
          } ;
          Object[] prmBC00088 ;
          prmBC00088 = new Object[] {
          new Object[] {"@TipoEspectaculoNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00089 ;
          prmBC00089 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000810 ;
          prmBC000810 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000811 ;
          prmBC000811 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00082", "SELECT [TipoEspectaculoId], [TipoEspectaculoNombre] FROM [TipoEspectaculo] WITH (UPDLOCK) WHERE [TipoEspectaculoId] = @TipoEspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00082,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00083", "SELECT [TipoEspectaculoId], [TipoEspectaculoNombre] FROM [TipoEspectaculo] WHERE [TipoEspectaculoId] = @TipoEspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00083,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00084", "SELECT TM1.[TipoEspectaculoId], TM1.[TipoEspectaculoNombre] FROM [TipoEspectaculo] TM1 WHERE TM1.[TipoEspectaculoId] = @TipoEspectaculoId ORDER BY TM1.[TipoEspectaculoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00084,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00085", "SELECT [TipoEspectaculoNombre] FROM [TipoEspectaculo] WHERE ([TipoEspectaculoNombre] = @TipoEspectaculoNombre) AND (Not ( [TipoEspectaculoId] = @TipoEspectaculoId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00085,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00086", "SELECT [TipoEspectaculoId] FROM [TipoEspectaculo] WHERE [TipoEspectaculoId] = @TipoEspectaculoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00086,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00087", "INSERT INTO [TipoEspectaculo]([TipoEspectaculoId], [TipoEspectaculoNombre]) VALUES(@TipoEspectaculoId, @TipoEspectaculoNombre)", GxErrorMask.GX_NOMASK,prmBC00087)
             ,new CursorDef("BC00088", "UPDATE [TipoEspectaculo] SET [TipoEspectaculoNombre]=@TipoEspectaculoNombre  WHERE [TipoEspectaculoId] = @TipoEspectaculoId", GxErrorMask.GX_NOMASK,prmBC00088)
             ,new CursorDef("BC00089", "DELETE FROM [TipoEspectaculo]  WHERE [TipoEspectaculoId] = @TipoEspectaculoId", GxErrorMask.GX_NOMASK,prmBC00089)
             ,new CursorDef("BC000810", "SELECT TOP 1 [EspectaculoId] FROM [Espectaculo] WHERE [TipoEspectaculoId] = @TipoEspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000810,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("BC000811", "SELECT TM1.[TipoEspectaculoId], TM1.[TipoEspectaculoNombre] FROM [TipoEspectaculo] TM1 WHERE TM1.[TipoEspectaculoId] = @TipoEspectaculoId ORDER BY TM1.[TipoEspectaculoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000811,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
