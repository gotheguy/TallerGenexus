/*
               File: Pais
        Description: Pais
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:22.56
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
   public class pais : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridpais_ciudad") == 0 )
         {
            nRC_GXsfl_53 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_53_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_53_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridpais_ciudad_newrow( ) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7PaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7PaisId", StringUtil.LTrimStr( (decimal)(AV7PaisId), 4, 0));
               AssignAttri("", false, "gxhash_vPAISID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PaisId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Pais", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPaisNombre_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public pais( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public pais( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_PaisId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7PaisId = aP1_PaisId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Pais", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         ClassString = "ErrorViewer";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "BtnFirst";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtPaisId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PaisId), 4, 0, ".", "")), ((edtPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1PaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A1PaisId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPaisNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtPaisNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtPaisNombre_Internalname, StringUtil.RTrim( A2PaisNombre), StringUtil.RTrim( context.localUtil.Format( A2PaisNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPaisNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgPaisBandera_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Bandera", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         A3PaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000PaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.PathToRelativeUrl( A3PaisBandera));
         GxWebStd.gx_bitmap( context, imgPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgPaisBandera_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "", "", "", 0, A3PaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Pais.htm");
         AssignProp("", false, imgPaisBandera_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.PathToRelativeUrl( A3PaisBandera)), true);
         AssignProp("", false, imgPaisBandera_Internalname, "IsBlob", StringUtil.BoolToStr( A3PaisBandera_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divCiudadtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitleciudad_Internalname, "Ciudad", "", "", lblTitleciudad_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridpais_ciudad( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pais.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridpais_ciudad( )
      {
         /*  Grid Control  */
         Gridpais_ciudadContainer.AddObjectProperty("GridName", "Gridpais_ciudad");
         Gridpais_ciudadContainer.AddObjectProperty("Header", subGridpais_ciudad_Header);
         Gridpais_ciudadContainer.AddObjectProperty("Class", "Grid");
         Gridpais_ciudadContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Backcolorstyle), 1, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("CmpContext", "");
         Gridpais_ciudadContainer.AddObjectProperty("InMasterPage", "false");
         Gridpais_ciudadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpais_ciudadColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CiudadId), 4, 0, ".", "")));
         Gridpais_ciudadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadId_Enabled), 5, 0, ".", "")));
         Gridpais_ciudadContainer.AddColumnProperties(Gridpais_ciudadColumn);
         Gridpais_ciudadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridpais_ciudadColumn.AddObjectProperty("Value", StringUtil.RTrim( A5CiudadNombre));
         Gridpais_ciudadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadNombre_Enabled), 5, 0, ".", "")));
         Gridpais_ciudadContainer.AddColumnProperties(Gridpais_ciudadColumn);
         Gridpais_ciudadContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Selectedindex), 4, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Allowselection), 1, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Selectioncolor), 9, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Allowhovering), 1, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Hoveringcolor), 9, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Allowcollapsing), 1, 0, ".", "")));
         Gridpais_ciudadContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridpais_ciudad_Collapsed), 1, 0, ".", "")));
         nGXsfl_53_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount2 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_2 = 1;
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  init_level_properties2( ) ;
                  getByPrimaryKey012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
               nBlankRcdCount2 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            sMode2 = Gx_mode;
            while ( nGXsfl_53_idx < nRC_GXsfl_53 )
            {
               bGXsfl_53_Refreshing = true;
               ReadRow012( ) ;
               edtCiudadId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CIUDADID_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               edtCiudadNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "CIUDADNOMBRE_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadNombre_Enabled), 5, 0), !bGXsfl_53_Refreshing);
               if ( ( nRcdExists_2 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal012( ) ;
               }
               SendRow012( ) ;
               bGXsfl_53_Refreshing = false;
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount2 = 5;
            nRcdExists_2 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_532( ) ;
                  init_level_properties2( ) ;
                  standaloneNotModal012( ) ;
                  getByPrimaryKey012( ) ;
                  standaloneModal012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ! IsDsp( ) && ! IsDlt( ) )
         {
            sMode2 = Gx_mode;
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx+1), 4, 0), 4, "0");
            SubsflControlProps_532( ) ;
            InitAll012( ) ;
            init_level_properties2( ) ;
            nRcdExists_2 = 0;
            nIsMod_2 = 0;
            nRcdDeleted_2 = 0;
            nBlankRcdCount2 = (short)(nBlankRcdUsr2+nBlankRcdCount2);
            fRowAdded = 0;
            while ( nBlankRcdCount2 > 0 )
            {
               standaloneNotModal012( ) ;
               standaloneModal012( ) ;
               AddRow012( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtCiudadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount2 = (short)(nBlankRcdCount2-1);
            }
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridpais_ciudadContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridpais_ciudad", Gridpais_ciudadContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridpais_ciudadContainerData", Gridpais_ciudadContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridpais_ciudadContainerData"+"V", Gridpais_ciudadContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridpais_ciudadContainerData"+"V"+"\" value='"+Gridpais_ciudadContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z1PaisId = (short)(context.localUtil.CToN( cgiGet( "Z1PaisId"), ".", ","));
               Z2PaisNombre = cgiGet( "Z2PaisNombre");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_53 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_53"), ".", ","));
               AV7PaisId = (short)(context.localUtil.CToN( cgiGet( "vPAISID"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               A40000PaisBandera_GXI = cgiGet( "PAISBANDERA_GXI");
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               A1PaisId = (short)(context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ".", ","));
               AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
               A2PaisNombre = cgiGet( edtPaisNombre_Internalname);
               AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
               A3PaisBandera = cgiGet( imgPaisBandera_Internalname);
               AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgPaisBandera_Internalname, ref  A3PaisBandera, ref  A40000PaisBandera_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Pais");
               A1PaisId = (short)(context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ".", ","));
               AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
               forbiddenHiddens.Add("PaisId", context.localUtil.Format( (decimal)(A1PaisId), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1PaisId != Z1PaisId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("pais:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A1PaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV7PaisId) )
                  {
                     A1PaisId = AV7PaisId;
                     AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                  }
                  else
                  {
                     if ( IsIns( )  && (0==A1PaisId) && ( Gx_BScreen == 0 ) )
                     {
                        A1PaisId = 1;
                        AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                     }
                  }
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( IsDsp( ) )
                  {
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV7PaisId) )
                     {
                        A1PaisId = AV7PaisId;
                        AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                     }
                     else
                     {
                        if ( IsIns( )  && (0==A1PaisId) && ( Gx_BScreen == 0 ) )
                        {
                           A1PaisId = 1;
                           AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                        }
                     }
                     Gx_mode = sMode1;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PAISID");
                        AnyError = 1;
                        GX_FocusControl = edtPaisId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! IsDsp( ) )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "AFTER TRN") == 0 ) )
                        {
                           nGXsfl_53_idx = (int)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
                           SubsflControlProps_532( ) ;
                           if ( ( ( context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
                           {
                              GXCCtl = "CIUDADID_" + sGXsfl_53_idx;
                              GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
                              AnyError = 1;
                              GX_FocusControl = edtCiudadId_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                              wbErr = true;
                              A4CiudadId = 0;
                           }
                           else
                           {
                              A4CiudadId = (short)(context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ","));
                           }
                           A5CiudadNombre = cgiGet( edtCiudadNombre_Internalname);
                           GXCCtl = "Z4CiudadId_" + sGXsfl_53_idx;
                           Z4CiudadId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           GXCCtl = "Z5CiudadNombre_" + sGXsfl_53_idx;
                           Z5CiudadNombre = cgiGet( GXCCtl);
                           GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
                           nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
                           nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
                           nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E11012 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: After Trn */
                                 E12012 ();
                              }
                           }
                           else
                           {
                           }
                        }
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
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

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         if ( IsDsp( ) || IsDlt( ) )
         {
            bttBtn_delete_Visible = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
            if ( IsDsp( ) )
            {
               bttBtn_enter_Visible = 0;
               AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
            }
            DisableAttributes011( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
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
               AssignAttri("", false, "Gx_mode", Gx_mode);
               AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
            }
            /* Restore parent mode. */
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "CIUDADID_" + sGXsfl_53_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtCiudadId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( nRcdDeleted_2 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              CloseExtendedTableCursors012( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "CIUDADID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtCiudadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CiudadId), 4, 0, ".", ""))) ;
            ChangePostValue( edtCiudadNombre_Internalname, StringUtil.RTrim( A5CiudadNombre)) ;
            ChangePostValue( "ZT_"+"Z4CiudadId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4CiudadId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z5CiudadNombre_"+sGXsfl_53_idx, StringUtil.RTrim( Z5CiudadNombre)) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "CIUDADID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CIUDADNOMBRE_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "GXObligatorio1");
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwpais.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         pr_default.close(1);
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z2PaisNombre = T00015_A2PaisNombre[0];
            }
            else
            {
               Z2PaisNombre = A2PaisNombre;
            }
         }
         if ( GX_JID == -4 )
         {
            Z1PaisId = A1PaisId;
            Z2PaisNombre = A2PaisNombre;
            Z3PaisBandera = A3PaisBandera;
            Z40000PaisBandera_GXI = A40000PaisBandera_GXI;
         }
      }

      protected void standaloneNotModal( )
      {
         edtPaisId_Enabled = 0;
         AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         edtPaisId_Enabled = 0;
         AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         if ( ! (0==AV7PaisId) )
         {
            A1PaisId = AV7PaisId;
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
         }
         else
         {
            if ( IsIns( )  && (0==A1PaisId) && ( Gx_BScreen == 0 ) )
            {
               A1PaisId = 1;
               AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            }
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1;
            A2PaisNombre = T00016_A2PaisNombre[0];
            AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
            A40000PaisBandera_GXI = T00016_A40000PaisBandera_GXI[0];
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            A3PaisBandera = T00016_A3PaisBandera[0];
            AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            ZM011( -4) ;
         }
         pr_default.close(4);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
         AV13Pgmname = "Pais";
         AssignAttri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable011( )
      {
         nIsDirty_1 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV13Pgmname = "Pais";
         AssignAttri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A2PaisNombre, A1PaisId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Pais Nombre"}), 1, "PAISNOMBRE");
            AnyError = 1;
            GX_FocusControl = edtPaisNombre_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(5);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2PaisNombre)) )
         {
            GX_msglist.addItem("Ingresa el nombre del país", 1, "PAISNOMBRE");
            AnyError = 1;
            GX_FocusControl = edtPaisNombre_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
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
         /* Using cursor T00018 */
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
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM011( 4) ;
            RcdFound1 = 1;
            A1PaisId = T00015_A1PaisId[0];
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            A2PaisNombre = T00015_A2PaisNombre[0];
            AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
            A40000PaisBandera_GXI = T00015_A40000PaisBandera_GXI[0];
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            A3PaisBandera = T00015_A3PaisBandera[0];
            AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            Z1PaisId = A1PaisId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode1;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1PaisId[0] < A1PaisId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1PaisId[0] > A1PaisId ) ) )
            {
               A1PaisId = T00019_A1PaisId[0];
               AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1PaisId[0] > A1PaisId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1PaisId[0] < A1PaisId ) ) )
            {
               A1PaisId = T000110_A1PaisId[0];
               AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
               RcdFound1 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtPaisNombre_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1PaisId != Z1PaisId )
               {
                  A1PaisId = Z1PaisId;
                  AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PAISID");
                  AnyError = 1;
                  GX_FocusControl = edtPaisId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPaisNombre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtPaisNombre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1PaisId != Z1PaisId )
               {
                  /* Insert record */
                  GX_FocusControl = edtPaisNombre_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PAISID");
                     AnyError = 1;
                     GX_FocusControl = edtPaisId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtPaisNombre_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( IsIns( ) || IsUpd( ) || IsDlt( ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A1PaisId != Z1PaisId )
         {
            A1PaisId = Z1PaisId;
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPaisNombre_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A1PaisId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pais"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z2PaisNombre, T00014_A2PaisNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z2PaisNombre, T00014_A2PaisNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("pais:[seudo value changed for attri]"+"PaisNombre");
                  GXUtil.WriteLogRaw("Old: ",Z2PaisNombre);
                  GXUtil.WriteLogRaw("Current: ",T00014_A2PaisNombre[0]);
               }
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
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A2PaisNombre, A3PaisBandera, A40000PaisBandera_GXI});
                     A1PaisId = T000111_A1PaisId[0];
                     AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
                     pr_default.close(9);
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
                              if ( IsIns( ) || IsUpd( ) || IsDlt( ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1;
                                 }
                              }
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
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {A2PaisNombre, A1PaisId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
                     if ( (pr_default.getStatus(10) == 103) )
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
                              if ( IsIns( ) || IsUpd( ) || IsDlt( ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1;
                                 }
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
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000113 */
            pr_default.execute(11, new Object[] {A3PaisBandera, A40000PaisBandera_GXI, A1PaisId});
            pr_default.close(11);
            dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
         }
      }

      protected void delete( )
      {
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
                  ScanStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanNext012( ) ;
                  }
                  ScanEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000114 */
                     pr_default.execute(12, new Object[] {A1PaisId});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Pais") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( IsIns( ) || IsUpd( ) || IsDlt( ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
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
            }
         }
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel011( ) ;
         Gx_mode = sMode1;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Pais";
            AssignAttri("", false, "AV13Pgmname", AV13Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000115 */
            pr_default.execute(13, new Object[] {A1PaisId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Lugar"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert012( ) ;
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( ( nRcdDeleted_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete012( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update012( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "CIUDADID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtCiudadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CiudadId), 4, 0, ".", ""))) ;
            ChangePostValue( edtCiudadNombre_Internalname, StringUtil.RTrim( A5CiudadNombre)) ;
            ChangePostValue( "ZT_"+"Z4CiudadId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4CiudadId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z5CiudadNombre_"+sGXsfl_53_idx, StringUtil.RTrim( Z5CiudadNombre)) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "CIUDADID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CIUDADNOMBRE_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadNombre_Enabled), 5, 0, ".", ""))) ;
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
         nRcdDeleted_2 = 0;
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
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("pais",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("pais",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000116 */
         pr_default.execute(14);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1;
            A1PaisId = T000116_A1PaisId[0];
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1;
            A1PaisId = T000116_A1PaisId[0];
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(14);
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
         edtPaisId_Enabled = 0;
         AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         edtPaisNombre_Enabled = 0;
         AssignProp("", false, edtPaisNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisNombre_Enabled), 5, 0), true);
         imgPaisBandera_Enabled = 0;
         AssignProp("", false, imgPaisBandera_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgPaisBandera_Enabled), 5, 0), true);
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z5CiudadNombre = T00013_A5CiudadNombre[0];
            }
            else
            {
               Z5CiudadNombre = A5CiudadNombre;
            }
         }
         if ( GX_JID == -6 )
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtCiudadId_Enabled = 0;
            AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         }
         else
         {
            edtCiudadId_Enabled = 1;
            AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         }
      }

      protected void Load012( )
      {
         /* Using cursor T000117 */
         pr_default.execute(15, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound2 = 1;
            A5CiudadNombre = T000117_A5CiudadNombre[0];
            ZM012( -6) ;
         }
         pr_default.close(15);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         nIsDirty_2 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal012( ) ;
      }

      protected void CloseExtendedTableCursors012( )
      {
      }

      protected void enableDisable012( )
      {
      }

      protected void GetKey012( )
      {
         /* Using cursor T000118 */
         pr_default.execute(16, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM012( 6) ;
            RcdFound2 = 1;
            InitializeNonKey012( ) ;
            A4CiudadId = T00013_A4CiudadId[0];
            A5CiudadNombre = T00013_A5CiudadNombre[0];
            Z1PaisId = A1PaisId;
            Z4CiudadId = A4CiudadId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load012( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal012( ) ;
            Gx_mode = sMode2;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1PaisId, A4CiudadId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PaisCiudad"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z5CiudadNombre, T00012_A5CiudadNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z5CiudadNombre, T00012_A5CiudadNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("pais:[seudo value changed for attri]"+"CiudadNombre");
                  GXUtil.WriteLogRaw("Old: ",Z5CiudadNombre);
                  GXUtil.WriteLogRaw("Current: ",T00012_A5CiudadNombre[0]);
               }
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
                     /* Using cursor T000119 */
                     pr_default.execute(17, new Object[] {A1PaisId, A4CiudadId, A5CiudadNombre});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("PaisCiudad") ;
                     if ( (pr_default.getStatus(17) == 1) )
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
         if ( ( nIsMod_2 != 0 ) || ( nIsDirty_2 != 0 ) )
         {
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
                        /* Using cursor T000120 */
                        pr_default.execute(18, new Object[] {A5CiudadNombre, A1PaisId, A4CiudadId});
                        pr_default.close(18);
                        dsDefault.SmartCacheProvider.SetUpdated("PaisCiudad") ;
                        if ( (pr_default.getStatus(18) == 103) )
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
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
                  /* Using cursor T000121 */
                  pr_default.execute(19, new Object[] {A1PaisId, A4CiudadId});
                  pr_default.close(19);
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
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel012( ) ;
         Gx_mode = sMode2;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000122 */
            pr_default.execute(20, new Object[] {A1PaisId, A4CiudadId});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Lugar"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(20);
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

      public void ScanStart012( )
      {
         /* Scan By routine */
         /* Using cursor T000123 */
         pr_default.execute(21, new Object[] {A1PaisId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound2 = 1;
            A4CiudadId = T000123_A4CiudadId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext012( )
      {
         /* Scan next routine */
         pr_default.readNext(21);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound2 = 1;
            A4CiudadId = T000123_A4CiudadId[0];
         }
      }

      protected void ScanEnd012( )
      {
         pr_default.close(21);
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
         edtCiudadId_Enabled = 0;
         AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
         edtCiudadNombre_Enabled = 0;
         AssignProp("", false, edtCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadNombre_Enabled), 5, 0), !bGXsfl_53_Refreshing);
      }

      protected void send_integrity_lvl_hashes012( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void SubsflControlProps_532( )
      {
         edtCiudadId_Internalname = "CIUDADID_"+sGXsfl_53_idx;
         edtCiudadNombre_Internalname = "CIUDADNOMBRE_"+sGXsfl_53_idx;
      }

      protected void SubsflControlProps_fel_532( )
      {
         edtCiudadId_Internalname = "CIUDADID_"+sGXsfl_53_fel_idx;
         edtCiudadNombre_Internalname = "CIUDADNOMBRE_"+sGXsfl_53_fel_idx;
      }

      protected void AddRow012( )
      {
         nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         SendRow012( ) ;
      }

      protected void SendRow012( )
      {
         Gridpais_ciudadRow = GXWebRow.GetNew(context);
         if ( subGridpais_ciudad_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridpais_ciudad_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridpais_ciudad_Class, "") != 0 )
            {
               subGridpais_ciudad_Linesclass = subGridpais_ciudad_Class+"Odd";
            }
         }
         else if ( subGridpais_ciudad_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridpais_ciudad_Backstyle = 0;
            subGridpais_ciudad_Backcolor = subGridpais_ciudad_Allbackcolor;
            if ( StringUtil.StrCmp(subGridpais_ciudad_Class, "") != 0 )
            {
               subGridpais_ciudad_Linesclass = subGridpais_ciudad_Class+"Uniform";
            }
         }
         else if ( subGridpais_ciudad_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridpais_ciudad_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridpais_ciudad_Class, "") != 0 )
            {
               subGridpais_ciudad_Linesclass = subGridpais_ciudad_Class+"Odd";
            }
            subGridpais_ciudad_Backcolor = (int)(0x0);
         }
         else if ( subGridpais_ciudad_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridpais_ciudad_Backstyle = 1;
            if ( ((int)((nGXsfl_53_idx) % (2))) == 0 )
            {
               subGridpais_ciudad_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridpais_ciudad_Class, "") != 0 )
               {
                  subGridpais_ciudad_Linesclass = subGridpais_ciudad_Class+"Even";
               }
            }
            else
            {
               subGridpais_ciudad_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridpais_ciudad_Class, "") != 0 )
               {
                  subGridpais_ciudad_Linesclass = subGridpais_ciudad_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridpais_ciudadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCiudadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CiudadId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A4CiudadId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,54);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCiudadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCiudadId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridpais_ciudadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCiudadNombre_Internalname,StringUtil.RTrim( A5CiudadNombre),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,55);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCiudadNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtCiudadNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridpais_ciudadRow);
         send_integrity_lvl_hashes012( ) ;
         GXCCtl = "Z4CiudadId_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4CiudadId), 4, 0, ".", "")));
         GXCCtl = "Z5CiudadNombre_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z5CiudadNombre));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", "")));
         GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_53_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vPAISID_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CIUDADID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CIUDADNOMBRE_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCiudadNombre_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridpais_ciudadContainer.AddRow(Gridpais_ciudadRow);
      }

      protected void ReadRow012( )
      {
         nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         edtCiudadId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CIUDADID_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         edtCiudadNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "CIUDADNOMBRE_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CIUDADID_" + sGXsfl_53_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtCiudadId_Internalname;
            wbErr = true;
            A4CiudadId = 0;
         }
         else
         {
            A4CiudadId = (short)(context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ","));
         }
         A5CiudadNombre = cgiGet( edtCiudadNombre_Internalname);
         GXCCtl = "Z4CiudadId_" + sGXsfl_53_idx;
         Z4CiudadId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z5CiudadNombre_" + sGXsfl_53_idx;
         Z5CiudadNombre = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
         nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
         nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
         nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtCiudadId_Enabled = edtCiudadId_Enabled;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_53_idx = 0;
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
            SubsflControlProps_532( ) ;
            ChangePostValue( "Z4CiudadId_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z4CiudadId_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z4CiudadId_"+sGXsfl_53_idx) ;
            ChangePostValue( "Z5CiudadNombre_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z5CiudadNombre_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z5CiudadNombre_"+sGXsfl_53_idx) ;
         }
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202022521452413", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("pais.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PaisId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"Pais");
         forbiddenHiddens.Add("PaisId", context.localUtil.Format( (decimal)(A1PaisId), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("pais:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1PaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z2PaisNombre", StringUtil.RTrim( Z2PaisNombre));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_53", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_53_idx), 8, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPAISID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PaisId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PAISBANDERA_GXI", A40000PaisBandera_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "PAISBANDERA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A3PaisBandera);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("pais.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PaisId) ;
      }

      public override String GetPgmname( )
      {
         return "Pais" ;
      }

      public override String GetPgmdesc( )
      {
         return "Pais" ;
      }

      protected void InitializeNonKey011( )
      {
         A2PaisNombre = "";
         AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
         A3PaisBandera = "";
         AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         A40000PaisBandera_GXI = "";
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40000PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         Z2PaisNombre = "";
      }

      protected void InitAll011( )
      {
         A1PaisId = 1;
         AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
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

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022521452424", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("pais.js", "?202022521452424", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties2( )
      {
         edtCiudadId_Enabled = defedtCiudadId_Enabled;
         AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), !bGXsfl_53_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtPaisId_Internalname = "PAISID";
         edtPaisNombre_Internalname = "PAISNOMBRE";
         imgPaisBandera_Internalname = "PAISBANDERA";
         lblTitleciudad_Internalname = "TITLECIUDAD";
         edtCiudadId_Internalname = "CIUDADID";
         edtCiudadNombre_Internalname = "CIUDADNOMBRE";
         divCiudadtable_Internalname = "CIUDADTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridpais_ciudad_Internalname = "GRIDPAIS_CIUDAD";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Pais";
         edtCiudadNombre_Jsonclick = "";
         edtCiudadId_Jsonclick = "";
         subGridpais_ciudad_Class = "Grid";
         subGridpais_ciudad_Backcolorstyle = 0;
         subGridpais_ciudad_Allowcollapsing = 0;
         subGridpais_ciudad_Allowselection = 0;
         edtCiudadNombre_Enabled = 1;
         edtCiudadId_Enabled = 1;
         subGridpais_ciudad_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgPaisBandera_Enabled = 1;
         edtPaisNombre_Jsonclick = "";
         edtPaisNombre_Enabled = 1;
         edtPaisId_Jsonclick = "";
         edtPaisId_Enabled = 0;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridpais_ciudad_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx <= nRC_GXsfl_53 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow012( ) ;
            nGXsfl_53_idx = (int)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_53_idx), 4, 0), 4, "0");
            SubsflControlProps_532( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridpais_ciudadContainer)) ;
         /* End function gxnrGridpais_ciudad_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
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

      public void Valid_Paisnombre( )
      {
         /* Using cursor T000124 */
         pr_default.execute(22, new Object[] {A2PaisNombre, A1PaisId});
         if ( (pr_default.getStatus(22) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Pais Nombre"}), 1, "PAISNOMBRE");
            AnyError = 1;
            GX_FocusControl = edtPaisNombre_Internalname;
         }
         pr_default.close(22);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2PaisNombre)) )
         {
            GX_msglist.addItem("Ingresa el nombre del país", 1, "PAISNOMBRE");
            AnyError = 1;
            GX_FocusControl = edtPaisNombre_Internalname;
         }
         dynload_actions( ) ;
         /*  Sending validation outputs */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PaisId',fld:'vPAISID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7PaisId',fld:'vPAISID',pic:'ZZZ9',hsh:true},{av:'A1PaisId',fld:'PAISID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_PAISID","{handler:'Valid_Paisid',iparms:[]");
         setEventMetadata("VALID_PAISID",",oparms:[]}");
         setEventMetadata("VALID_PAISNOMBRE","{handler:'Valid_Paisnombre',iparms:[{av:'A2PaisNombre',fld:'PAISNOMBRE',pic:''},{av:'A1PaisId',fld:'PAISID',pic:'ZZZ9'}]");
         setEventMetadata("VALID_PAISNOMBRE",",oparms:[]}");
         setEventMetadata("VALID_CIUDADID","{handler:'Valid_Ciudadid',iparms:[]");
         setEventMetadata("VALID_CIUDADID",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Ciudadnombre',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         return  ;
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
         sPrefix = "";
         wcpOGx_mode = "";
         Z2PaisNombre = "";
         Z5CiudadNombre = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A2PaisNombre = "";
         A3PaisBandera = "";
         A40000PaisBandera_GXI = "";
         sImgUrl = "";
         lblTitleciudad_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridpais_ciudadContainer = new GXWebGrid( context);
         Gridpais_ciudadColumn = new GXWebColumn();
         A5CiudadNombre = "";
         sMode2 = "";
         sStyleString = "";
         AV13Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         Z3PaisBandera = "";
         Z40000PaisBandera_GXI = "";
         T00016_A1PaisId = new short[1] ;
         T00016_A2PaisNombre = new String[] {""} ;
         T00016_A40000PaisBandera_GXI = new String[] {""} ;
         T00016_A3PaisBandera = new String[] {""} ;
         T00017_A2PaisNombre = new String[] {""} ;
         T00018_A1PaisId = new short[1] ;
         T00015_A1PaisId = new short[1] ;
         T00015_A2PaisNombre = new String[] {""} ;
         T00015_A40000PaisBandera_GXI = new String[] {""} ;
         T00015_A3PaisBandera = new String[] {""} ;
         T00019_A1PaisId = new short[1] ;
         T000110_A1PaisId = new short[1] ;
         T00014_A1PaisId = new short[1] ;
         T00014_A2PaisNombre = new String[] {""} ;
         T00014_A40000PaisBandera_GXI = new String[] {""} ;
         T00014_A3PaisBandera = new String[] {""} ;
         T000111_A1PaisId = new short[1] ;
         T000115_A8LugarId = new short[1] ;
         T000116_A1PaisId = new short[1] ;
         T000117_A1PaisId = new short[1] ;
         T000117_A4CiudadId = new short[1] ;
         T000117_A5CiudadNombre = new String[] {""} ;
         T000118_A1PaisId = new short[1] ;
         T000118_A4CiudadId = new short[1] ;
         T00013_A1PaisId = new short[1] ;
         T00013_A4CiudadId = new short[1] ;
         T00013_A5CiudadNombre = new String[] {""} ;
         T00012_A1PaisId = new short[1] ;
         T00012_A4CiudadId = new short[1] ;
         T00012_A5CiudadNombre = new String[] {""} ;
         T000122_A8LugarId = new short[1] ;
         T000123_A1PaisId = new short[1] ;
         T000123_A4CiudadId = new short[1] ;
         Gridpais_ciudadRow = new GXWebRow();
         subGridpais_ciudad_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         T000124_A2PaisNombre = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pais__default(),
            new Object[][] {
                new Object[] {
               T00012_A1PaisId, T00012_A4CiudadId, T00012_A5CiudadNombre
               }
               , new Object[] {
               T00013_A1PaisId, T00013_A4CiudadId, T00013_A5CiudadNombre
               }
               , new Object[] {
               T00014_A1PaisId, T00014_A2PaisNombre, T00014_A40000PaisBandera_GXI, T00014_A3PaisBandera
               }
               , new Object[] {
               T00015_A1PaisId, T00015_A2PaisNombre, T00015_A40000PaisBandera_GXI, T00015_A3PaisBandera
               }
               , new Object[] {
               T00016_A1PaisId, T00016_A2PaisNombre, T00016_A40000PaisBandera_GXI, T00016_A3PaisBandera
               }
               , new Object[] {
               T00017_A2PaisNombre
               }
               , new Object[] {
               T00018_A1PaisId
               }
               , new Object[] {
               T00019_A1PaisId
               }
               , new Object[] {
               T000110_A1PaisId
               }
               , new Object[] {
               T000111_A1PaisId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000115_A8LugarId
               }
               , new Object[] {
               T000116_A1PaisId
               }
               , new Object[] {
               T000117_A1PaisId, T000117_A4CiudadId, T000117_A5CiudadNombre
               }
               , new Object[] {
               T000118_A1PaisId, T000118_A4CiudadId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000122_A8LugarId
               }
               , new Object[] {
               T000123_A1PaisId, T000123_A4CiudadId
               }
               , new Object[] {
               T000124_A2PaisNombre
               }
            }
         );
         Z1PaisId = 1;
         A1PaisId = 1;
         AV13Pgmname = "Pais";
      }

      private short wcpOAV7PaisId ;
      private short Z1PaisId ;
      private short Z4CiudadId ;
      private short nRcdDeleted_2 ;
      private short nRcdExists_2 ;
      private short nIsMod_2 ;
      private short GxWebError ;
      private short AV7PaisId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A1PaisId ;
      private short subGridpais_ciudad_Backcolorstyle ;
      private short A4CiudadId ;
      private short subGridpais_ciudad_Allowselection ;
      private short subGridpais_ciudad_Allowhovering ;
      private short subGridpais_ciudad_Allowcollapsing ;
      private short subGridpais_ciudad_Collapsed ;
      private short nBlankRcdCount2 ;
      private short RcdFound2 ;
      private short nBlankRcdUsr2 ;
      private short Gx_BScreen ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short nIsDirty_1 ;
      private short nIsDirty_2 ;
      private short subGridpais_ciudad_Backstyle ;
      private short gxajaxcallmode ;
      private int nRC_GXsfl_53 ;
      private int nGXsfl_53_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtPaisId_Enabled ;
      private int edtPaisNombre_Enabled ;
      private int imgPaisBandera_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtCiudadId_Enabled ;
      private int edtCiudadNombre_Enabled ;
      private int subGridpais_ciudad_Selectedindex ;
      private int subGridpais_ciudad_Selectioncolor ;
      private int subGridpais_ciudad_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridpais_ciudad_Backcolor ;
      private int subGridpais_ciudad_Allbackcolor ;
      private int defedtCiudadId_Enabled ;
      private int idxLst ;
      private long GRIDPAIS_CIUDAD_nFirstRecordOnPage ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z2PaisNombre ;
      private String Z5CiudadNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_53_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPaisNombre_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtPaisId_Internalname ;
      private String edtPaisId_Jsonclick ;
      private String A2PaisNombre ;
      private String edtPaisNombre_Jsonclick ;
      private String imgPaisBandera_Internalname ;
      private String sImgUrl ;
      private String divCiudadtable_Internalname ;
      private String lblTitleciudad_Internalname ;
      private String lblTitleciudad_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridpais_ciudad_Header ;
      private String A5CiudadNombre ;
      private String sMode2 ;
      private String edtCiudadId_Internalname ;
      private String edtCiudadNombre_Internalname ;
      private String sStyleString ;
      private String AV13Pgmname ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sGXsfl_53_fel_idx="0001" ;
      private String subGridpais_ciudad_Class ;
      private String subGridpais_ciudad_Linesclass ;
      private String ROClassString ;
      private String edtCiudadId_Jsonclick ;
      private String edtCiudadNombre_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private String subGridpais_ciudad_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A3PaisBandera_IsBlob ;
      private bool bGXsfl_53_Refreshing=false ;
      private bool returnInSub ;
      private String A40000PaisBandera_GXI ;
      private String Z40000PaisBandera_GXI ;
      private String A3PaisBandera ;
      private String Z3PaisBandera ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private GXWebGrid Gridpais_ciudadContainer ;
      private GXWebRow Gridpais_ciudadRow ;
      private GXWebColumn Gridpais_ciudadColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00016_A1PaisId ;
      private String[] T00016_A2PaisNombre ;
      private String[] T00016_A40000PaisBandera_GXI ;
      private String[] T00016_A3PaisBandera ;
      private String[] T00017_A2PaisNombre ;
      private short[] T00018_A1PaisId ;
      private short[] T00015_A1PaisId ;
      private String[] T00015_A2PaisNombre ;
      private String[] T00015_A40000PaisBandera_GXI ;
      private String[] T00015_A3PaisBandera ;
      private short[] T00019_A1PaisId ;
      private short[] T000110_A1PaisId ;
      private short[] T00014_A1PaisId ;
      private String[] T00014_A2PaisNombre ;
      private String[] T00014_A40000PaisBandera_GXI ;
      private String[] T00014_A3PaisBandera ;
      private short[] T000111_A1PaisId ;
      private short[] T000115_A8LugarId ;
      private short[] T000116_A1PaisId ;
      private short[] T000117_A1PaisId ;
      private short[] T000117_A4CiudadId ;
      private String[] T000117_A5CiudadNombre ;
      private short[] T000118_A1PaisId ;
      private short[] T000118_A4CiudadId ;
      private short[] T00013_A1PaisId ;
      private short[] T00013_A4CiudadId ;
      private String[] T00013_A5CiudadNombre ;
      private short[] T00012_A1PaisId ;
      private short[] T00012_A4CiudadId ;
      private String[] T00012_A5CiudadNombre ;
      private short[] T000122_A8LugarId ;
      private short[] T000123_A1PaisId ;
      private short[] T000123_A4CiudadId ;
      private String[] T000124_A2PaisNombre ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class pais__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisBandera",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@PaisBandera_GXI",SqlDbType.NVarChar,2048,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@PaisBandera",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@PaisBandera_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadNombre",SqlDbType.NChar,100,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@CiudadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000122 ;
          prmT000122 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000123 ;
          prmT000123 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000124 ;
          prmT000124 = new Object[] {
          new Object[] {"@PaisNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WITH (UPDLOCK) WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00013", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00014", "SELECT [PaisId], [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WITH (UPDLOCK) WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00015", "SELECT [PaisId], [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00016", "SELECT TM1.[PaisId], TM1.[PaisNombre], TM1.[PaisBandera_GXI], TM1.[PaisBandera] FROM [Pais] TM1 WHERE TM1.[PaisId] = @PaisId ORDER BY TM1.[PaisId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00017", "SELECT [PaisNombre] FROM [Pais] WHERE ([PaisNombre] = @PaisNombre) AND (Not ( [PaisId] = @PaisId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00018", "SELECT [PaisId] FROM [Pais] WHERE [PaisId] = @PaisId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00019", "SELECT TOP 1 [PaisId] FROM [Pais] WHERE ( [PaisId] > @PaisId) ORDER BY [PaisId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000110", "SELECT TOP 1 [PaisId] FROM [Pais] WHERE ( [PaisId] < @PaisId) ORDER BY [PaisId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000111", "INSERT INTO [Pais]([PaisNombre], [PaisBandera], [PaisBandera_GXI]) VALUES(@PaisNombre, @PaisBandera, @PaisBandera_GXI); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000111)
             ,new CursorDef("T000112", "UPDATE [Pais] SET [PaisNombre]=@PaisNombre  WHERE [PaisId] = @PaisId", GxErrorMask.GX_NOMASK,prmT000112)
             ,new CursorDef("T000113", "UPDATE [Pais] SET [PaisBandera]=@PaisBandera, [PaisBandera_GXI]=@PaisBandera_GXI  WHERE [PaisId] = @PaisId", GxErrorMask.GX_NOMASK,prmT000113)
             ,new CursorDef("T000114", "DELETE FROM [Pais]  WHERE [PaisId] = @PaisId", GxErrorMask.GX_NOMASK,prmT000114)
             ,new CursorDef("T000115", "SELECT TOP 1 [LugarId] FROM [Lugar] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000116", "SELECT [PaisId] FROM [Pais] ORDER BY [PaisId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000117", "SELECT [PaisId], [CiudadId], [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId and [CiudadId] = @CiudadId ORDER BY [PaisId], [CiudadId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000118", "SELECT [PaisId], [CiudadId] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000119", "INSERT INTO [PaisCiudad]([PaisId], [CiudadId], [CiudadNombre]) VALUES(@PaisId, @CiudadId, @CiudadNombre)", GxErrorMask.GX_NOMASK,prmT000119)
             ,new CursorDef("T000120", "UPDATE [PaisCiudad] SET [CiudadNombre]=@CiudadNombre  WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId", GxErrorMask.GX_NOMASK,prmT000120)
             ,new CursorDef("T000121", "DELETE FROM [PaisCiudad]  WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId", GxErrorMask.GX_NOMASK,prmT000121)
             ,new CursorDef("T000122", "SELECT TOP 1 [LugarId] FROM [Lugar] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000122,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000123", "SELECT [PaisId], [CiudadId] FROM [PaisCiudad] WHERE [PaisId] = @PaisId ORDER BY [PaisId], [CiudadId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000123,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000124", "SELECT [PaisNombre] FROM [Pais] WHERE ([PaisNombre] = @PaisNombre) AND (Not ( [PaisId] = @PaisId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000124,1, GxCacheFrequency.OFF ,true,false )
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
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameterBlob(2, (String)parms[1], false);
                stmt.SetParameterMultimedia(3, (String)parms[2], (String)parms[1], "Pais", "PaisBandera");
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Pais", "PaisBandera");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
