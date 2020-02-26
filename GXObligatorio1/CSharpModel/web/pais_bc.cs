/*
               File: Pais_BC
        Description: Pais
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:22.61
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
   public class pais_bc : GXHttpHandler, IGxSilentTrn
   {
      public pais_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public pais_bc( IGxContext context )
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
         ReadRow011( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey011( ) ;
         standaloneModal( ) ;
         AddRow011( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               Z1PaisId = A1PaisId;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode1 = Gx_mode;
            CONFIRM_012( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode1;
               IsConfirmed = 1;
            }
            /* Restore parent mode. */
            Gx_mode = sMode1;
         }
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_2_idx = 0;
         while ( nGXsfl_2_idx < bcPais.gxTpr_Ciudad.Count )
         {
            ReadRow012( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound2 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ! IsIns( ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( IsIns( ) && ! IsDlt( ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        if ( AnyError == 0 )
                        {
                        }
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1;
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( IsDlt( ) )
                     {
                        Gx_mode = "DLT";
                        getByPrimaryKey012( ) ;
                        Load012( ) ;
                        BeforeValidate012( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls012( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              if ( AnyError == 0 )
                              {
                              }
                              CloseExtendedTableCursors012( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( ! IsDlt( ) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
               VarsToRow2( ((SdtPais_Ciudad)bcPais.gxTpr_Ciudad.Item(nGXsfl_2_idx))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void E12012( )
      {
         /* Start Routine */
      }

      protected void E11012( )
      {
         /* After Trn Routine */
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z2PaisNombre = A2PaisNombre;
         }
         if ( GX_JID == -3 )
         {
            Z1PaisId = A1PaisId;
            Z2PaisNombre = A2PaisNombre;
            Z3PaisBandera = A3PaisBandera;
            Z40000PaisBandera_GXI = A40000PaisBandera_GXI;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
      }

      protected void standaloneModal( )
      {
         if ( IsIns( )  && (0==A1PaisId) && ( Gx_BScreen == 0 ) )
         {
            A1PaisId = 1;
         }
      }

      protected void Load011( )
      {
         /* Using cursor BC00016 */
         pr_default.execute(4, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1;
            A2PaisNombre = BC00016_A2PaisNombre[0];
            A40000PaisBandera_GXI = BC00016_A40000PaisBandera_GXI[0];
            A3PaisBandera = BC00016_A3PaisBandera[0];
            ZM011( -3) ;
         }
         pr_default.close(4);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         nIsDirty_1 = 0;
         standaloneModal( ) ;
         /* Using cursor BC00017 */
         pr_default.execute(5, new Object[] {A2PaisNombre, A1PaisId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Pais Nombre"}), 1, "");
            AnyError = 1;
         }
         pr_default.close(5);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2PaisNombre)) )
         {
            GX_msglist.addItem("Ingresa el nombre del país", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor BC00018 */
         pr_default.execute(6, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00015 */
         pr_default.execute(3, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM011( 3) ;
            RcdFound1 = 1;
            A1PaisId = BC00015_A1PaisId[0];
            A2PaisNombre = BC00015_A2PaisNombre[0];
            A40000PaisBandera_GXI = BC00015_A40000PaisBandera_GXI[0];
            A3PaisBandera = BC00015_A3PaisBandera[0];
            Z1PaisId = A1PaisId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode1;
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
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
         CONFIRM_010( ) ;
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

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor BC00014 */
            pr_default.execute(2, new Object[] {A1PaisId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pais"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z2PaisNombre, BC00014_A2PaisNombre[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Pais"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00019 */
                     pr_default.execute(7, new Object[] {A2PaisNombre, A3PaisBandera, A40000PaisBandera_GXI});
                     A1PaisId = BC00019_A1PaisId[0];
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           }
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000110 */
                     pr_default.execute(8, new Object[] {A2PaisNombre, A1PaisId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pais"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
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
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC000111 */
            pr_default.execute(9, new Object[] {A3PaisBandera, A40000PaisBandera_GXI, A1PaisId});
            pr_default.close(9);
            dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  ScanKeyStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanKeyNext012( ) ;
                  }
                  ScanKeyEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000112 */
                     pr_default.execute(10, new Object[] {A1PaisId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
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
         }
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel011( ) ;
         Gx_mode = sMode1;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000113 */
            pr_default.execute(11, new Object[] {A1PaisId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Lugar"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_2_idx = 0;
         while ( nGXsfl_2_idx < bcPais.gxTpr_Ciudad.Count )
         {
            ReadRow012( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound2 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ! IsIns( ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               if ( IsIns( ) )
               {
                  Gx_mode = "INS";
                  Insert012( ) ;
               }
               else
               {
                  if ( IsDlt( ) )
                  {
                     Gx_mode = "DLT";
                     Delete012( ) ;
                  }
                  else
                  {
                     Gx_mode = "UPD";
                     Update012( ) ;
                  }
               }
            }
            KeyVarsToRow2( ((SdtPais_Ciudad)bcPais.gxTpr_Ciudad.Item(nGXsfl_2_idx))) ;
         }
         if ( AnyError == 0 )
         {
            /* Batch update SDT rows */
            nGXsfl_2_idx = 0;
            while ( nGXsfl_2_idx < bcPais.gxTpr_Ciudad.Count )
            {
               ReadRow012( ) ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                  }
                  else
                  {
                     Gx_mode = "UPD";
                  }
               }
               /* Update SDT row */
               if ( IsDlt( ) )
               {
                  bcPais.gxTpr_Ciudad.RemoveElement(nGXsfl_2_idx);
                  nGXsfl_2_idx = (int)(nGXsfl_2_idx-1);
               }
               else
               {
                  Gx_mode = "UPD";
                  getByPrimaryKey012( ) ;
                  VarsToRow2( ((SdtPais_Ciudad)bcPais.gxTpr_Ciudad.Item(nGXsfl_2_idx))) ;
               }
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll012( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         Gxremove2 = 0;
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode;
         ProcessNestedLevel012( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode1;
         /* ' Update level parameters */
      }

      protected void EndLevel011( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
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

      public void ScanKeyStart011( )
      {
         /* Scan By routine */
         /* Using cursor BC000114 */
         pr_default.execute(12, new Object[] {A1PaisId});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound1 = 1;
            A1PaisId = BC000114_A1PaisId[0];
            A2PaisNombre = BC000114_A2PaisNombre[0];
            A40000PaisBandera_GXI = BC000114_A40000PaisBandera_GXI[0];
            A3PaisBandera = BC000114_A3PaisBandera[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound1 = 0;
         ScanKeyLoad011( ) ;
      }

      protected void ScanKeyLoad011( )
      {
         sMode1 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound1 = 1;
            A1PaisId = BC000114_A1PaisId[0];
            A2PaisNombre = BC000114_A2PaisNombre[0];
            A40000PaisBandera_GXI = BC000114_A40000PaisBandera_GXI[0];
            A3PaisBandera = BC000114_A3PaisBandera[0];
         }
         Gx_mode = sMode1;
      }

      protected void ScanKeyEnd011( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            Z5CiudadNombre = A5CiudadNombre;
         }
         if ( GX_JID == -5 )
         {
            Z1PaisId = A1PaisId;
            Z4CiudadId = A4CiudadId;
            Z5CiudadNombre = A5CiudadNombre;
         }
      }

      protected void standaloneNotModal012( )
      {
      }

      protected void standaloneModal012( )
      {
      }

      protected void Load012( )
      {
         /* Using cursor BC000115 */
         pr_default.execute(13, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound2 = 1;
            A5CiudadNombre = BC000115_A5CiudadNombre[0];
            ZM012( -5) ;
         }
         pr_default.close(13);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         standaloneModal012( ) ;
         Gx_BScreen = 0;
      }

      protected void CloseExtendedTableCursors012( )
      {
      }

      protected void enableDisable012( )
      {
      }

      protected void GetKey012( )
      {
         /* Using cursor BC000116 */
         pr_default.execute(14, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(14);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor BC00013 */
         pr_default.execute(1, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM012( 5) ;
            RcdFound2 = 1;
            InitializeNonKey012( ) ;
            A4CiudadId = BC00013_A4CiudadId[0];
            A5CiudadNombre = BC00013_A5CiudadNombre[0];
            Z1PaisId = A1PaisId;
            Z4CiudadId = A4CiudadId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal012( ) ;
            Load012( ) ;
            Gx_mode = sMode2;
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal012( ) ;
            Gx_mode = sMode2;
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes012( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency012( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor BC00012 */
            pr_default.execute(0, new Object[] {A1PaisId, A4CiudadId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PaisCiudad"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z5CiudadNombre, BC00012_A5CiudadNombre[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PaisCiudad"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM012( 0) ;
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000117 */
                     pr_default.execute(15, new Object[] {A1PaisId, A4CiudadId, A5CiudadNombre});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("PaisCiudad") ;
                     if ( (pr_default.getStatus(15) == 1) )
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
               Load012( ) ;
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void Update012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000118 */
                     pr_default.execute(16, new Object[] {A5CiudadNombre, A1PaisId, A4CiudadId});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("PaisCiudad") ;
                     if ( (pr_default.getStatus(16) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PaisCiudad"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate012( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey012( ) ;
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
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT";
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls012( ) ;
            AfterConfirm012( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete012( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000119 */
                  pr_default.execute(17, new Object[] {A1PaisId, A4CiudadId});
                  pr_default.close(17);
                  dsDefault.SmartCacheProvider.SetUpdated("PaisCiudad") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel012( ) ;
         Gx_mode = sMode2;
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000120 */
            pr_default.execute(18, new Object[] {A1PaisId, A4CiudadId});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Lugar"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(18);
         }
      }

      protected void EndLevel012( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart012( )
      {
         /* Scan By routine */
         /* Using cursor BC000121 */
         pr_default.execute(19, new Object[] {A1PaisId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A4CiudadId = BC000121_A4CiudadId[0];
            A5CiudadNombre = BC000121_A5CiudadNombre[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext012( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound2 = 0;
         ScanKeyLoad012( ) ;
      }

      protected void ScanKeyLoad012( )
      {
         sMode2 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound2 = 1;
            A4CiudadId = BC000121_A4CiudadId[0];
            A5CiudadNombre = BC000121_A5CiudadNombre[0];
         }
         Gx_mode = sMode2;
      }

      protected void ScanKeyEnd012( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm012( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert012( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate012( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete012( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete012( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate012( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes012( )
      {
      }

      protected void send_integrity_lvl_hashes012( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void AddRow011( )
      {
         VarsToRow1( bcPais) ;
      }

      protected void ReadRow011( )
      {
         RowToVars1( bcPais, 1) ;
      }

      protected void AddRow012( )
      {
         SdtPais_Ciudad obj2 ;
         obj2 = new SdtPais_Ciudad(context);
         VarsToRow2( obj2) ;
         bcPais.gxTpr_Ciudad.Add(obj2, 0);
         obj2.gxTpr_Mode = "UPD";
         obj2.gxTpr_Modified = 0;
      }

      protected void ReadRow012( )
      {
         nGXsfl_2_idx = (int)(nGXsfl_2_idx+1);
         RowToVars2( ((SdtPais_Ciudad)bcPais.gxTpr_Ciudad.Item(nGXsfl_2_idx)), 1) ;
      }

      protected void InitializeNonKey011( )
      {
         A2PaisNombre = "";
         A3PaisBandera = "";
         A40000PaisBandera_GXI = "";
         Z2PaisNombre = "";
      }

      protected void InitAll011( )
      {
         A1PaisId = 1;
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey012( )
      {
         A5CiudadNombre = "";
         Z5CiudadNombre = "";
      }

      protected void InitAll012( )
      {
         A4CiudadId = 0;
         InitializeNonKey012( ) ;
      }

      protected void StandaloneModalInsert012( )
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

      public void VarsToRow1( SdtPais obj1 )
      {
         obj1.gxTpr_Mode = Gx_mode;
         obj1.gxTpr_Paisnombre = A2PaisNombre;
         obj1.gxTpr_Paisbandera = A3PaisBandera;
         obj1.gxTpr_Paisbandera_gxi = A40000PaisBandera_GXI;
         obj1.gxTpr_Paisid = A1PaisId;
         obj1.gxTpr_Paisid_Z = Z1PaisId;
         obj1.gxTpr_Paisnombre_Z = Z2PaisNombre;
         obj1.gxTpr_Paisbandera_gxi_Z = Z40000PaisBandera_GXI;
         obj1.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow1( SdtPais obj1 )
      {
         obj1.gxTpr_Paisid = A1PaisId;
         return  ;
      }

      public void RowToVars1( SdtPais obj1 ,
                              int forceLoad )
      {
         Gx_mode = obj1.gxTpr_Mode;
         A2PaisNombre = obj1.gxTpr_Paisnombre;
         A3PaisBandera = obj1.gxTpr_Paisbandera;
         A40000PaisBandera_GXI = obj1.gxTpr_Paisbandera_gxi;
         A1PaisId = obj1.gxTpr_Paisid;
         Z1PaisId = obj1.gxTpr_Paisid_Z;
         Z2PaisNombre = obj1.gxTpr_Paisnombre_Z;
         Z40000PaisBandera_GXI = obj1.gxTpr_Paisbandera_gxi_Z;
         Gx_mode = obj1.gxTpr_Mode;
         return  ;
      }

      public void VarsToRow2( SdtPais_Ciudad obj2 )
      {
         obj2.gxTpr_Mode = Gx_mode;
         obj2.gxTpr_Ciudadnombre = A5CiudadNombre;
         obj2.gxTpr_Ciudadid = A4CiudadId;
         obj2.gxTpr_Ciudadid_Z = Z4CiudadId;
         obj2.gxTpr_Ciudadnombre_Z = Z5CiudadNombre;
         obj2.gxTpr_Modified = nIsMod_2;
         return  ;
      }

      public void KeyVarsToRow2( SdtPais_Ciudad obj2 )
      {
         obj2.gxTpr_Ciudadid = A4CiudadId;
         return  ;
      }

      public void RowToVars2( SdtPais_Ciudad obj2 ,
                              int forceLoad )
      {
         Gx_mode = obj2.gxTpr_Mode;
         A5CiudadNombre = obj2.gxTpr_Ciudadnombre;
         A4CiudadId = obj2.gxTpr_Ciudadid;
         Z4CiudadId = obj2.gxTpr_Ciudadid_Z;
         Z5CiudadNombre = obj2.gxTpr_Ciudadnombre_Z;
         nIsMod_2 = obj2.gxTpr_Modified;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1PaisId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey011( ) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1PaisId = A1PaisId;
         }
         ZM011( -3) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         bcPais.gxTpr_Ciudad.ClearCollection();
         if ( RcdFound1 == 1 )
         {
            ScanKeyStart012( ) ;
            nGXsfl_2_idx = 1;
            while ( RcdFound2 != 0 )
            {
               Z1PaisId = A1PaisId;
               Z4CiudadId = A4CiudadId;
               ZM012( -5) ;
               OnLoadActions012( ) ;
               nRcdExists_2 = 1;
               nIsMod_2 = 0;
               AddRow012( ) ;
               nGXsfl_2_idx = (int)(nGXsfl_2_idx+1);
               ScanKeyNext012( ) ;
            }
            ScanKeyEnd012( ) ;
         }
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
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
         RowToVars1( bcPais, 0) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1PaisId = A1PaisId;
         }
         ZM011( -3) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         bcPais.gxTpr_Ciudad.ClearCollection();
         if ( RcdFound1 == 1 )
         {
            ScanKeyStart012( ) ;
            nGXsfl_2_idx = 1;
            while ( RcdFound2 != 0 )
            {
               Z1PaisId = A1PaisId;
               Z4CiudadId = A4CiudadId;
               ZM012( -5) ;
               OnLoadActions012( ) ;
               nRcdExists_2 = 1;
               nIsMod_2 = 0;
               AddRow012( ) ;
               nGXsfl_2_idx = (int)(nGXsfl_2_idx+1);
               ScanKeyNext012( ) ;
            }
            ScanKeyEnd012( ) ;
         }
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            Insert011( ) ;
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1PaisId != Z1PaisId )
               {
                  A1PaisId = Z1PaisId;
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
                  Update011( ) ;
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
                  if ( A1PaisId != Z1PaisId )
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
                        Insert011( ) ;
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
                        Insert011( ) ;
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
         RowToVars1( bcPais, 0) ;
         SaveImpl( ) ;
         VarsToRow1( bcPais) ;
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
         RowToVars1( bcPais, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
         AfterTrn( ) ;
         VarsToRow1( bcPais) ;
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
            SdtPais auxBC = new SdtPais(context) ;
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            auxBC.Load(A1PaisId);
            if ( auxTrn.Errors() == 0 )
            {
               auxBC.UpdateDirties(bcPais);
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
         RowToVars1( bcPais, 0) ;
         UpdateImpl( ) ;
         VarsToRow1( bcPais) ;
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
         RowToVars1( bcPais, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
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
         VarsToRow1( bcPais) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars1( bcPais, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( IsIns( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A1PaisId != Z1PaisId )
            {
               A1PaisId = Z1PaisId;
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
            if ( A1PaisId != Z1PaisId )
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
         pr_default.close(3);
         pr_default.close(1);
         context.RollbackDataStores("pais_bc",pr_default);
         VarsToRow1( bcPais) ;
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
         Gx_mode = bcPais.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcPais.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcPais )
         {
            bcPais = (SdtPais)(sdt);
            if ( StringUtil.StrCmp(bcPais.gxTpr_Mode, "") == 0 )
            {
               bcPais.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow1( bcPais) ;
            }
            else
            {
               RowToVars1( bcPais, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcPais.gxTpr_Mode, "") == 0 )
            {
               bcPais.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars1( bcPais, 1) ;
         return  ;
      }

      public void ForceCommitOnExit( )
      {
         mustCommit = true;
         return  ;
      }

      public SdtPais Pais_BC
      {
         get {
            return bcPais ;
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
         pr_default.close(3);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         sMode1 = "";
         Z2PaisNombre = "";
         A2PaisNombre = "";
         Z3PaisBandera = "";
         A3PaisBandera = "";
         Z40000PaisBandera_GXI = "";
         A40000PaisBandera_GXI = "";
         BC00016_A1PaisId = new short[1] ;
         BC00016_A2PaisNombre = new String[] {""} ;
         BC00016_A40000PaisBandera_GXI = new String[] {""} ;
         BC00016_A3PaisBandera = new String[] {""} ;
         BC00017_A2PaisNombre = new String[] {""} ;
         BC00018_A1PaisId = new short[1] ;
         BC00015_A1PaisId = new short[1] ;
         BC00015_A2PaisNombre = new String[] {""} ;
         BC00015_A40000PaisBandera_GXI = new String[] {""} ;
         BC00015_A3PaisBandera = new String[] {""} ;
         BC00014_A1PaisId = new short[1] ;
         BC00014_A2PaisNombre = new String[] {""} ;
         BC00014_A40000PaisBandera_GXI = new String[] {""} ;
         BC00014_A3PaisBandera = new String[] {""} ;
         BC00019_A1PaisId = new short[1] ;
         BC000113_A8LugarId = new short[1] ;
         BC000114_A1PaisId = new short[1] ;
         BC000114_A2PaisNombre = new String[] {""} ;
         BC000114_A40000PaisBandera_GXI = new String[] {""} ;
         BC000114_A3PaisBandera = new String[] {""} ;
         Z5CiudadNombre = "";
         A5CiudadNombre = "";
         BC000115_A1PaisId = new short[1] ;
         BC000115_A4CiudadId = new short[1] ;
         BC000115_A5CiudadNombre = new String[] {""} ;
         BC000116_A1PaisId = new short[1] ;
         BC000116_A4CiudadId = new short[1] ;
         BC00013_A1PaisId = new short[1] ;
         BC00013_A4CiudadId = new short[1] ;
         BC00013_A5CiudadNombre = new String[] {""} ;
         sMode2 = "";
         BC00012_A1PaisId = new short[1] ;
         BC00012_A4CiudadId = new short[1] ;
         BC00012_A5CiudadNombre = new String[] {""} ;
         BC000120_A8LugarId = new short[1] ;
         BC000121_A1PaisId = new short[1] ;
         BC000121_A4CiudadId = new short[1] ;
         BC000121_A5CiudadNombre = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pais_bc__default(),
            new Object[][] {
                new Object[] {
               BC00012_A1PaisId, BC00012_A4CiudadId, BC00012_A5CiudadNombre
               }
               , new Object[] {
               BC00013_A1PaisId, BC00013_A4CiudadId, BC00013_A5CiudadNombre
               }
               , new Object[] {
               BC00014_A1PaisId, BC00014_A2PaisNombre, BC00014_A40000PaisBandera_GXI, BC00014_A3PaisBandera
               }
               , new Object[] {
               BC00015_A1PaisId, BC00015_A2PaisNombre, BC00015_A40000PaisBandera_GXI, BC00015_A3PaisBandera
               }
               , new Object[] {
               BC00016_A1PaisId, BC00016_A2PaisNombre, BC00016_A40000PaisBandera_GXI, BC00016_A3PaisBandera
               }
               , new Object[] {
               BC00017_A2PaisNombre
               }
               , new Object[] {
               BC00018_A1PaisId
               }
               , new Object[] {
               BC00019_A1PaisId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000113_A8LugarId
               }
               , new Object[] {
               BC000114_A1PaisId, BC000114_A2PaisNombre, BC000114_A40000PaisBandera_GXI, BC000114_A3PaisBandera
               }
               , new Object[] {
               BC000115_A1PaisId, BC000115_A4CiudadId, BC000115_A5CiudadNombre
               }
               , new Object[] {
               BC000116_A1PaisId, BC000116_A4CiudadId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000120_A8LugarId
               }
               , new Object[] {
               BC000121_A1PaisId, BC000121_A4CiudadId, BC000121_A5CiudadNombre
               }
            }
         );
         Z1PaisId = 1;
         A1PaisId = 1;
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12012 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z1PaisId ;
      private short A1PaisId ;
      private short nIsMod_2 ;
      private short RcdFound2 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound1 ;
      private short nIsDirty_1 ;
      private short nRcdExists_2 ;
      private short Gxremove2 ;
      private short Z4CiudadId ;
      private short A4CiudadId ;
      private short nIsDirty_2 ;
      private int trnEnded ;
      private int nGXsfl_2_idx=1 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode1 ;
      private String Z2PaisNombre ;
      private String A2PaisNombre ;
      private String Z5CiudadNombre ;
      private String A5CiudadNombre ;
      private String sMode2 ;
      private bool mustCommit ;
      private String Z40000PaisBandera_GXI ;
      private String A40000PaisBandera_GXI ;
      private String Z3PaisBandera ;
      private String A3PaisBandera ;
      private SdtPais bcPais ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00016_A1PaisId ;
      private String[] BC00016_A2PaisNombre ;
      private String[] BC00016_A40000PaisBandera_GXI ;
      private String[] BC00016_A3PaisBandera ;
      private String[] BC00017_A2PaisNombre ;
      private short[] BC00018_A1PaisId ;
      private short[] BC00015_A1PaisId ;
      private String[] BC00015_A2PaisNombre ;
      private String[] BC00015_A40000PaisBandera_GXI ;
      private String[] BC00015_A3PaisBandera ;
      private short[] BC00014_A1PaisId ;
      private String[] BC00014_A2PaisNombre ;
      private String[] BC00014_A40000PaisBandera_GXI ;
      private String[] BC00014_A3PaisBandera ;
      private short[] BC00019_A1PaisId ;
      private short[] BC000113_A8LugarId ;
      private short[] BC000114_A1PaisId ;
      private String[] BC000114_A2PaisNombre ;
      private String[] BC000114_A40000PaisBandera_GXI ;
      private String[] BC000114_A3PaisBandera ;
      private short[] BC000115_A1PaisId ;
      private short[] BC000115_A4CiudadId ;
      private String[] BC000115_A5CiudadNombre ;
      private short[] BC000116_A1PaisId ;
      private short[] BC000116_A4CiudadId ;
      private short[] BC00013_A1PaisId ;
      private short[] BC00013_A4CiudadId ;
      private String[] BC00013_A5CiudadNombre ;
      private short[] BC00012_A1PaisId ;
      private short[] BC00012_A4CiudadId ;
      private String[] BC00012_A5CiudadNombre ;
      private short[] BC000120_A8LugarId ;
      private short[] BC000121_A1PaisId ;
      private short[] BC000121_A4CiudadId ;
      private String[] BC000121_A5CiudadNombre ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class pais_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00016 ;
          prmBC00016 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00017 ;
          prmBC00017 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00018 ;
          prmBC00018 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00015 ;
          prmBC00015 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00014 ;
          prmBC00014 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00019 ;
          prmBC00019 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisBandera",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@PaisBandera_GXI",SqlDbType.NVarChar,2048,0}
          } ;
          Object[] prmBC000110 ;
          prmBC000110 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000111 ;
          prmBC000111 = new Object[] {
          new Object[] {"@PaisBandera",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@PaisBandera_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000112 ;
          prmBC000112 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000113 ;
          prmBC000113 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000114 ;
          prmBC000114 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000115 ;
          prmBC000115 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000116 ;
          prmBC000116 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00013 ;
          prmBC00013 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00012 ;
          prmBC00012 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000117 ;
          prmBC000117 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadNombre",SqlDbType.NChar,100,0}
          } ;
          Object[] prmBC000118 ;
          prmBC000118 = new Object[] {
          new Object[] {"@CiudadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000119 ;
          prmBC000119 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000120 ;
          prmBC000120 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000121 ;
          prmBC000121 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00012", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WITH (UPDLOCK) WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00012,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00013", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00013,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00014", "SELECT [PaisId], [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WITH (UPDLOCK) WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00014,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00015", "SELECT [PaisId], [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00015,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00016", "SELECT TM1.[PaisId], TM1.[PaisNombre], TM1.[PaisBandera_GXI], TM1.[PaisBandera] FROM [Pais] TM1 WHERE TM1.[PaisId] = @PaisId ORDER BY TM1.[PaisId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00016,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00017", "SELECT [PaisNombre] FROM [Pais] WHERE ([PaisNombre] = @PaisNombre) AND (Not ( [PaisId] = @PaisId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00017,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00018", "SELECT [PaisId] FROM [Pais] WHERE [PaisId] = @PaisId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00018,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC00019", "INSERT INTO [Pais]([PaisNombre], [PaisBandera], [PaisBandera_GXI]) VALUES(@PaisNombre, @PaisBandera, @PaisBandera_GXI); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00019)
             ,new CursorDef("BC000110", "UPDATE [Pais] SET [PaisNombre]=@PaisNombre  WHERE [PaisId] = @PaisId", GxErrorMask.GX_NOMASK,prmBC000110)
             ,new CursorDef("BC000111", "UPDATE [Pais] SET [PaisBandera]=@PaisBandera, [PaisBandera_GXI]=@PaisBandera_GXI  WHERE [PaisId] = @PaisId", GxErrorMask.GX_NOMASK,prmBC000111)
             ,new CursorDef("BC000112", "DELETE FROM [Pais]  WHERE [PaisId] = @PaisId", GxErrorMask.GX_NOMASK,prmBC000112)
             ,new CursorDef("BC000113", "SELECT TOP 1 [LugarId] FROM [Lugar] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000113,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("BC000114", "SELECT TM1.[PaisId], TM1.[PaisNombre], TM1.[PaisBandera_GXI], TM1.[PaisBandera] FROM [Pais] TM1 WHERE TM1.[PaisId] = @PaisId ORDER BY TM1.[PaisId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000114,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000115", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId and [CiudadId] = @CiudadId ORDER BY [PaisId], [CiudadId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000115,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000116", "SELECT [PaisId], [CiudadId] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000116,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("BC000117", "INSERT INTO [PaisCiudad]([PaisId], [CiudadId], [CiudadNombre]) VALUES(@PaisId, @CiudadId, @CiudadNombre)", GxErrorMask.GX_NOMASK,prmBC000117)
             ,new CursorDef("BC000118", "UPDATE [PaisCiudad] SET [CiudadNombre]=@CiudadNombre  WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId", GxErrorMask.GX_NOMASK,prmBC000118)
             ,new CursorDef("BC000119", "DELETE FROM [PaisCiudad]  WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId", GxErrorMask.GX_NOMASK,prmBC000119)
             ,new CursorDef("BC000120", "SELECT TOP 1 [LugarId] FROM [Lugar] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000120,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("BC000121", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId ORDER BY [PaisId], [CiudadId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000121,11, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameterBlob(2, (String)parms[1], false);
                stmt.SetParameterMultimedia(3, (String)parms[2], (String)parms[1], "Pais", "PaisBandera");
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Pais", "PaisBandera");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
