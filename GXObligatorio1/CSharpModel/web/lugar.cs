/*
               File: Lugar
        Description: Lugar
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:49:10.51
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
   public class lugar : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A1PaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_13( A1PaisId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A1PaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            A4CiudadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A1PaisId, A4CiudadId) ;
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
               AV7LugarId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7LugarId", StringUtil.LTrimStr( (decimal)(AV7LugarId), 4, 0));
               AssignAttri("", false, "gxhash_vLUGARID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7LugarId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Lugar", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtLugarId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public lugar( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public lugar( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_LugarId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7LugarId = aP1_LugarId;
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Lugar", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Lugar.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Lugar.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLugarId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLugarNombre_Internalname, StringUtil.RTrim( A9LugarNombre), StringUtil.RTrim( context.localUtil.Format( A9LugarNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgLugarFoto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Foto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         A10LugarFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000LugarFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.PathToRelativeUrl( A10LugarFoto));
         GxWebStd.gx_bitmap( context, imgLugarFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgLugarFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,44);\"", "", "", "", 0, A10LugarFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Lugar.htm");
         AssignProp("", false, imgLugarFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.PathToRelativeUrl( A10LugarFoto)), true);
         AssignProp("", false, imgLugarFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A10LugarFoto_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtPaisId_Internalname, "Pais Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PaisId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1PaisId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPaisId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Lugar.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Lugar.htm");
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
         GxWebStd.gx_label_element( context, edtPaisNombre_Internalname, "Pais Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtPaisNombre_Internalname, StringUtil.RTrim( A2PaisNombre), StringUtil.RTrim( context.localUtil.Format( A2PaisNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPaisNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Lugar.htm");
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
         GxWebStd.gx_label_element( context, "", "Pais Bandera", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         ClassString = "Attribute";
         StyleString = "";
         A3PaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40001PaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.PathToRelativeUrl( A3PaisBandera));
         GxWebStd.gx_bitmap( context, imgPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgPaisBandera_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A3PaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Lugar.htm");
         AssignProp("", false, imgPaisBandera_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.PathToRelativeUrl( A3PaisBandera)), true);
         AssignProp("", false, imgPaisBandera_Internalname, "IsBlob", StringUtil.BoolToStr( A3PaisBandera_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCiudadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtCiudadId_Internalname, "Ciudad Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CiudadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A4CiudadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCiudadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCiudadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Lugar.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, sImgUrl, imgprompt_4_Link, "", "", context.GetTheme( ), imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCiudadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtCiudadNombre_Internalname, "Ciudad Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtCiudadNombre_Internalname, StringUtil.RTrim( A5CiudadNombre), StringUtil.RTrim( context.localUtil.Format( A5CiudadNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCiudadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Lugar.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Lugar.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
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
         E11032 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z8LugarId = (short)(context.localUtil.CToN( cgiGet( "Z8LugarId"), ".", ","));
               Z9LugarNombre = cgiGet( "Z9LugarNombre");
               Z1PaisId = (short)(context.localUtil.CToN( cgiGet( "Z1PaisId"), ".", ","));
               Z4CiudadId = (short)(context.localUtil.CToN( cgiGet( "Z4CiudadId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N1PaisId = (short)(context.localUtil.CToN( cgiGet( "N1PaisId"), ".", ","));
               N4CiudadId = (short)(context.localUtil.CToN( cgiGet( "N4CiudadId"), ".", ","));
               AV7LugarId = (short)(context.localUtil.CToN( cgiGet( "vLUGARID"), ".", ","));
               AV11Insert_PaisId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_PAISID"), ".", ","));
               AV12Insert_CiudadId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_CIUDADID"), ".", ","));
               A40000LugarFoto_GXI = cgiGet( "LUGARFOTO_GXI");
               A40001PaisBandera_GXI = cgiGet( "PAISBANDERA_GXI");
               AV14Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LUGARID");
                  AnyError = 1;
                  GX_FocusControl = edtLugarId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A8LugarId = 0;
                  AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               }
               else
               {
                  A8LugarId = (short)(context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ","));
                  AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               }
               A9LugarNombre = cgiGet( edtLugarNombre_Internalname);
               AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
               A10LugarFoto = cgiGet( imgLugarFoto_Internalname);
               AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PAISID");
                  AnyError = 1;
                  GX_FocusControl = edtPaisId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1PaisId = 0;
                  AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
               }
               else
               {
                  A1PaisId = (short)(context.localUtil.CToN( cgiGet( edtPaisId_Internalname), ".", ","));
                  AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
               }
               A2PaisNombre = cgiGet( edtPaisNombre_Internalname);
               AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
               A3PaisBandera = cgiGet( imgPaisBandera_Internalname);
               AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
               if ( ( ( context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CIUDADID");
                  AnyError = 1;
                  GX_FocusControl = edtCiudadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A4CiudadId = 0;
                  AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
               }
               else
               {
                  A4CiudadId = (short)(context.localUtil.CToN( cgiGet( edtCiudadId_Internalname), ".", ","));
                  AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
               }
               A5CiudadNombre = cgiGet( edtCiudadNombre_Internalname);
               AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgLugarFoto_Internalname, ref  A10LugarFoto, ref  A40000LugarFoto_GXI);
               getMultimediaValue(imgPaisBandera_Internalname, ref  A3PaisBandera, ref  A40001PaisBandera_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Lugar");
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A8LugarId != Z8LugarId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("lugar:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
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
                  A8LugarId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
                  getEqualNoModal( ) ;
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
                     sMode4 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode4;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound4 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "LUGARID");
                        AnyError = 1;
                        GX_FocusControl = edtLugarId_Internalname;
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
            E12032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll034( ) ;
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
            DisableAttributes034( ) ;
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
               CloseExtendedTableCursors034( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV14Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "GXObligatorio1");
         AV11Insert_PaisId = 0;
         AssignAttri("", false, "AV11Insert_PaisId", StringUtil.LTrimStr( (decimal)(AV11Insert_PaisId), 4, 0));
         AV12Insert_CiudadId = 0;
         AssignAttri("", false, "AV12Insert_CiudadId", StringUtil.LTrimStr( (decimal)(AV12Insert_CiudadId), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV14Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV15GXV1 = 1;
            AssignAttri("", false, "AV15GXV1", StringUtil.LTrimStr( (decimal)(AV15GXV1), 8, 0));
            while ( AV15GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV15GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "PaisId") == 0 )
               {
                  AV11Insert_PaisId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_PaisId", StringUtil.LTrimStr( (decimal)(AV11Insert_PaisId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "CiudadId") == 0 )
               {
                  AV12Insert_CiudadId = (short)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV12Insert_CiudadId", StringUtil.LTrimStr( (decimal)(AV12Insert_CiudadId), 4, 0));
               }
               AV15GXV1 = (int)(AV15GXV1+1);
               AssignAttri("", false, "AV15GXV1", StringUtil.LTrimStr( (decimal)(AV15GXV1), 8, 0));
            }
         }
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwlugar.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM034( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z9LugarNombre = T00033_A9LugarNombre[0];
               Z1PaisId = T00033_A1PaisId[0];
               Z4CiudadId = T00033_A4CiudadId[0];
            }
            else
            {
               Z9LugarNombre = A9LugarNombre;
               Z1PaisId = A1PaisId;
               Z4CiudadId = A4CiudadId;
            }
         }
         if ( GX_JID == -12 )
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
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISID"+"'), id:'"+"PAISID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISID"+"'), id:'"+"PAISID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CIUDADID"+"'), id:'"+"CIUDADID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7LugarId) )
         {
            A8LugarId = AV7LugarId;
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
         }
         if ( ! (0==AV7LugarId) )
         {
            edtLugarId_Enabled = 0;
            AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         }
         else
         {
            edtLugarId_Enabled = 1;
            AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         }
         if ( ! (0==AV7LugarId) )
         {
            edtLugarId_Enabled = 0;
            AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_PaisId) )
         {
            edtPaisId_Enabled = 0;
            AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         }
         else
         {
            edtPaisId_Enabled = 1;
            AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_CiudadId) )
         {
            edtCiudadId_Enabled = 0;
            AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), true);
         }
         else
         {
            edtCiudadId_Enabled = 1;
            AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_CiudadId) )
         {
            A4CiudadId = AV12Insert_CiudadId;
            AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_PaisId) )
         {
            A1PaisId = AV11Insert_PaisId;
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV14Pgmname = "Lugar";
            AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T00034 */
            pr_default.execute(2, new Object[] {A1PaisId});
            A2PaisNombre = T00034_A2PaisNombre[0];
            AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
            A40001PaisBandera_GXI = T00034_A40001PaisBandera_GXI[0];
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            A3PaisBandera = T00034_A3PaisBandera[0];
            AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            pr_default.close(2);
            /* Using cursor T00035 */
            pr_default.execute(3, new Object[] {A1PaisId, A4CiudadId});
            A5CiudadNombre = T00035_A5CiudadNombre[0];
            AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
            pr_default.close(3);
         }
      }

      protected void Load034( )
      {
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound4 = 1;
            A9LugarNombre = T00036_A9LugarNombre[0];
            AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
            A40000LugarFoto_GXI = T00036_A40000LugarFoto_GXI[0];
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A2PaisNombre = T00036_A2PaisNombre[0];
            AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
            A40001PaisBandera_GXI = T00036_A40001PaisBandera_GXI[0];
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            A5CiudadNombre = T00036_A5CiudadNombre[0];
            AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
            A1PaisId = T00036_A1PaisId[0];
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            A4CiudadId = T00036_A4CiudadId[0];
            AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
            A10LugarFoto = T00036_A10LugarFoto[0];
            AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A3PaisBandera = T00036_A3PaisBandera[0];
            AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            ZM034( -12) ;
         }
         pr_default.close(4);
         OnLoadActions034( ) ;
      }

      protected void OnLoadActions034( )
      {
         AV14Pgmname = "Lugar";
         AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable034( )
      {
         nIsDirty_4 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV14Pgmname = "Lugar";
         AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2PaisNombre = T00034_A2PaisNombre[0];
         AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
         A40001PaisBandera_GXI = T00034_A40001PaisBandera_GXI[0];
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         A3PaisBandera = T00034_A3PaisBandera[0];
         AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         pr_default.close(2);
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Ciudad'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A5CiudadNombre = T00035_A5CiudadNombre[0];
         AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
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

      protected void gxLoad_13( short A1PaisId )
      {
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2PaisNombre = T00037_A2PaisNombre[0];
         AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
         A40001PaisBandera_GXI = T00037_A40001PaisBandera_GXI[0];
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         A3PaisBandera = T00037_A3PaisBandera[0];
         AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A2PaisNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( A3PaisBandera)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40001PaisBandera_GXI)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(5) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(5);
      }

      protected void gxLoad_14( short A1PaisId ,
                                short A4CiudadId )
      {
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Ciudad'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A5CiudadNombre = T00038_A5CiudadNombre[0];
         AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A5CiudadNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(6) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(6);
      }

      protected void GetKey034( )
      {
         /* Using cursor T00039 */
         pr_default.execute(7, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM034( 12) ;
            RcdFound4 = 1;
            A8LugarId = T00033_A8LugarId[0];
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            A9LugarNombre = T00033_A9LugarNombre[0];
            AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
            A40000LugarFoto_GXI = T00033_A40000LugarFoto_GXI[0];
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A1PaisId = T00033_A1PaisId[0];
            AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
            A4CiudadId = T00033_A4CiudadId[0];
            AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
            A10LugarFoto = T00033_A10LugarFoto[0];
            AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            Z8LugarId = A8LugarId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load034( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey034( ) ;
            }
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey034( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode4;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey034( ) ;
         if ( RcdFound4 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0;
         /* Using cursor T000310 */
         pr_default.execute(8, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000310_A8LugarId[0] < A8LugarId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000310_A8LugarId[0] > A8LugarId ) ) )
            {
               A8LugarId = T000310_A8LugarId[0];
               AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               RcdFound4 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T000311 */
         pr_default.execute(9, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000311_A8LugarId[0] > A8LugarId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000311_A8LugarId[0] < A8LugarId ) ) )
            {
               A8LugarId = T000311_A8LugarId[0];
               AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               RcdFound4 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey034( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtLugarId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert034( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A8LugarId != Z8LugarId )
               {
                  A8LugarId = Z8LugarId;
                  AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "LUGARID");
                  AnyError = 1;
                  GX_FocusControl = edtLugarId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtLugarId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update034( ) ;
                  GX_FocusControl = edtLugarId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A8LugarId != Z8LugarId )
               {
                  /* Insert record */
                  GX_FocusControl = edtLugarId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert034( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "LUGARID");
                     AnyError = 1;
                     GX_FocusControl = edtLugarId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtLugarId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert034( ) ;
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
         if ( IsUpd( ) || IsDlt( ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A8LugarId != Z8LugarId )
         {
            A8LugarId = Z8LugarId;
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "LUGARID");
            AnyError = 1;
            GX_FocusControl = edtLugarId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtLugarId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency034( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A8LugarId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Lugar"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z9LugarNombre, T00032_A9LugarNombre[0]) != 0 ) || ( Z1PaisId != T00032_A1PaisId[0] ) || ( Z4CiudadId != T00032_A4CiudadId[0] ) )
            {
               if ( StringUtil.StrCmp(Z9LugarNombre, T00032_A9LugarNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("lugar:[seudo value changed for attri]"+"LugarNombre");
                  GXUtil.WriteLogRaw("Old: ",Z9LugarNombre);
                  GXUtil.WriteLogRaw("Current: ",T00032_A9LugarNombre[0]);
               }
               if ( Z1PaisId != T00032_A1PaisId[0] )
               {
                  GXUtil.WriteLog("lugar:[seudo value changed for attri]"+"PaisId");
                  GXUtil.WriteLogRaw("Old: ",Z1PaisId);
                  GXUtil.WriteLogRaw("Current: ",T00032_A1PaisId[0]);
               }
               if ( Z4CiudadId != T00032_A4CiudadId[0] )
               {
                  GXUtil.WriteLog("lugar:[seudo value changed for attri]"+"CiudadId");
                  GXUtil.WriteLogRaw("Old: ",Z4CiudadId);
                  GXUtil.WriteLogRaw("Current: ",T00032_A4CiudadId[0]);
               }
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
                     /* Using cursor T000312 */
                     pr_default.execute(10, new Object[] {A8LugarId, A9LugarNombre, A10LugarFoto, A40000LugarFoto_GXI, A1PaisId, A4CiudadId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                           ResetCaption030( ) ;
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
                     /* Using cursor T000313 */
                     pr_default.execute(11, new Object[] {A9LugarNombre, A1PaisId, A4CiudadId, A8LugarId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
                     if ( (pr_default.getStatus(11) == 103) )
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
                           if ( IsUpd( ) || IsDlt( ) )
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
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void DeferredUpdate034( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000314 */
            pr_default.execute(12, new Object[] {A10LugarFoto, A40000LugarFoto_GXI, A8LugarId});
            pr_default.close(12);
            dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
         }
      }

      protected void delete( )
      {
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
                  /* Using cursor T000315 */
                  pr_default.execute(13, new Object[] {A8LugarId});
                  pr_default.close(13);
                  dsDefault.SmartCacheProvider.SetUpdated("Lugar") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( IsUpd( ) || IsDlt( ) )
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel034( ) ;
         Gx_mode = sMode4;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls034( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "Lugar";
            AssignAttri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000316 */
            pr_default.execute(14, new Object[] {A1PaisId});
            A2PaisNombre = T000316_A2PaisNombre[0];
            AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
            A40001PaisBandera_GXI = T000316_A40001PaisBandera_GXI[0];
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            A3PaisBandera = T000316_A3PaisBandera[0];
            AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
            AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
            AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
            pr_default.close(14);
            /* Using cursor T000317 */
            pr_default.execute(15, new Object[] {A1PaisId, A4CiudadId});
            A5CiudadNombre = T000317_A5CiudadNombre[0];
            AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
            pr_default.close(15);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000318 */
            pr_default.execute(16, new Object[] {A8LugarId});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Espectaculo"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
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
            pr_default.close(1);
            pr_default.close(14);
            pr_default.close(15);
            context.CommitDataStores("lugar",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(14);
            pr_default.close(15);
            context.RollbackDataStores("lugar",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart034( )
      {
         /* Scan By routine */
         /* Using cursor T000319 */
         pr_default.execute(17);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound4 = 1;
            A8LugarId = T000319_A8LugarId[0];
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext034( )
      {
         /* Scan next routine */
         pr_default.readNext(17);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound4 = 1;
            A8LugarId = T000319_A8LugarId[0];
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
         }
      }

      protected void ScanEnd034( )
      {
         pr_default.close(17);
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
         edtLugarId_Enabled = 0;
         AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         edtLugarNombre_Enabled = 0;
         AssignProp("", false, edtLugarNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarNombre_Enabled), 5, 0), true);
         imgLugarFoto_Enabled = 0;
         AssignProp("", false, imgLugarFoto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgLugarFoto_Enabled), 5, 0), true);
         edtPaisId_Enabled = 0;
         AssignProp("", false, edtPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisId_Enabled), 5, 0), true);
         edtPaisNombre_Enabled = 0;
         AssignProp("", false, edtPaisNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtPaisNombre_Enabled), 5, 0), true);
         imgPaisBandera_Enabled = 0;
         AssignProp("", false, imgPaisBandera_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgPaisBandera_Enabled), 5, 0), true);
         edtCiudadId_Enabled = 0;
         AssignProp("", false, edtCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadId_Enabled), 5, 0), true);
         edtCiudadNombre_Enabled = 0;
         AssignProp("", false, edtCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtCiudadNombre_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes034( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
      {
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
         context.AddJavascriptSource("gxcfg.js", "?202021621491136", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("lugar.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7LugarId)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Lugar");
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("lugar:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z8LugarId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8LugarId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z9LugarNombre", StringUtil.RTrim( Z9LugarNombre));
         GxWebStd.gx_hidden_field( context, "Z1PaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4CiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4CiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N1PaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N4CiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CiudadId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vLUGARID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7LugarId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vLUGARID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7LugarId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_PAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_PaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_CIUDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_CiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LUGARFOTO_GXI", A40000LugarFoto_GXI);
         GxWebStd.gx_hidden_field( context, "PAISBANDERA_GXI", A40001PaisBandera_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "LUGARFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A10LugarFoto);
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
         return formatLink("lugar.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7LugarId) ;
      }

      public override String GetPgmname( )
      {
         return "Lugar" ;
      }

      public override String GetPgmdesc( )
      {
         return "Lugar" ;
      }

      protected void InitializeNonKey034( )
      {
         A1PaisId = 0;
         AssignAttri("", false, "A1PaisId", StringUtil.LTrimStr( (decimal)(A1PaisId), 4, 0));
         A4CiudadId = 0;
         AssignAttri("", false, "A4CiudadId", StringUtil.LTrimStr( (decimal)(A4CiudadId), 4, 0));
         A9LugarNombre = "";
         AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
         A10LugarFoto = "";
         AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         A40000LugarFoto_GXI = "";
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40000LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         A2PaisNombre = "";
         AssignAttri("", false, "A2PaisNombre", A2PaisNombre);
         A3PaisBandera = "";
         AssignAttri("", false, "A3PaisBandera", A3PaisBandera);
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         A40001PaisBandera_GXI = "";
         AssignProp("", false, imgPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A3PaisBandera)) ? A40001PaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A3PaisBandera))), true);
         AssignProp("", false, imgPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A3PaisBandera), true);
         A5CiudadNombre = "";
         AssignAttri("", false, "A5CiudadNombre", A5CiudadNombre);
         Z9LugarNombre = "";
         Z1PaisId = 0;
         Z4CiudadId = 0;
      }

      protected void InitAll034( )
      {
         A8LugarId = 0;
         AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
         InitializeNonKey034( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202021621491142", true, true);
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
         context.AddJavascriptSource("lugar.js", "?202021621491142", false, true);
         /* End function include_jscripts */
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
         edtLugarId_Internalname = "LUGARID";
         edtLugarNombre_Internalname = "LUGARNOMBRE";
         imgLugarFoto_Internalname = "LUGARFOTO";
         edtPaisId_Internalname = "PAISID";
         edtPaisNombre_Internalname = "PAISNOMBRE";
         imgPaisBandera_Internalname = "PAISBANDERA";
         edtCiudadId_Internalname = "CIUDADID";
         edtCiudadNombre_Internalname = "CIUDADNOMBRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_4_Internalname = "PROMPT_4";
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
         Form.Caption = "Lugar";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtCiudadNombre_Jsonclick = "";
         edtCiudadNombre_Enabled = 0;
         imgprompt_4_Visible = 1;
         imgprompt_4_Link = "";
         edtCiudadId_Jsonclick = "";
         edtCiudadId_Enabled = 1;
         imgPaisBandera_Enabled = 0;
         edtPaisNombre_Jsonclick = "";
         edtPaisNombre_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtPaisId_Jsonclick = "";
         edtPaisId_Enabled = 1;
         imgLugarFoto_Enabled = 1;
         edtLugarNombre_Jsonclick = "";
         edtLugarNombre_Enabled = 1;
         edtLugarId_Jsonclick = "";
         edtLugarId_Enabled = 1;
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

      public void Valid_Paisid( )
      {
         /* Using cursor T000316 */
         pr_default.execute(14, new Object[] {A1PaisId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Pais'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
         }
         A2PaisNombre = T000316_A2PaisNombre[0];
         A40001PaisBandera_GXI = T000316_A40001PaisBandera_GXI[0];
         A3PaisBandera = T000316_A3PaisBandera[0];
         pr_default.close(14);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A2PaisNombre", StringUtil.RTrim( A2PaisNombre));
         AssignAttri("", false, "A3PaisBandera", context.PathToRelativeUrl( A3PaisBandera));
         AssignAttri("", false, "A40001PaisBandera_GXI", A40001PaisBandera_GXI);
      }

      public void Valid_Ciudadid( )
      {
         /* Using cursor T000317 */
         pr_default.execute(15, new Object[] {A1PaisId, A4CiudadId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No matching 'Ciudad'.", "ForeignKeyNotFound", 1, "PAISID");
            AnyError = 1;
            GX_FocusControl = edtPaisId_Internalname;
         }
         A5CiudadNombre = T000317_A5CiudadNombre[0];
         pr_default.close(15);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A5CiudadNombre", StringUtil.RTrim( A5CiudadNombre));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7LugarId',fld:'vLUGARID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7LugarId',fld:'vLUGARID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12032',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_LUGARID","{handler:'Valid_Lugarid',iparms:[]");
         setEventMetadata("VALID_LUGARID",",oparms:[]}");
         setEventMetadata("VALID_PAISID","{handler:'Valid_Paisid',iparms:[{av:'A1PaisId',fld:'PAISID',pic:'ZZZ9'},{av:'A2PaisNombre',fld:'PAISNOMBRE',pic:''},{av:'A3PaisBandera',fld:'PAISBANDERA',pic:''},{av:'A40001PaisBandera_GXI',fld:'PAISBANDERA_GXI',pic:''}]");
         setEventMetadata("VALID_PAISID",",oparms:[{av:'A2PaisNombre',fld:'PAISNOMBRE',pic:''},{av:'A3PaisBandera',fld:'PAISBANDERA',pic:''},{av:'A40001PaisBandera_GXI',fld:'PAISBANDERA_GXI',pic:''}]}");
         setEventMetadata("VALID_CIUDADID","{handler:'Valid_Ciudadid',iparms:[{av:'A1PaisId',fld:'PAISID',pic:'ZZZ9'},{av:'A4CiudadId',fld:'CIUDADID',pic:'ZZZ9'},{av:'A5CiudadNombre',fld:'CIUDADNOMBRE',pic:''}]");
         setEventMetadata("VALID_CIUDADID",",oparms:[{av:'A5CiudadNombre',fld:'CIUDADNOMBRE',pic:''}]}");
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
         pr_default.close(14);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z9LugarNombre = "";
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
         A9LugarNombre = "";
         A10LugarFoto = "";
         A40000LugarFoto_GXI = "";
         sImgUrl = "";
         A2PaisNombre = "";
         A3PaisBandera = "";
         A40001PaisBandera_GXI = "";
         A5CiudadNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV14Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode4 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z10LugarFoto = "";
         Z40000LugarFoto_GXI = "";
         Z2PaisNombre = "";
         Z3PaisBandera = "";
         Z40001PaisBandera_GXI = "";
         Z5CiudadNombre = "";
         T00034_A2PaisNombre = new String[] {""} ;
         T00034_A40001PaisBandera_GXI = new String[] {""} ;
         T00034_A3PaisBandera = new String[] {""} ;
         T00035_A5CiudadNombre = new String[] {""} ;
         T00036_A8LugarId = new short[1] ;
         T00036_A9LugarNombre = new String[] {""} ;
         T00036_A40000LugarFoto_GXI = new String[] {""} ;
         T00036_A2PaisNombre = new String[] {""} ;
         T00036_A40001PaisBandera_GXI = new String[] {""} ;
         T00036_A5CiudadNombre = new String[] {""} ;
         T00036_A1PaisId = new short[1] ;
         T00036_A4CiudadId = new short[1] ;
         T00036_A10LugarFoto = new String[] {""} ;
         T00036_A3PaisBandera = new String[] {""} ;
         T00037_A2PaisNombre = new String[] {""} ;
         T00037_A40001PaisBandera_GXI = new String[] {""} ;
         T00037_A3PaisBandera = new String[] {""} ;
         T00038_A5CiudadNombre = new String[] {""} ;
         T00039_A8LugarId = new short[1] ;
         T00033_A8LugarId = new short[1] ;
         T00033_A9LugarNombre = new String[] {""} ;
         T00033_A40000LugarFoto_GXI = new String[] {""} ;
         T00033_A1PaisId = new short[1] ;
         T00033_A4CiudadId = new short[1] ;
         T00033_A10LugarFoto = new String[] {""} ;
         T000310_A8LugarId = new short[1] ;
         T000311_A8LugarId = new short[1] ;
         T00032_A8LugarId = new short[1] ;
         T00032_A9LugarNombre = new String[] {""} ;
         T00032_A40000LugarFoto_GXI = new String[] {""} ;
         T00032_A1PaisId = new short[1] ;
         T00032_A4CiudadId = new short[1] ;
         T00032_A10LugarFoto = new String[] {""} ;
         T000316_A2PaisNombre = new String[] {""} ;
         T000316_A40001PaisBandera_GXI = new String[] {""} ;
         T000316_A3PaisBandera = new String[] {""} ;
         T000317_A5CiudadNombre = new String[] {""} ;
         T000318_A34EspectaculoId = new short[1] ;
         T000319_A8LugarId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.lugar__default(),
            new Object[][] {
                new Object[] {
               T00032_A8LugarId, T00032_A9LugarNombre, T00032_A40000LugarFoto_GXI, T00032_A1PaisId, T00032_A4CiudadId, T00032_A10LugarFoto
               }
               , new Object[] {
               T00033_A8LugarId, T00033_A9LugarNombre, T00033_A40000LugarFoto_GXI, T00033_A1PaisId, T00033_A4CiudadId, T00033_A10LugarFoto
               }
               , new Object[] {
               T00034_A2PaisNombre, T00034_A40001PaisBandera_GXI, T00034_A3PaisBandera
               }
               , new Object[] {
               T00035_A5CiudadNombre
               }
               , new Object[] {
               T00036_A8LugarId, T00036_A9LugarNombre, T00036_A40000LugarFoto_GXI, T00036_A2PaisNombre, T00036_A40001PaisBandera_GXI, T00036_A5CiudadNombre, T00036_A1PaisId, T00036_A4CiudadId, T00036_A10LugarFoto, T00036_A3PaisBandera
               }
               , new Object[] {
               T00037_A2PaisNombre, T00037_A40001PaisBandera_GXI, T00037_A3PaisBandera
               }
               , new Object[] {
               T00038_A5CiudadNombre
               }
               , new Object[] {
               T00039_A8LugarId
               }
               , new Object[] {
               T000310_A8LugarId
               }
               , new Object[] {
               T000311_A8LugarId
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
               T000316_A2PaisNombre, T000316_A40001PaisBandera_GXI, T000316_A3PaisBandera
               }
               , new Object[] {
               T000317_A5CiudadNombre
               }
               , new Object[] {
               T000318_A34EspectaculoId
               }
               , new Object[] {
               T000319_A8LugarId
               }
            }
         );
         AV14Pgmname = "Lugar";
      }

      private short wcpOAV7LugarId ;
      private short Z8LugarId ;
      private short Z1PaisId ;
      private short Z4CiudadId ;
      private short N1PaisId ;
      private short N4CiudadId ;
      private short GxWebError ;
      private short A1PaisId ;
      private short A4CiudadId ;
      private short AV7LugarId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A8LugarId ;
      private short AV11Insert_PaisId ;
      private short AV12Insert_CiudadId ;
      private short RcdFound4 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short nIsDirty_4 ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtLugarId_Enabled ;
      private int edtLugarNombre_Enabled ;
      private int imgLugarFoto_Enabled ;
      private int edtPaisId_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtPaisNombre_Enabled ;
      private int imgPaisBandera_Enabled ;
      private int edtCiudadId_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtCiudadNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV15GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z9LugarNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtLugarId_Internalname ;
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
      private String edtLugarId_Jsonclick ;
      private String edtLugarNombre_Internalname ;
      private String A9LugarNombre ;
      private String edtLugarNombre_Jsonclick ;
      private String imgLugarFoto_Internalname ;
      private String sImgUrl ;
      private String edtPaisId_Internalname ;
      private String edtPaisId_Jsonclick ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtPaisNombre_Internalname ;
      private String A2PaisNombre ;
      private String edtPaisNombre_Jsonclick ;
      private String imgPaisBandera_Internalname ;
      private String edtCiudadId_Internalname ;
      private String edtCiudadId_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String edtCiudadNombre_Internalname ;
      private String A5CiudadNombre ;
      private String edtCiudadNombre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String hsh ;
      private String sMode4 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z2PaisNombre ;
      private String Z5CiudadNombre ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A10LugarFoto_IsBlob ;
      private bool A3PaisBandera_IsBlob ;
      private bool returnInSub ;
      private String A40000LugarFoto_GXI ;
      private String A40001PaisBandera_GXI ;
      private String Z40000LugarFoto_GXI ;
      private String Z40001PaisBandera_GXI ;
      private String A10LugarFoto ;
      private String A3PaisBandera ;
      private String Z10LugarFoto ;
      private String Z3PaisBandera ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00034_A2PaisNombre ;
      private String[] T00034_A40001PaisBandera_GXI ;
      private String[] T00034_A3PaisBandera ;
      private String[] T00035_A5CiudadNombre ;
      private short[] T00036_A8LugarId ;
      private String[] T00036_A9LugarNombre ;
      private String[] T00036_A40000LugarFoto_GXI ;
      private String[] T00036_A2PaisNombre ;
      private String[] T00036_A40001PaisBandera_GXI ;
      private String[] T00036_A5CiudadNombre ;
      private short[] T00036_A1PaisId ;
      private short[] T00036_A4CiudadId ;
      private String[] T00036_A10LugarFoto ;
      private String[] T00036_A3PaisBandera ;
      private String[] T00037_A2PaisNombre ;
      private String[] T00037_A40001PaisBandera_GXI ;
      private String[] T00037_A3PaisBandera ;
      private String[] T00038_A5CiudadNombre ;
      private short[] T00039_A8LugarId ;
      private short[] T00033_A8LugarId ;
      private String[] T00033_A9LugarNombre ;
      private String[] T00033_A40000LugarFoto_GXI ;
      private short[] T00033_A1PaisId ;
      private short[] T00033_A4CiudadId ;
      private String[] T00033_A10LugarFoto ;
      private short[] T000310_A8LugarId ;
      private short[] T000311_A8LugarId ;
      private short[] T00032_A8LugarId ;
      private String[] T00032_A9LugarNombre ;
      private String[] T00032_A40000LugarFoto_GXI ;
      private short[] T00032_A1PaisId ;
      private short[] T00032_A4CiudadId ;
      private String[] T00032_A10LugarFoto ;
      private String[] T000316_A2PaisNombre ;
      private String[] T000316_A40001PaisBandera_GXI ;
      private String[] T000316_A3PaisBandera ;
      private String[] T000317_A5CiudadNombre ;
      private short[] T000318_A34EspectaculoId ;
      private short[] T000319_A8LugarId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class lugar__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LugarFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@LugarFoto_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@LugarNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          new Object[] {"@LugarFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@LugarFoto_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000318 ;
          prmT000318 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000319 ;
          prmT000319 = new Object[] {
          } ;
          Object[] prmT000316 ;
          prmT000316 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000317 ;
          prmT000317 = new Object[] {
          new Object[] {"@PaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CiudadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [LugarId], [LugarNombre], [LugarFoto_GXI], [PaisId], [CiudadId], [LugarFoto] FROM [Lugar] WITH (UPDLOCK) WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00033", "SELECT [LugarId], [LugarNombre], [LugarFoto_GXI], [PaisId], [CiudadId], [LugarFoto] FROM [Lugar] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00034", "SELECT [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00035", "SELECT [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00036", "SELECT TM1.[LugarId], TM1.[LugarNombre], TM1.[LugarFoto_GXI], T2.[PaisNombre], T2.[PaisBandera_GXI], T3.[CiudadNombre], TM1.[PaisId], TM1.[CiudadId], TM1.[LugarFoto], T2.[PaisBandera] FROM (([Lugar] TM1 INNER JOIN [Pais] T2 ON T2.[PaisId] = TM1.[PaisId]) INNER JOIN [PaisCiudad] T3 ON T3.[PaisId] = TM1.[PaisId] AND T3.[CiudadId] = TM1.[CiudadId]) WHERE TM1.[LugarId] = @LugarId ORDER BY TM1.[LugarId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00037", "SELECT [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00038", "SELECT [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00039", "SELECT [LugarId] FROM [Lugar] WHERE [LugarId] = @LugarId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000310", "SELECT TOP 1 [LugarId] FROM [Lugar] WHERE ( [LugarId] > @LugarId) ORDER BY [LugarId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000311", "SELECT TOP 1 [LugarId] FROM [Lugar] WHERE ( [LugarId] < @LugarId) ORDER BY [LugarId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000311,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000312", "INSERT INTO [Lugar]([LugarId], [LugarNombre], [LugarFoto], [LugarFoto_GXI], [PaisId], [CiudadId]) VALUES(@LugarId, @LugarNombre, @LugarFoto, @LugarFoto_GXI, @PaisId, @CiudadId)", GxErrorMask.GX_NOMASK,prmT000312)
             ,new CursorDef("T000313", "UPDATE [Lugar] SET [LugarNombre]=@LugarNombre, [PaisId]=@PaisId, [CiudadId]=@CiudadId  WHERE [LugarId] = @LugarId", GxErrorMask.GX_NOMASK,prmT000313)
             ,new CursorDef("T000314", "UPDATE [Lugar] SET [LugarFoto]=@LugarFoto, [LugarFoto_GXI]=@LugarFoto_GXI  WHERE [LugarId] = @LugarId", GxErrorMask.GX_NOMASK,prmT000314)
             ,new CursorDef("T000315", "DELETE FROM [Lugar]  WHERE [LugarId] = @LugarId", GxErrorMask.GX_NOMASK,prmT000315)
             ,new CursorDef("T000316", "SELECT [PaisNombre], [PaisBandera_GXI], [PaisBandera] FROM [Pais] WHERE [PaisId] = @PaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000316,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000317", "SELECT [CiudadNombre] FROM [PaisCiudad] WHERE [PaisId] = @PaisId AND [CiudadId] = @CiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000317,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000318", "SELECT TOP 1 [EspectaculoId] FROM [Espectaculo] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000318,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000319", "SELECT [LugarId] FROM [Lugar] ORDER BY [LugarId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000319,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
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
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 17 :
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
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterBlob(3, (String)parms[2], false);
                stmt.SetParameterMultimedia(4, (String)parms[3], (String)parms[2], "Lugar", "LugarFoto");
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 12 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Lugar", "LugarFoto");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
