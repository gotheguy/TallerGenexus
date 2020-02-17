/*
               File: Venta
        Description: Venta
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:49:12.96
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
   public class venta : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_16") == 0 )
         {
            A34EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_16( A34EspectaculoId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
         {
            A19EspectaculoPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_19( A19EspectaculoPaisId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_20") == 0 )
         {
            A19EspectaculoPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A22EspectaculoCiudadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_20( A19EspectaculoPaisId, A22EspectaculoCiudadId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A24VentaPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A24VentaPaisId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A24VentaPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
            A27VentaCiudadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_18( A24VentaPaisId, A27VentaCiudadId) ;
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
               AV7VentaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7VentaId", StringUtil.LTrimStr( (decimal)(AV7VentaId), 4, 0));
               AssignAttri("", false, "gxhash_vVENTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7VentaId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Venta", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtVentaId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public venta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public venta( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_VentaId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7VentaId = aP1_VentaId;
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Venta", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Venta.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Venta.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtVentaId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtVentaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgVentaFecha_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Fecha", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         ClassString = "Attribute";
         StyleString = "";
         A38VentaFecha_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000VentaFecha_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.PathToRelativeUrl( A38VentaFecha));
         GxWebStd.gx_bitmap( context, imgVentaFecha_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgVentaFecha_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "", "", "", 0, A38VentaFecha_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         AssignProp("", false, imgVentaFecha_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.PathToRelativeUrl( A38VentaFecha)), true);
         AssignProp("", false, imgVentaFecha_Internalname, "IsBlob", StringUtil.BoolToStr( A38VentaFecha_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoId_Internalname, "Espectaculo Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_34_Internalname, sImgUrl, imgprompt_34_Link, "", "", context.GetTheme( ), imgprompt_34_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoNombre_Internalname, "Espectaculo Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoNombre_Internalname, StringUtil.RTrim( A35EspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoFecha_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoFecha_Internalname, "Espectaculo Fecha", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         context.WriteHtmlText( "<div id=\""+edtEspectaculoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtEspectaculoFecha_Internalname, context.localUtil.Format(A36EspectaculoFecha, "99/99/99"), context.localUtil.Format( A36EspectaculoFecha, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_bitmap( context, edtEspectaculoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEspectaculoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Venta.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtVentaPaisId_Internalname, "Pais Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtVentaPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24VentaPaisId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A24VentaPaisId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaPaisId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_24_Internalname, sImgUrl, imgprompt_24_Link, "", "", context.GetTheme( ), imgprompt_24_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaPaisNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtVentaPaisNombre_Internalname, "Pais Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtVentaPaisNombre_Internalname, StringUtil.RTrim( A25VentaPaisNombre), StringUtil.RTrim( context.localUtil.Format( A25VentaPaisNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaPaisNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgVentaPaisBandera_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Pais Bandera", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         ClassString = "Attribute";
         StyleString = "";
         A26VentaPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40001VentaPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.PathToRelativeUrl( A26VentaPaisBandera));
         GxWebStd.gx_bitmap( context, imgVentaPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgVentaPaisBandera_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A26VentaPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         AssignProp("", false, imgVentaPaisBandera_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.PathToRelativeUrl( A26VentaPaisBandera)), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "IsBlob", StringUtil.BoolToStr( A26VentaPaisBandera_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaCiudadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtVentaCiudadId_Internalname, "Ciudad Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtVentaCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27VentaCiudadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A27VentaCiudadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaCiudadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaCiudadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_27_Internalname, sImgUrl, imgprompt_27_Link, "", "", context.GetTheme( ), imgprompt_27_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaCiudadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtVentaCiudadNombre_Internalname, "Ciudad Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtVentaCiudadNombre_Internalname, StringUtil.RTrim( A28VentaCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A28VentaCiudadNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaCiudadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoPaisId_Internalname, "Espectaculo Pais Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")), ((edtEspectaculoPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoPaisNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoPaisNombre_Internalname, "Espectaculo Pais Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisNombre_Internalname, StringUtil.RTrim( A20EspectaculoPaisNombre), StringUtil.RTrim( context.localUtil.Format( A20EspectaculoPaisNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgEspectaculoPaisBandera_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Espectaculo Pais Bandera", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         ClassString = "Attribute";
         StyleString = "";
         A21EspectaculoPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40002EspectaculoPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera));
         GxWebStd.gx_bitmap( context, imgEspectaculoPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgEspectaculoPaisBandera_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A21EspectaculoPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera)), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "IsBlob", StringUtil.BoolToStr( A21EspectaculoPaisBandera_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoCiudadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoCiudadId_Internalname, "Espectaculo Ciudad Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")), ((edtEspectaculoCiudadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoCiudadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoCiudadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoCiudadNombre_Internalname, "Espectaculo Ciudad Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadNombre_Internalname, StringUtil.RTrim( A23EspectaculoCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A23EspectaculoCiudadNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
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
         E11062 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z37VentaId = (short)(context.localUtil.CToN( cgiGet( "Z37VentaId"), ".", ","));
               Z34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "Z34EspectaculoId"), ".", ","));
               Z24VentaPaisId = (short)(context.localUtil.CToN( cgiGet( "Z24VentaPaisId"), ".", ","));
               Z27VentaCiudadId = (short)(context.localUtil.CToN( cgiGet( "Z27VentaCiudadId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "N34EspectaculoId"), ".", ","));
               N24VentaPaisId = (short)(context.localUtil.CToN( cgiGet( "N24VentaPaisId"), ".", ","));
               N27VentaCiudadId = (short)(context.localUtil.CToN( cgiGet( "N27VentaCiudadId"), ".", ","));
               AV7VentaId = (short)(context.localUtil.CToN( cgiGet( "vVENTAID"), ".", ","));
               AV11Insert_EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ESPECTACULOID"), ".", ","));
               AV12Insert_VentaPaisId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_VENTAPAISID"), ".", ","));
               AV13Insert_VentaCiudadId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_VENTACIUDADID"), ".", ","));
               A40000VentaFecha_GXI = cgiGet( "VENTAFECHA_GXI");
               A40001VentaPaisBandera_GXI = cgiGet( "VENTAPAISBANDERA_GXI");
               A40002EspectaculoPaisBandera_GXI = cgiGet( "ESPECTACULOPAISBANDERA_GXI");
               AV15Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VENTAID");
                  AnyError = 1;
                  GX_FocusControl = edtVentaId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A37VentaId = 0;
                  AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               }
               else
               {
                  A37VentaId = (short)(context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ","));
                  AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               }
               A38VentaFecha = cgiGet( imgVentaFecha_Internalname);
               AssignAttri("", false, "A38VentaFecha", A38VentaFecha);
               if ( ( ( context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESPECTACULOID");
                  AnyError = 1;
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A34EspectaculoId = 0;
                  AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               }
               else
               {
                  A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                  AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               }
               A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
               AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
               A36EspectaculoFecha = context.localUtil.CToD( cgiGet( edtEspectaculoFecha_Internalname), 1);
               AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               if ( ( ( context.localUtil.CToN( cgiGet( edtVentaPaisId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVentaPaisId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VENTAPAISID");
                  AnyError = 1;
                  GX_FocusControl = edtVentaPaisId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A24VentaPaisId = 0;
                  AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
               }
               else
               {
                  A24VentaPaisId = (short)(context.localUtil.CToN( cgiGet( edtVentaPaisId_Internalname), ".", ","));
                  AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
               }
               A25VentaPaisNombre = cgiGet( edtVentaPaisNombre_Internalname);
               AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
               A26VentaPaisBandera = cgiGet( imgVentaPaisBandera_Internalname);
               AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
               if ( ( ( context.localUtil.CToN( cgiGet( edtVentaCiudadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVentaCiudadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VENTACIUDADID");
                  AnyError = 1;
                  GX_FocusControl = edtVentaCiudadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A27VentaCiudadId = 0;
                  AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
               }
               else
               {
                  A27VentaCiudadId = (short)(context.localUtil.CToN( cgiGet( edtVentaCiudadId_Internalname), ".", ","));
                  AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
               }
               A28VentaCiudadNombre = cgiGet( edtVentaCiudadNombre_Internalname);
               AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
               A19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ","));
               AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
               A20EspectaculoPaisNombre = cgiGet( edtEspectaculoPaisNombre_Internalname);
               AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
               A21EspectaculoPaisBandera = cgiGet( imgEspectaculoPaisBandera_Internalname);
               AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
               A22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ","));
               AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
               A23EspectaculoCiudadNombre = cgiGet( edtEspectaculoCiudadNombre_Internalname);
               AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgVentaFecha_Internalname, ref  A38VentaFecha, ref  A40000VentaFecha_GXI);
               getMultimediaValue(imgVentaPaisBandera_Internalname, ref  A26VentaPaisBandera, ref  A40001VentaPaisBandera_GXI);
               getMultimediaValue(imgEspectaculoPaisBandera_Internalname, ref  A21EspectaculoPaisBandera, ref  A40002EspectaculoPaisBandera_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Venta");
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A37VentaId != Z37VentaId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("venta:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
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
                  A37VentaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
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
                     sMode8 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode8;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound8 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_060( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "VENTAID");
                        AnyError = 1;
                        GX_FocusControl = edtVentaId_Internalname;
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
                           E11062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12062 ();
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
            E12062 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll068( ) ;
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
            DisableAttributes068( ) ;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls068( ) ;
            }
            else
            {
               CheckExtendedTable068( ) ;
               CloseExtendedTableCursors068( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
         }
      }

      protected void ResetCaption060( )
      {
      }

      protected void E11062( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "GXObligatorio1");
         AV11Insert_EspectaculoId = 0;
         AssignAttri("", false, "AV11Insert_EspectaculoId", StringUtil.LTrimStr( (decimal)(AV11Insert_EspectaculoId), 4, 0));
         AV12Insert_VentaPaisId = 0;
         AssignAttri("", false, "AV12Insert_VentaPaisId", StringUtil.LTrimStr( (decimal)(AV12Insert_VentaPaisId), 4, 0));
         AV13Insert_VentaCiudadId = 0;
         AssignAttri("", false, "AV13Insert_VentaCiudadId", StringUtil.LTrimStr( (decimal)(AV13Insert_VentaCiudadId), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            AssignAttri("", false, "AV16GXV1", StringUtil.LTrimStr( (decimal)(AV16GXV1), 8, 0));
            while ( AV16GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "EspectaculoId") == 0 )
               {
                  AV11Insert_EspectaculoId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_EspectaculoId", StringUtil.LTrimStr( (decimal)(AV11Insert_EspectaculoId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "VentaPaisId") == 0 )
               {
                  AV12Insert_VentaPaisId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV12Insert_VentaPaisId", StringUtil.LTrimStr( (decimal)(AV12Insert_VentaPaisId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "VentaCiudadId") == 0 )
               {
                  AV13Insert_VentaCiudadId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV13Insert_VentaCiudadId", StringUtil.LTrimStr( (decimal)(AV13Insert_VentaCiudadId), 4, 0));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               AssignAttri("", false, "AV16GXV1", StringUtil.LTrimStr( (decimal)(AV16GXV1), 8, 0));
            }
         }
      }

      protected void E12062( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwventa.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM068( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z34EspectaculoId = T00063_A34EspectaculoId[0];
               Z24VentaPaisId = T00063_A24VentaPaisId[0];
               Z27VentaCiudadId = T00063_A27VentaCiudadId[0];
            }
            else
            {
               Z34EspectaculoId = A34EspectaculoId;
               Z24VentaPaisId = A24VentaPaisId;
               Z27VentaCiudadId = A27VentaCiudadId;
            }
         }
         if ( GX_JID == -15 )
         {
            Z37VentaId = A37VentaId;
            Z38VentaFecha = A38VentaFecha;
            Z40000VentaFecha_GXI = A40000VentaFecha_GXI;
            Z34EspectaculoId = A34EspectaculoId;
            Z24VentaPaisId = A24VentaPaisId;
            Z27VentaCiudadId = A27VentaCiudadId;
            Z35EspectaculoNombre = A35EspectaculoNombre;
            Z36EspectaculoFecha = A36EspectaculoFecha;
            Z19EspectaculoPaisId = A19EspectaculoPaisId;
            Z22EspectaculoCiudadId = A22EspectaculoCiudadId;
            Z20EspectaculoPaisNombre = A20EspectaculoPaisNombre;
            Z21EspectaculoPaisBandera = A21EspectaculoPaisBandera;
            Z40002EspectaculoPaisBandera_GXI = A40002EspectaculoPaisBandera_GXI;
            Z23EspectaculoCiudadNombre = A23EspectaculoCiudadNombre;
            Z25VentaPaisNombre = A25VentaPaisNombre;
            Z26VentaPaisBandera = A26VentaPaisBandera;
            Z40001VentaPaisBandera_GXI = A40001VentaPaisBandera_GXI;
            Z28VentaCiudadNombre = A28VentaCiudadNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_34_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESPECTACULOID"+"'), id:'"+"ESPECTACULOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_24_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"VENTAPAISID"+"'), id:'"+"VENTAPAISID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_27_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"VENTAPAISID"+"'), id:'"+"VENTAPAISID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"VENTACIUDADID"+"'), id:'"+"VENTACIUDADID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7VentaId) )
         {
            A37VentaId = AV7VentaId;
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
         if ( ! (0==AV7VentaId) )
         {
            edtVentaId_Enabled = 0;
            AssignProp("", false, edtVentaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaId_Enabled), 5, 0), true);
         }
         else
         {
            edtVentaId_Enabled = 1;
            AssignProp("", false, edtVentaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaId_Enabled), 5, 0), true);
         }
         if ( ! (0==AV7VentaId) )
         {
            edtVentaId_Enabled = 0;
            AssignProp("", false, edtVentaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_EspectaculoId) )
         {
            edtEspectaculoId_Enabled = 0;
            AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         }
         else
         {
            edtEspectaculoId_Enabled = 1;
            AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_VentaPaisId) )
         {
            edtVentaPaisId_Enabled = 0;
            AssignProp("", false, edtVentaPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaPaisId_Enabled), 5, 0), true);
         }
         else
         {
            edtVentaPaisId_Enabled = 1;
            AssignProp("", false, edtVentaPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaPaisId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_VentaCiudadId) )
         {
            edtVentaCiudadId_Enabled = 0;
            AssignProp("", false, edtVentaCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaCiudadId_Enabled), 5, 0), true);
         }
         else
         {
            edtVentaCiudadId_Enabled = 1;
            AssignProp("", false, edtVentaCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaCiudadId_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_VentaCiudadId) )
         {
            A27VentaCiudadId = AV13Insert_VentaCiudadId;
            AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_VentaPaisId) )
         {
            A24VentaPaisId = AV12Insert_VentaPaisId;
            AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_EspectaculoId) )
         {
            A34EspectaculoId = AV11Insert_EspectaculoId;
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
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
            AV15Pgmname = "Venta";
            AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T00065 */
            pr_default.execute(3, new Object[] {A24VentaPaisId});
            A25VentaPaisNombre = T00065_A25VentaPaisNombre[0];
            AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
            A40001VentaPaisBandera_GXI = T00065_A40001VentaPaisBandera_GXI[0];
            AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
            n40001VentaPaisBandera_GXI = T00065_n40001VentaPaisBandera_GXI[0];
            A26VentaPaisBandera = T00065_A26VentaPaisBandera[0];
            AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
            pr_default.close(3);
            /* Using cursor T00066 */
            pr_default.execute(4, new Object[] {A24VentaPaisId, A27VentaCiudadId});
            A28VentaCiudadNombre = T00066_A28VentaCiudadNombre[0];
            AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
            pr_default.close(4);
            /* Using cursor T00064 */
            pr_default.execute(2, new Object[] {A34EspectaculoId});
            A35EspectaculoNombre = T00064_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T00064_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A19EspectaculoPaisId = T00064_A19EspectaculoPaisId[0];
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A22EspectaculoCiudadId = T00064_A22EspectaculoCiudadId[0];
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            pr_default.close(2);
            /* Using cursor T00067 */
            pr_default.execute(5, new Object[] {A19EspectaculoPaisId});
            A20EspectaculoPaisNombre = T00067_A20EspectaculoPaisNombre[0];
            AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A40002EspectaculoPaisBandera_GXI = T00067_A40002EspectaculoPaisBandera_GXI[0];
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            n40002EspectaculoPaisBandera_GXI = T00067_n40002EspectaculoPaisBandera_GXI[0];
            A21EspectaculoPaisBandera = T00067_A21EspectaculoPaisBandera[0];
            AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            pr_default.close(5);
            /* Using cursor T00068 */
            pr_default.execute(6, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
            A23EspectaculoCiudadNombre = T00068_A23EspectaculoCiudadNombre[0];
            AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            pr_default.close(6);
         }
      }

      protected void Load068( )
      {
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound8 = 1;
            A40000VentaFecha_GXI = T00069_A40000VentaFecha_GXI[0];
            AssignProp("", false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
            AssignProp("", false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
            A35EspectaculoNombre = T00069_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T00069_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A25VentaPaisNombre = T00069_A25VentaPaisNombre[0];
            AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
            A40001VentaPaisBandera_GXI = T00069_A40001VentaPaisBandera_GXI[0];
            AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
            n40001VentaPaisBandera_GXI = T00069_n40001VentaPaisBandera_GXI[0];
            A28VentaCiudadNombre = T00069_A28VentaCiudadNombre[0];
            AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
            A20EspectaculoPaisNombre = T00069_A20EspectaculoPaisNombre[0];
            AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A40002EspectaculoPaisBandera_GXI = T00069_A40002EspectaculoPaisBandera_GXI[0];
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            n40002EspectaculoPaisBandera_GXI = T00069_n40002EspectaculoPaisBandera_GXI[0];
            A23EspectaculoCiudadNombre = T00069_A23EspectaculoCiudadNombre[0];
            AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            A34EspectaculoId = T00069_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A24VentaPaisId = T00069_A24VentaPaisId[0];
            AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
            A27VentaCiudadId = T00069_A27VentaCiudadId[0];
            AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
            A19EspectaculoPaisId = T00069_A19EspectaculoPaisId[0];
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A22EspectaculoCiudadId = T00069_A22EspectaculoCiudadId[0];
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            A38VentaFecha = T00069_A38VentaFecha[0];
            AssignAttri("", false, "A38VentaFecha", A38VentaFecha);
            AssignProp("", false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
            AssignProp("", false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
            A26VentaPaisBandera = T00069_A26VentaPaisBandera[0];
            AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
            A21EspectaculoPaisBandera = T00069_A21EspectaculoPaisBandera[0];
            AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            ZM068( -15) ;
         }
         pr_default.close(7);
         OnLoadActions068( ) ;
      }

      protected void OnLoadActions068( )
      {
         AV15Pgmname = "Venta";
         AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable068( )
      {
         nIsDirty_8 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV15Pgmname = "Venta";
         AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A35EspectaculoNombre = T00064_A35EspectaculoNombre[0];
         AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
         A36EspectaculoFecha = T00064_A36EspectaculoFecha[0];
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
         A19EspectaculoPaisId = T00064_A19EspectaculoPaisId[0];
         AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
         A22EspectaculoCiudadId = T00064_A22EspectaculoCiudadId[0];
         AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
         pr_default.close(2);
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A19EspectaculoPaisId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A20EspectaculoPaisNombre = T00067_A20EspectaculoPaisNombre[0];
         AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
         A40002EspectaculoPaisBandera_GXI = T00067_A40002EspectaculoPaisBandera_GXI[0];
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         n40002EspectaculoPaisBandera_GXI = T00067_n40002EspectaculoPaisBandera_GXI[0];
         A21EspectaculoPaisBandera = T00067_A21EspectaculoPaisBandera[0];
         AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         pr_default.close(5);
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A23EspectaculoCiudadNombre = T00068_A23EspectaculoCiudadNombre[0];
         AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
         pr_default.close(6);
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A24VentaPaisId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Venta Pais'.", "ForeignKeyNotFound", 1, "VENTAPAISID");
            AnyError = 1;
            GX_FocusControl = edtVentaPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A25VentaPaisNombre = T00065_A25VentaPaisNombre[0];
         AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
         A40001VentaPaisBandera_GXI = T00065_A40001VentaPaisBandera_GXI[0];
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
         n40001VentaPaisBandera_GXI = T00065_n40001VentaPaisBandera_GXI[0];
         A26VentaPaisBandera = T00065_A26VentaPaisBandera[0];
         AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
         pr_default.close(3);
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A24VentaPaisId, A27VentaCiudadId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Venta Pais'.", "ForeignKeyNotFound", 1, "VENTAPAISID");
            AnyError = 1;
            GX_FocusControl = edtVentaPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A28VentaCiudadNombre = T00066_A28VentaCiudadNombre[0];
         AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors068( )
      {
         pr_default.close(2);
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_16( short A34EspectaculoId )
      {
         /* Using cursor T000610 */
         pr_default.execute(8, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A35EspectaculoNombre = T000610_A35EspectaculoNombre[0];
         AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
         A36EspectaculoFecha = T000610_A36EspectaculoFecha[0];
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
         A19EspectaculoPaisId = T000610_A19EspectaculoPaisId[0];
         AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
         A22EspectaculoCiudadId = T000610_A22EspectaculoCiudadId[0];
         AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A35EspectaculoNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A36EspectaculoFecha, "99/99/99"))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(8) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(8);
      }

      protected void gxLoad_19( short A19EspectaculoPaisId )
      {
         /* Using cursor T000611 */
         pr_default.execute(9, new Object[] {A19EspectaculoPaisId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A20EspectaculoPaisNombre = T000611_A20EspectaculoPaisNombre[0];
         AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
         A40002EspectaculoPaisBandera_GXI = T000611_A40002EspectaculoPaisBandera_GXI[0];
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         n40002EspectaculoPaisBandera_GXI = T000611_n40002EspectaculoPaisBandera_GXI[0];
         A21EspectaculoPaisBandera = T000611_A21EspectaculoPaisBandera[0];
         AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A20EspectaculoPaisNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( A21EspectaculoPaisBandera)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40002EspectaculoPaisBandera_GXI)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(9) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(9);
      }

      protected void gxLoad_20( short A19EspectaculoPaisId ,
                                short A22EspectaculoCiudadId )
      {
         /* Using cursor T000612 */
         pr_default.execute(10, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A23EspectaculoCiudadNombre = T000612_A23EspectaculoCiudadNombre[0];
         AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A23EspectaculoCiudadNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(10) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(10);
      }

      protected void gxLoad_17( short A24VentaPaisId )
      {
         /* Using cursor T000613 */
         pr_default.execute(11, new Object[] {A24VentaPaisId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Venta Pais'.", "ForeignKeyNotFound", 1, "VENTAPAISID");
            AnyError = 1;
            GX_FocusControl = edtVentaPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A25VentaPaisNombre = T000613_A25VentaPaisNombre[0];
         AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
         A40001VentaPaisBandera_GXI = T000613_A40001VentaPaisBandera_GXI[0];
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
         n40001VentaPaisBandera_GXI = T000613_n40001VentaPaisBandera_GXI[0];
         A26VentaPaisBandera = T000613_A26VentaPaisBandera[0];
         AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A25VentaPaisNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( A26VentaPaisBandera)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40001VentaPaisBandera_GXI)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(11) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(11);
      }

      protected void gxLoad_18( short A24VentaPaisId ,
                                short A27VentaCiudadId )
      {
         /* Using cursor T000614 */
         pr_default.execute(12, new Object[] {A24VentaPaisId, A27VentaCiudadId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Venta Pais'.", "ForeignKeyNotFound", 1, "VENTAPAISID");
            AnyError = 1;
            GX_FocusControl = edtVentaPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A28VentaCiudadNombre = T000614_A28VentaCiudadNombre[0];
         AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A28VentaCiudadNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(12) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(12);
      }

      protected void GetKey068( )
      {
         /* Using cursor T000615 */
         pr_default.execute(13, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM068( 15) ;
            RcdFound8 = 1;
            A37VentaId = T00063_A37VentaId[0];
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
            A40000VentaFecha_GXI = T00063_A40000VentaFecha_GXI[0];
            AssignProp("", false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
            AssignProp("", false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
            A34EspectaculoId = T00063_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A24VentaPaisId = T00063_A24VentaPaisId[0];
            AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
            A27VentaCiudadId = T00063_A27VentaCiudadId[0];
            AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
            A38VentaFecha = T00063_A38VentaFecha[0];
            AssignAttri("", false, "A38VentaFecha", A38VentaFecha);
            AssignProp("", false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
            AssignProp("", false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
            Z37VentaId = A37VentaId;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load068( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey068( ) ;
            }
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey068( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode8;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey068( ) ;
         if ( RcdFound8 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound8 = 0;
         /* Using cursor T000616 */
         pr_default.execute(14, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( T000616_A37VentaId[0] < A37VentaId ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( T000616_A37VentaId[0] > A37VentaId ) ) )
            {
               A37VentaId = T000616_A37VentaId[0];
               AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               RcdFound8 = 1;
            }
         }
         pr_default.close(14);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0;
         /* Using cursor T000617 */
         pr_default.execute(15, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T000617_A37VentaId[0] > A37VentaId ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T000617_A37VentaId[0] < A37VentaId ) ) )
            {
               A37VentaId = T000617_A37VentaId[0];
               AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               RcdFound8 = 1;
            }
         }
         pr_default.close(15);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey068( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtVentaId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert068( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A37VentaId != Z37VentaId )
               {
                  A37VentaId = Z37VentaId;
                  AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "VENTAID");
                  AnyError = 1;
                  GX_FocusControl = edtVentaId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtVentaId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update068( ) ;
                  GX_FocusControl = edtVentaId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A37VentaId != Z37VentaId )
               {
                  /* Insert record */
                  GX_FocusControl = edtVentaId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert068( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "VENTAID");
                     AnyError = 1;
                     GX_FocusControl = edtVentaId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtVentaId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert068( ) ;
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
         if ( A37VentaId != Z37VentaId )
         {
            A37VentaId = Z37VentaId;
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "VENTAID");
            AnyError = 1;
            GX_FocusControl = edtVentaId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtVentaId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency068( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A37VentaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Venta"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z34EspectaculoId != T00062_A34EspectaculoId[0] ) || ( Z24VentaPaisId != T00062_A24VentaPaisId[0] ) || ( Z27VentaCiudadId != T00062_A27VentaCiudadId[0] ) )
            {
               if ( Z34EspectaculoId != T00062_A34EspectaculoId[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"EspectaculoId");
                  GXUtil.WriteLogRaw("Old: ",Z34EspectaculoId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A34EspectaculoId[0]);
               }
               if ( Z24VentaPaisId != T00062_A24VentaPaisId[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"VentaPaisId");
                  GXUtil.WriteLogRaw("Old: ",Z24VentaPaisId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A24VentaPaisId[0]);
               }
               if ( Z27VentaCiudadId != T00062_A27VentaCiudadId[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"VentaCiudadId");
                  GXUtil.WriteLogRaw("Old: ",Z27VentaCiudadId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A27VentaCiudadId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Venta"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM068( 0) ;
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000618 */
                     pr_default.execute(16, new Object[] {A37VentaId, A38VentaFecha, A40000VentaFecha_GXI, A34EspectaculoId, A24VentaPaisId, A27VentaCiudadId});
                     pr_default.close(16);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( (pr_default.getStatus(16) == 1) )
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
                           ResetCaption060( ) ;
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
               Load068( ) ;
            }
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void Update068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000619 */
                     pr_default.execute(17, new Object[] {A34EspectaculoId, A24VentaPaisId, A27VentaCiudadId, A37VentaId});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( (pr_default.getStatus(17) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Venta"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate068( ) ;
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
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void DeferredUpdate068( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000620 */
            pr_default.execute(18, new Object[] {A38VentaFecha, A40000VentaFecha_GXI, A37VentaId});
            pr_default.close(18);
            dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls068( ) ;
            AfterConfirm068( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete068( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000621 */
                  pr_default.execute(19, new Object[] {A37VentaId});
                  pr_default.close(19);
                  dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel068( ) ;
         Gx_mode = sMode8;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls068( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "Venta";
            AssignAttri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000622 */
            pr_default.execute(20, new Object[] {A34EspectaculoId});
            A35EspectaculoNombre = T000622_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T000622_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A19EspectaculoPaisId = T000622_A19EspectaculoPaisId[0];
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A22EspectaculoCiudadId = T000622_A22EspectaculoCiudadId[0];
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            pr_default.close(20);
            /* Using cursor T000623 */
            pr_default.execute(21, new Object[] {A19EspectaculoPaisId});
            A20EspectaculoPaisNombre = T000623_A20EspectaculoPaisNombre[0];
            AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A40002EspectaculoPaisBandera_GXI = T000623_A40002EspectaculoPaisBandera_GXI[0];
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            n40002EspectaculoPaisBandera_GXI = T000623_n40002EspectaculoPaisBandera_GXI[0];
            A21EspectaculoPaisBandera = T000623_A21EspectaculoPaisBandera[0];
            AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            pr_default.close(21);
            /* Using cursor T000624 */
            pr_default.execute(22, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
            A23EspectaculoCiudadNombre = T000624_A23EspectaculoCiudadNombre[0];
            AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            pr_default.close(22);
            /* Using cursor T000625 */
            pr_default.execute(23, new Object[] {A24VentaPaisId});
            A25VentaPaisNombre = T000625_A25VentaPaisNombre[0];
            AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
            A40001VentaPaisBandera_GXI = T000625_A40001VentaPaisBandera_GXI[0];
            AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
            n40001VentaPaisBandera_GXI = T000625_n40001VentaPaisBandera_GXI[0];
            A26VentaPaisBandera = T000625_A26VentaPaisBandera[0];
            AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
            AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
            pr_default.close(23);
            /* Using cursor T000626 */
            pr_default.execute(24, new Object[] {A24VentaPaisId, A27VentaCiudadId});
            A28VentaCiudadNombre = T000626_A28VentaCiudadNombre[0];
            AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
            pr_default.close(24);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000627 */
            pr_default.execute(25, new Object[] {A37VentaId});
            if ( (pr_default.getStatus(25) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Entrada"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(25);
         }
      }

      protected void EndLevel068( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete068( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(20);
            pr_default.close(23);
            pr_default.close(24);
            pr_default.close(21);
            pr_default.close(22);
            context.CommitDataStores("venta",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(20);
            pr_default.close(23);
            pr_default.close(24);
            pr_default.close(21);
            pr_default.close(22);
            context.RollbackDataStores("venta",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart068( )
      {
         /* Scan By routine */
         /* Using cursor T000628 */
         pr_default.execute(26);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound8 = 1;
            A37VentaId = T000628_A37VentaId[0];
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext068( )
      {
         /* Scan next routine */
         pr_default.readNext(26);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound8 = 1;
            A37VentaId = T000628_A37VentaId[0];
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
      }

      protected void ScanEnd068( )
      {
         pr_default.close(26);
      }

      protected void AfterConfirm068( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert068( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate068( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete068( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete068( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate068( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes068( )
      {
         edtVentaId_Enabled = 0;
         AssignProp("", false, edtVentaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaId_Enabled), 5, 0), true);
         imgVentaFecha_Enabled = 0;
         AssignProp("", false, imgVentaFecha_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgVentaFecha_Enabled), 5, 0), true);
         edtEspectaculoId_Enabled = 0;
         AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         edtEspectaculoNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoNombre_Enabled), 5, 0), true);
         edtEspectaculoFecha_Enabled = 0;
         AssignProp("", false, edtEspectaculoFecha_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoFecha_Enabled), 5, 0), true);
         edtVentaPaisId_Enabled = 0;
         AssignProp("", false, edtVentaPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaPaisId_Enabled), 5, 0), true);
         edtVentaPaisNombre_Enabled = 0;
         AssignProp("", false, edtVentaPaisNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaPaisNombre_Enabled), 5, 0), true);
         imgVentaPaisBandera_Enabled = 0;
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgVentaPaisBandera_Enabled), 5, 0), true);
         edtVentaCiudadId_Enabled = 0;
         AssignProp("", false, edtVentaCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaCiudadId_Enabled), 5, 0), true);
         edtVentaCiudadNombre_Enabled = 0;
         AssignProp("", false, edtVentaCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaCiudadNombre_Enabled), 5, 0), true);
         edtEspectaculoPaisId_Enabled = 0;
         AssignProp("", false, edtEspectaculoPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoPaisId_Enabled), 5, 0), true);
         edtEspectaculoPaisNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoPaisNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoPaisNombre_Enabled), 5, 0), true);
         imgEspectaculoPaisBandera_Enabled = 0;
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgEspectaculoPaisBandera_Enabled), 5, 0), true);
         edtEspectaculoCiudadId_Enabled = 0;
         AssignProp("", false, edtEspectaculoCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoCiudadId_Enabled), 5, 0), true);
         edtEspectaculoCiudadNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoCiudadNombre_Enabled), 5, 0), true);
      }

      protected void send_integrity_lvl_hashes068( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?202021621491416", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 138086), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("venta.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7VentaId)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Venta");
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("venta:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z37VentaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37VentaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z34EspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z24VentaPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24VentaPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z27VentaCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z27VentaCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N34EspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N24VentaPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24VentaPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N27VentaCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27VentaCiudadId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vVENTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7VentaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vVENTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7VentaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_ESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_VENTAPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_VentaPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_VENTACIUDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_VentaCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "VENTAFECHA_GXI", A40000VentaFecha_GXI);
         GxWebStd.gx_hidden_field( context, "VENTAPAISBANDERA_GXI", A40001VentaPaisBandera_GXI);
         GxWebStd.gx_hidden_field( context, "ESPECTACULOPAISBANDERA_GXI", A40002EspectaculoPaisBandera_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "VENTAFECHA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A38VentaFecha);
         GXCCtlgxBlob = "VENTAPAISBANDERA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A26VentaPaisBandera);
         GXCCtlgxBlob = "ESPECTACULOPAISBANDERA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A21EspectaculoPaisBandera);
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
         return formatLink("venta.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7VentaId) ;
      }

      public override String GetPgmname( )
      {
         return "Venta" ;
      }

      public override String GetPgmdesc( )
      {
         return "Venta" ;
      }

      protected void InitializeNonKey068( )
      {
         A34EspectaculoId = 0;
         AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         A24VentaPaisId = 0;
         AssignAttri("", false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
         A27VentaCiudadId = 0;
         AssignAttri("", false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
         A38VentaFecha = "";
         AssignAttri("", false, "A38VentaFecha", A38VentaFecha);
         AssignProp("", false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
         AssignProp("", false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
         A40000VentaFecha_GXI = "";
         AssignProp("", false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
         AssignProp("", false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
         A35EspectaculoNombre = "";
         AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
         A36EspectaculoFecha = DateTime.MinValue;
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
         A25VentaPaisNombre = "";
         AssignAttri("", false, "A25VentaPaisNombre", A25VentaPaisNombre);
         A26VentaPaisBandera = "";
         AssignAttri("", false, "A26VentaPaisBandera", A26VentaPaisBandera);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
         A40001VentaPaisBandera_GXI = "";
         n40001VentaPaisBandera_GXI = false;
         AssignProp("", false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
         AssignProp("", false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
         A28VentaCiudadNombre = "";
         AssignAttri("", false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
         A19EspectaculoPaisId = 0;
         AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
         A20EspectaculoPaisNombre = "";
         AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
         A21EspectaculoPaisBandera = "";
         AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         A40002EspectaculoPaisBandera_GXI = "";
         n40002EspectaculoPaisBandera_GXI = false;
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40002EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         A22EspectaculoCiudadId = 0;
         AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
         A23EspectaculoCiudadNombre = "";
         AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
         Z34EspectaculoId = 0;
         Z24VentaPaisId = 0;
         Z27VentaCiudadId = 0;
      }

      protected void InitAll068( )
      {
         A37VentaId = 0;
         AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         InitializeNonKey068( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202021621491424", true, true);
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
         context.AddJavascriptSource("venta.js", "?202021621491424", false, true);
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
         edtVentaId_Internalname = "VENTAID";
         imgVentaFecha_Internalname = "VENTAFECHA";
         edtEspectaculoId_Internalname = "ESPECTACULOID";
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = "ESPECTACULOFECHA";
         edtVentaPaisId_Internalname = "VENTAPAISID";
         edtVentaPaisNombre_Internalname = "VENTAPAISNOMBRE";
         imgVentaPaisBandera_Internalname = "VENTAPAISBANDERA";
         edtVentaCiudadId_Internalname = "VENTACIUDADID";
         edtVentaCiudadNombre_Internalname = "VENTACIUDADNOMBRE";
         edtEspectaculoPaisId_Internalname = "ESPECTACULOPAISID";
         edtEspectaculoPaisNombre_Internalname = "ESPECTACULOPAISNOMBRE";
         imgEspectaculoPaisBandera_Internalname = "ESPECTACULOPAISBANDERA";
         edtEspectaculoCiudadId_Internalname = "ESPECTACULOCIUDADID";
         edtEspectaculoCiudadNombre_Internalname = "ESPECTACULOCIUDADNOMBRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_34_Internalname = "PROMPT_34";
         imgprompt_24_Internalname = "PROMPT_24";
         imgprompt_27_Internalname = "PROMPT_27";
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
         Form.Caption = "Venta";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtEspectaculoCiudadNombre_Jsonclick = "";
         edtEspectaculoCiudadNombre_Enabled = 0;
         edtEspectaculoCiudadId_Jsonclick = "";
         edtEspectaculoCiudadId_Enabled = 0;
         imgEspectaculoPaisBandera_Enabled = 0;
         edtEspectaculoPaisNombre_Jsonclick = "";
         edtEspectaculoPaisNombre_Enabled = 0;
         edtEspectaculoPaisId_Jsonclick = "";
         edtEspectaculoPaisId_Enabled = 0;
         edtVentaCiudadNombre_Jsonclick = "";
         edtVentaCiudadNombre_Enabled = 0;
         imgprompt_27_Visible = 1;
         imgprompt_27_Link = "";
         edtVentaCiudadId_Jsonclick = "";
         edtVentaCiudadId_Enabled = 1;
         imgVentaPaisBandera_Enabled = 0;
         edtVentaPaisNombre_Jsonclick = "";
         edtVentaPaisNombre_Enabled = 0;
         imgprompt_24_Visible = 1;
         imgprompt_24_Link = "";
         edtVentaPaisId_Jsonclick = "";
         edtVentaPaisId_Enabled = 1;
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoFecha_Enabled = 0;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Enabled = 0;
         imgprompt_34_Visible = 1;
         imgprompt_34_Link = "";
         edtEspectaculoId_Jsonclick = "";
         edtEspectaculoId_Enabled = 1;
         imgVentaFecha_Enabled = 1;
         edtVentaId_Jsonclick = "";
         edtVentaId_Enabled = 1;
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

      public void Valid_Espectaculoid( )
      {
         n40002EspectaculoPaisBandera_GXI = false;
         /* Using cursor T000622 */
         pr_default.execute(20, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
         }
         A35EspectaculoNombre = T000622_A35EspectaculoNombre[0];
         A36EspectaculoFecha = T000622_A36EspectaculoFecha[0];
         A19EspectaculoPaisId = T000622_A19EspectaculoPaisId[0];
         A22EspectaculoCiudadId = T000622_A22EspectaculoCiudadId[0];
         pr_default.close(20);
         /* Using cursor T000623 */
         pr_default.execute(21, new Object[] {A19EspectaculoPaisId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A20EspectaculoPaisNombre = T000623_A20EspectaculoPaisNombre[0];
         A40002EspectaculoPaisBandera_GXI = T000623_A40002EspectaculoPaisBandera_GXI[0];
         n40002EspectaculoPaisBandera_GXI = T000623_n40002EspectaculoPaisBandera_GXI[0];
         A21EspectaculoPaisBandera = T000623_A21EspectaculoPaisBandera[0];
         pr_default.close(21);
         /* Using cursor T000624 */
         pr_default.execute(22, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A23EspectaculoCiudadNombre = T000624_A23EspectaculoCiudadNombre[0];
         pr_default.close(22);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A35EspectaculoNombre", StringUtil.RTrim( A35EspectaculoNombre));
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
         AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")));
         AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")));
         AssignAttri("", false, "A20EspectaculoPaisNombre", StringUtil.RTrim( A20EspectaculoPaisNombre));
         AssignAttri("", false, "A21EspectaculoPaisBandera", context.PathToRelativeUrl( A21EspectaculoPaisBandera));
         AssignAttri("", false, "A40002EspectaculoPaisBandera_GXI", A40002EspectaculoPaisBandera_GXI);
         AssignAttri("", false, "A23EspectaculoCiudadNombre", StringUtil.RTrim( A23EspectaculoCiudadNombre));
      }

      public void Valid_Ventapaisid( )
      {
         n40001VentaPaisBandera_GXI = false;
         /* Using cursor T000625 */
         pr_default.execute(23, new Object[] {A24VentaPaisId});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No matching 'Venta Pais'.", "ForeignKeyNotFound", 1, "VENTAPAISID");
            AnyError = 1;
            GX_FocusControl = edtVentaPaisId_Internalname;
         }
         A25VentaPaisNombre = T000625_A25VentaPaisNombre[0];
         A40001VentaPaisBandera_GXI = T000625_A40001VentaPaisBandera_GXI[0];
         n40001VentaPaisBandera_GXI = T000625_n40001VentaPaisBandera_GXI[0];
         A26VentaPaisBandera = T000625_A26VentaPaisBandera[0];
         pr_default.close(23);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A25VentaPaisNombre", StringUtil.RTrim( A25VentaPaisNombre));
         AssignAttri("", false, "A26VentaPaisBandera", context.PathToRelativeUrl( A26VentaPaisBandera));
         AssignAttri("", false, "A40001VentaPaisBandera_GXI", A40001VentaPaisBandera_GXI);
      }

      public void Valid_Ventaciudadid( )
      {
         /* Using cursor T000626 */
         pr_default.execute(24, new Object[] {A24VentaPaisId, A27VentaCiudadId});
         if ( (pr_default.getStatus(24) == 101) )
         {
            GX_msglist.addItem("No matching 'Venta Pais'.", "ForeignKeyNotFound", 1, "VENTAPAISID");
            AnyError = 1;
            GX_FocusControl = edtVentaPaisId_Internalname;
         }
         A28VentaCiudadNombre = T000626_A28VentaCiudadNombre[0];
         pr_default.close(24);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A28VentaCiudadNombre", StringUtil.RTrim( A28VentaCiudadNombre));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7VentaId',fld:'vVENTAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7VentaId',fld:'vVENTAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12062',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_VENTAID","{handler:'Valid_Ventaid',iparms:[]");
         setEventMetadata("VALID_VENTAID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOID","{handler:'Valid_Espectaculoid',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'},{av:'A19EspectaculoPaisId',fld:'ESPECTACULOPAISID',pic:'ZZZ9'},{av:'A22EspectaculoCiudadId',fld:'ESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'A35EspectaculoNombre',fld:'ESPECTACULONOMBRE',pic:''},{av:'A36EspectaculoFecha',fld:'ESPECTACULOFECHA',pic:''},{av:'A20EspectaculoPaisNombre',fld:'ESPECTACULOPAISNOMBRE',pic:''},{av:'A21EspectaculoPaisBandera',fld:'ESPECTACULOPAISBANDERA',pic:''},{av:'A40002EspectaculoPaisBandera_GXI',fld:'ESPECTACULOPAISBANDERA_GXI',pic:''},{av:'A23EspectaculoCiudadNombre',fld:'ESPECTACULOCIUDADNOMBRE',pic:''}]");
         setEventMetadata("VALID_ESPECTACULOID",",oparms:[{av:'A35EspectaculoNombre',fld:'ESPECTACULONOMBRE',pic:''},{av:'A36EspectaculoFecha',fld:'ESPECTACULOFECHA',pic:''},{av:'A19EspectaculoPaisId',fld:'ESPECTACULOPAISID',pic:'ZZZ9'},{av:'A22EspectaculoCiudadId',fld:'ESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'A20EspectaculoPaisNombre',fld:'ESPECTACULOPAISNOMBRE',pic:''},{av:'A21EspectaculoPaisBandera',fld:'ESPECTACULOPAISBANDERA',pic:''},{av:'A40002EspectaculoPaisBandera_GXI',fld:'ESPECTACULOPAISBANDERA_GXI',pic:''},{av:'A23EspectaculoCiudadNombre',fld:'ESPECTACULOCIUDADNOMBRE',pic:''}]}");
         setEventMetadata("VALID_VENTAPAISID","{handler:'Valid_Ventapaisid',iparms:[{av:'A24VentaPaisId',fld:'VENTAPAISID',pic:'ZZZ9'},{av:'A25VentaPaisNombre',fld:'VENTAPAISNOMBRE',pic:''},{av:'A26VentaPaisBandera',fld:'VENTAPAISBANDERA',pic:''},{av:'A40001VentaPaisBandera_GXI',fld:'VENTAPAISBANDERA_GXI',pic:''}]");
         setEventMetadata("VALID_VENTAPAISID",",oparms:[{av:'A25VentaPaisNombre',fld:'VENTAPAISNOMBRE',pic:''},{av:'A26VentaPaisBandera',fld:'VENTAPAISBANDERA',pic:''},{av:'A40001VentaPaisBandera_GXI',fld:'VENTAPAISBANDERA_GXI',pic:''}]}");
         setEventMetadata("VALID_VENTACIUDADID","{handler:'Valid_Ventaciudadid',iparms:[{av:'A24VentaPaisId',fld:'VENTAPAISID',pic:'ZZZ9'},{av:'A27VentaCiudadId',fld:'VENTACIUDADID',pic:'ZZZ9'},{av:'A28VentaCiudadNombre',fld:'VENTACIUDADNOMBRE',pic:''}]");
         setEventMetadata("VALID_VENTACIUDADID",",oparms:[{av:'A28VentaCiudadNombre',fld:'VENTACIUDADNOMBRE',pic:''}]}");
         setEventMetadata("VALID_ESPECTACULOPAISID","{handler:'Valid_Espectaculopaisid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOPAISID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOCIUDADID","{handler:'Valid_Espectaculociudadid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOCIUDADID",",oparms:[]}");
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
         pr_default.close(20);
         pr_default.close(23);
         pr_default.close(24);
         pr_default.close(21);
         pr_default.close(22);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
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
         A38VentaFecha = "";
         A40000VentaFecha_GXI = "";
         sImgUrl = "";
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A25VentaPaisNombre = "";
         A26VentaPaisBandera = "";
         A40001VentaPaisBandera_GXI = "";
         A28VentaCiudadNombre = "";
         A20EspectaculoPaisNombre = "";
         A21EspectaculoPaisBandera = "";
         A40002EspectaculoPaisBandera_GXI = "";
         A23EspectaculoCiudadNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV15Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode8 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z38VentaFecha = "";
         Z40000VentaFecha_GXI = "";
         Z35EspectaculoNombre = "";
         Z36EspectaculoFecha = DateTime.MinValue;
         Z20EspectaculoPaisNombre = "";
         Z21EspectaculoPaisBandera = "";
         Z40002EspectaculoPaisBandera_GXI = "";
         Z23EspectaculoCiudadNombre = "";
         Z25VentaPaisNombre = "";
         Z26VentaPaisBandera = "";
         Z40001VentaPaisBandera_GXI = "";
         Z28VentaCiudadNombre = "";
         T00065_A25VentaPaisNombre = new String[] {""} ;
         T00065_A40001VentaPaisBandera_GXI = new String[] {""} ;
         T00065_n40001VentaPaisBandera_GXI = new bool[] {false} ;
         T00065_A26VentaPaisBandera = new String[] {""} ;
         T00066_A28VentaCiudadNombre = new String[] {""} ;
         T00064_A35EspectaculoNombre = new String[] {""} ;
         T00064_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T00064_A19EspectaculoPaisId = new short[1] ;
         T00064_A22EspectaculoCiudadId = new short[1] ;
         T00067_A20EspectaculoPaisNombre = new String[] {""} ;
         T00067_A40002EspectaculoPaisBandera_GXI = new String[] {""} ;
         T00067_n40002EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T00067_A21EspectaculoPaisBandera = new String[] {""} ;
         T00068_A23EspectaculoCiudadNombre = new String[] {""} ;
         T00069_A37VentaId = new short[1] ;
         T00069_A40000VentaFecha_GXI = new String[] {""} ;
         T00069_A35EspectaculoNombre = new String[] {""} ;
         T00069_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T00069_A25VentaPaisNombre = new String[] {""} ;
         T00069_A40001VentaPaisBandera_GXI = new String[] {""} ;
         T00069_n40001VentaPaisBandera_GXI = new bool[] {false} ;
         T00069_A28VentaCiudadNombre = new String[] {""} ;
         T00069_A20EspectaculoPaisNombre = new String[] {""} ;
         T00069_A40002EspectaculoPaisBandera_GXI = new String[] {""} ;
         T00069_n40002EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T00069_A23EspectaculoCiudadNombre = new String[] {""} ;
         T00069_A34EspectaculoId = new short[1] ;
         T00069_A24VentaPaisId = new short[1] ;
         T00069_A27VentaCiudadId = new short[1] ;
         T00069_A19EspectaculoPaisId = new short[1] ;
         T00069_A22EspectaculoCiudadId = new short[1] ;
         T00069_A38VentaFecha = new String[] {""} ;
         T00069_A26VentaPaisBandera = new String[] {""} ;
         T00069_A21EspectaculoPaisBandera = new String[] {""} ;
         T000610_A35EspectaculoNombre = new String[] {""} ;
         T000610_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T000610_A19EspectaculoPaisId = new short[1] ;
         T000610_A22EspectaculoCiudadId = new short[1] ;
         T000611_A20EspectaculoPaisNombre = new String[] {""} ;
         T000611_A40002EspectaculoPaisBandera_GXI = new String[] {""} ;
         T000611_n40002EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T000611_A21EspectaculoPaisBandera = new String[] {""} ;
         T000612_A23EspectaculoCiudadNombre = new String[] {""} ;
         T000613_A25VentaPaisNombre = new String[] {""} ;
         T000613_A40001VentaPaisBandera_GXI = new String[] {""} ;
         T000613_n40001VentaPaisBandera_GXI = new bool[] {false} ;
         T000613_A26VentaPaisBandera = new String[] {""} ;
         T000614_A28VentaCiudadNombre = new String[] {""} ;
         T000615_A37VentaId = new short[1] ;
         T00063_A37VentaId = new short[1] ;
         T00063_A40000VentaFecha_GXI = new String[] {""} ;
         T00063_A34EspectaculoId = new short[1] ;
         T00063_A24VentaPaisId = new short[1] ;
         T00063_A27VentaCiudadId = new short[1] ;
         T00063_A38VentaFecha = new String[] {""} ;
         T000616_A37VentaId = new short[1] ;
         T000617_A37VentaId = new short[1] ;
         T00062_A37VentaId = new short[1] ;
         T00062_A40000VentaFecha_GXI = new String[] {""} ;
         T00062_A34EspectaculoId = new short[1] ;
         T00062_A24VentaPaisId = new short[1] ;
         T00062_A27VentaCiudadId = new short[1] ;
         T00062_A38VentaFecha = new String[] {""} ;
         T000622_A35EspectaculoNombre = new String[] {""} ;
         T000622_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T000622_A19EspectaculoPaisId = new short[1] ;
         T000622_A22EspectaculoCiudadId = new short[1] ;
         T000623_A20EspectaculoPaisNombre = new String[] {""} ;
         T000623_A40002EspectaculoPaisBandera_GXI = new String[] {""} ;
         T000623_n40002EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T000623_A21EspectaculoPaisBandera = new String[] {""} ;
         T000624_A23EspectaculoCiudadNombre = new String[] {""} ;
         T000625_A25VentaPaisNombre = new String[] {""} ;
         T000625_A40001VentaPaisBandera_GXI = new String[] {""} ;
         T000625_n40001VentaPaisBandera_GXI = new bool[] {false} ;
         T000625_A26VentaPaisBandera = new String[] {""} ;
         T000626_A28VentaCiudadNombre = new String[] {""} ;
         T000627_A39EntradaId = new short[1] ;
         T000628_A37VentaId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.venta__default(),
            new Object[][] {
                new Object[] {
               T00062_A37VentaId, T00062_A40000VentaFecha_GXI, T00062_A34EspectaculoId, T00062_A24VentaPaisId, T00062_A27VentaCiudadId, T00062_A38VentaFecha
               }
               , new Object[] {
               T00063_A37VentaId, T00063_A40000VentaFecha_GXI, T00063_A34EspectaculoId, T00063_A24VentaPaisId, T00063_A27VentaCiudadId, T00063_A38VentaFecha
               }
               , new Object[] {
               T00064_A35EspectaculoNombre, T00064_A36EspectaculoFecha, T00064_A19EspectaculoPaisId, T00064_A22EspectaculoCiudadId
               }
               , new Object[] {
               T00065_A25VentaPaisNombre, T00065_A40001VentaPaisBandera_GXI, T00065_n40001VentaPaisBandera_GXI, T00065_A26VentaPaisBandera
               }
               , new Object[] {
               T00066_A28VentaCiudadNombre
               }
               , new Object[] {
               T00067_A20EspectaculoPaisNombre, T00067_A40002EspectaculoPaisBandera_GXI, T00067_n40002EspectaculoPaisBandera_GXI, T00067_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T00068_A23EspectaculoCiudadNombre
               }
               , new Object[] {
               T00069_A37VentaId, T00069_A40000VentaFecha_GXI, T00069_A35EspectaculoNombre, T00069_A36EspectaculoFecha, T00069_A25VentaPaisNombre, T00069_A40001VentaPaisBandera_GXI, T00069_n40001VentaPaisBandera_GXI, T00069_A28VentaCiudadNombre, T00069_A20EspectaculoPaisNombre, T00069_A40002EspectaculoPaisBandera_GXI,
               T00069_n40002EspectaculoPaisBandera_GXI, T00069_A23EspectaculoCiudadNombre, T00069_A34EspectaculoId, T00069_A24VentaPaisId, T00069_A27VentaCiudadId, T00069_A19EspectaculoPaisId, T00069_A22EspectaculoCiudadId, T00069_A38VentaFecha, T00069_A26VentaPaisBandera, T00069_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T000610_A35EspectaculoNombre, T000610_A36EspectaculoFecha, T000610_A19EspectaculoPaisId, T000610_A22EspectaculoCiudadId
               }
               , new Object[] {
               T000611_A20EspectaculoPaisNombre, T000611_A40002EspectaculoPaisBandera_GXI, T000611_n40002EspectaculoPaisBandera_GXI, T000611_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T000612_A23EspectaculoCiudadNombre
               }
               , new Object[] {
               T000613_A25VentaPaisNombre, T000613_A40001VentaPaisBandera_GXI, T000613_n40001VentaPaisBandera_GXI, T000613_A26VentaPaisBandera
               }
               , new Object[] {
               T000614_A28VentaCiudadNombre
               }
               , new Object[] {
               T000615_A37VentaId
               }
               , new Object[] {
               T000616_A37VentaId
               }
               , new Object[] {
               T000617_A37VentaId
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
               T000622_A35EspectaculoNombre, T000622_A36EspectaculoFecha, T000622_A19EspectaculoPaisId, T000622_A22EspectaculoCiudadId
               }
               , new Object[] {
               T000623_A20EspectaculoPaisNombre, T000623_A40002EspectaculoPaisBandera_GXI, T000623_n40002EspectaculoPaisBandera_GXI, T000623_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T000624_A23EspectaculoCiudadNombre
               }
               , new Object[] {
               T000625_A25VentaPaisNombre, T000625_A40001VentaPaisBandera_GXI, T000625_n40001VentaPaisBandera_GXI, T000625_A26VentaPaisBandera
               }
               , new Object[] {
               T000626_A28VentaCiudadNombre
               }
               , new Object[] {
               T000627_A39EntradaId
               }
               , new Object[] {
               T000628_A37VentaId
               }
            }
         );
         AV15Pgmname = "Venta";
      }

      private short wcpOAV7VentaId ;
      private short Z37VentaId ;
      private short Z34EspectaculoId ;
      private short Z24VentaPaisId ;
      private short Z27VentaCiudadId ;
      private short N34EspectaculoId ;
      private short N24VentaPaisId ;
      private short N27VentaCiudadId ;
      private short GxWebError ;
      private short A34EspectaculoId ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short A24VentaPaisId ;
      private short A27VentaCiudadId ;
      private short AV7VentaId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A37VentaId ;
      private short AV11Insert_EspectaculoId ;
      private short AV12Insert_VentaPaisId ;
      private short AV13Insert_VentaCiudadId ;
      private short RcdFound8 ;
      private short GX_JID ;
      private short Z19EspectaculoPaisId ;
      private short Z22EspectaculoCiudadId ;
      private short Gx_BScreen ;
      private short nIsDirty_8 ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtVentaId_Enabled ;
      private int imgVentaFecha_Enabled ;
      private int edtEspectaculoId_Enabled ;
      private int imgprompt_34_Visible ;
      private int edtEspectaculoNombre_Enabled ;
      private int edtEspectaculoFecha_Enabled ;
      private int edtVentaPaisId_Enabled ;
      private int imgprompt_24_Visible ;
      private int edtVentaPaisNombre_Enabled ;
      private int imgVentaPaisBandera_Enabled ;
      private int edtVentaCiudadId_Enabled ;
      private int imgprompt_27_Visible ;
      private int edtVentaCiudadNombre_Enabled ;
      private int edtEspectaculoPaisId_Enabled ;
      private int edtEspectaculoPaisNombre_Enabled ;
      private int imgEspectaculoPaisBandera_Enabled ;
      private int edtEspectaculoCiudadId_Enabled ;
      private int edtEspectaculoCiudadNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV16GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtVentaId_Internalname ;
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
      private String edtVentaId_Jsonclick ;
      private String imgVentaFecha_Internalname ;
      private String sImgUrl ;
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoId_Jsonclick ;
      private String imgprompt_34_Internalname ;
      private String imgprompt_34_Link ;
      private String edtEspectaculoNombre_Internalname ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtVentaPaisId_Internalname ;
      private String edtVentaPaisId_Jsonclick ;
      private String imgprompt_24_Internalname ;
      private String imgprompt_24_Link ;
      private String edtVentaPaisNombre_Internalname ;
      private String A25VentaPaisNombre ;
      private String edtVentaPaisNombre_Jsonclick ;
      private String imgVentaPaisBandera_Internalname ;
      private String edtVentaCiudadId_Internalname ;
      private String edtVentaCiudadId_Jsonclick ;
      private String imgprompt_27_Internalname ;
      private String imgprompt_27_Link ;
      private String edtVentaCiudadNombre_Internalname ;
      private String A28VentaCiudadNombre ;
      private String edtVentaCiudadNombre_Jsonclick ;
      private String edtEspectaculoPaisId_Internalname ;
      private String edtEspectaculoPaisId_Jsonclick ;
      private String edtEspectaculoPaisNombre_Internalname ;
      private String A20EspectaculoPaisNombre ;
      private String edtEspectaculoPaisNombre_Jsonclick ;
      private String imgEspectaculoPaisBandera_Internalname ;
      private String edtEspectaculoCiudadId_Internalname ;
      private String edtEspectaculoCiudadId_Jsonclick ;
      private String edtEspectaculoCiudadNombre_Internalname ;
      private String A23EspectaculoCiudadNombre ;
      private String edtEspectaculoCiudadNombre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV15Pgmname ;
      private String hsh ;
      private String sMode8 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z35EspectaculoNombre ;
      private String Z20EspectaculoPaisNombre ;
      private String Z23EspectaculoCiudadNombre ;
      private String Z25VentaPaisNombre ;
      private String Z28VentaCiudadNombre ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private DateTime A36EspectaculoFecha ;
      private DateTime Z36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A38VentaFecha_IsBlob ;
      private bool A26VentaPaisBandera_IsBlob ;
      private bool A21EspectaculoPaisBandera_IsBlob ;
      private bool returnInSub ;
      private bool n40001VentaPaisBandera_GXI ;
      private bool n40002EspectaculoPaisBandera_GXI ;
      private String A40000VentaFecha_GXI ;
      private String A40001VentaPaisBandera_GXI ;
      private String A40002EspectaculoPaisBandera_GXI ;
      private String Z40000VentaFecha_GXI ;
      private String Z40002EspectaculoPaisBandera_GXI ;
      private String Z40001VentaPaisBandera_GXI ;
      private String A38VentaFecha ;
      private String A26VentaPaisBandera ;
      private String A21EspectaculoPaisBandera ;
      private String Z38VentaFecha ;
      private String Z21EspectaculoPaisBandera ;
      private String Z26VentaPaisBandera ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00065_A25VentaPaisNombre ;
      private String[] T00065_A40001VentaPaisBandera_GXI ;
      private bool[] T00065_n40001VentaPaisBandera_GXI ;
      private String[] T00065_A26VentaPaisBandera ;
      private String[] T00066_A28VentaCiudadNombre ;
      private String[] T00064_A35EspectaculoNombre ;
      private DateTime[] T00064_A36EspectaculoFecha ;
      private short[] T00064_A19EspectaculoPaisId ;
      private short[] T00064_A22EspectaculoCiudadId ;
      private String[] T00067_A20EspectaculoPaisNombre ;
      private String[] T00067_A40002EspectaculoPaisBandera_GXI ;
      private bool[] T00067_n40002EspectaculoPaisBandera_GXI ;
      private String[] T00067_A21EspectaculoPaisBandera ;
      private String[] T00068_A23EspectaculoCiudadNombre ;
      private short[] T00069_A37VentaId ;
      private String[] T00069_A40000VentaFecha_GXI ;
      private String[] T00069_A35EspectaculoNombre ;
      private DateTime[] T00069_A36EspectaculoFecha ;
      private String[] T00069_A25VentaPaisNombre ;
      private String[] T00069_A40001VentaPaisBandera_GXI ;
      private bool[] T00069_n40001VentaPaisBandera_GXI ;
      private String[] T00069_A28VentaCiudadNombre ;
      private String[] T00069_A20EspectaculoPaisNombre ;
      private String[] T00069_A40002EspectaculoPaisBandera_GXI ;
      private bool[] T00069_n40002EspectaculoPaisBandera_GXI ;
      private String[] T00069_A23EspectaculoCiudadNombre ;
      private short[] T00069_A34EspectaculoId ;
      private short[] T00069_A24VentaPaisId ;
      private short[] T00069_A27VentaCiudadId ;
      private short[] T00069_A19EspectaculoPaisId ;
      private short[] T00069_A22EspectaculoCiudadId ;
      private String[] T00069_A38VentaFecha ;
      private String[] T00069_A26VentaPaisBandera ;
      private String[] T00069_A21EspectaculoPaisBandera ;
      private String[] T000610_A35EspectaculoNombre ;
      private DateTime[] T000610_A36EspectaculoFecha ;
      private short[] T000610_A19EspectaculoPaisId ;
      private short[] T000610_A22EspectaculoCiudadId ;
      private String[] T000611_A20EspectaculoPaisNombre ;
      private String[] T000611_A40002EspectaculoPaisBandera_GXI ;
      private bool[] T000611_n40002EspectaculoPaisBandera_GXI ;
      private String[] T000611_A21EspectaculoPaisBandera ;
      private String[] T000612_A23EspectaculoCiudadNombre ;
      private String[] T000613_A25VentaPaisNombre ;
      private String[] T000613_A40001VentaPaisBandera_GXI ;
      private bool[] T000613_n40001VentaPaisBandera_GXI ;
      private String[] T000613_A26VentaPaisBandera ;
      private String[] T000614_A28VentaCiudadNombre ;
      private short[] T000615_A37VentaId ;
      private short[] T00063_A37VentaId ;
      private String[] T00063_A40000VentaFecha_GXI ;
      private short[] T00063_A34EspectaculoId ;
      private short[] T00063_A24VentaPaisId ;
      private short[] T00063_A27VentaCiudadId ;
      private String[] T00063_A38VentaFecha ;
      private short[] T000616_A37VentaId ;
      private short[] T000617_A37VentaId ;
      private short[] T00062_A37VentaId ;
      private String[] T00062_A40000VentaFecha_GXI ;
      private short[] T00062_A34EspectaculoId ;
      private short[] T00062_A24VentaPaisId ;
      private short[] T00062_A27VentaCiudadId ;
      private String[] T00062_A38VentaFecha ;
      private String[] T000622_A35EspectaculoNombre ;
      private DateTime[] T000622_A36EspectaculoFecha ;
      private short[] T000622_A19EspectaculoPaisId ;
      private short[] T000622_A22EspectaculoCiudadId ;
      private String[] T000623_A20EspectaculoPaisNombre ;
      private String[] T000623_A40002EspectaculoPaisBandera_GXI ;
      private bool[] T000623_n40002EspectaculoPaisBandera_GXI ;
      private String[] T000623_A21EspectaculoPaisBandera ;
      private String[] T000624_A23EspectaculoCiudadNombre ;
      private String[] T000625_A25VentaPaisNombre ;
      private String[] T000625_A40001VentaPaisBandera_GXI ;
      private bool[] T000625_n40001VentaPaisBandera_GXI ;
      private String[] T000625_A26VentaPaisBandera ;
      private String[] T000626_A28VentaCiudadNombre ;
      private short[] T000627_A39EntradaId ;
      private short[] T000628_A37VentaId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class venta__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000617 ;
          prmT000617 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000618 ;
          prmT000618 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaFecha",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@VentaFecha_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000619 ;
          prmT000619 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000620 ;
          prmT000620 = new Object[] {
          new Object[] {"@VentaFecha",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@VentaFecha_GXI",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000621 ;
          prmT000621 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000627 ;
          prmT000627 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000628 ;
          prmT000628 = new Object[] {
          } ;
          Object[] prmT000622 ;
          prmT000622 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000623 ;
          prmT000623 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000624 ;
          prmT000624 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000625 ;
          prmT000625 = new Object[] {
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000626 ;
          prmT000626 = new Object[] {
          new Object[] {"@VentaPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [VentaId], [VentaFecha_GXI], [EspectaculoId], [VentaPaisId] AS VentaPaisId, [VentaCiudadId] AS VentaCiudadId, [VentaFecha] FROM [Venta] WITH (UPDLOCK) WHERE [VentaId] = @VentaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00063", "SELECT [VentaId], [VentaFecha_GXI], [EspectaculoId], [VentaPaisId] AS VentaPaisId, [VentaCiudadId] AS VentaCiudadId, [VentaFecha] FROM [Venta] WHERE [VentaId] = @VentaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00064", "SELECT [EspectaculoNombre], [EspectaculoFecha], [EspectaculoPaisId] AS EspectaculoPaisId, [EspectaculoCiudadId] AS EspectaculoCiudadId FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00065", "SELECT [PaisNombre] AS VentaPaisNombre, [PaisBandera_GXI] AS VentaPaisBandera_GXI, [PaisBandera] AS VentaPaisBandera FROM [Pais] WHERE [PaisId] = @VentaPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00066", "SELECT [CiudadNombre] AS VentaCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @VentaPaisId AND [CiudadId] = @VentaCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00067", "SELECT [PaisNombre] AS EspectaculoPaisNombre, [PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, [PaisBandera] AS EspectaculoPaisBandera FROM [Pais] WHERE [PaisId] = @EspectaculoPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00068", "SELECT [CiudadNombre] AS EspectaculoCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @EspectaculoPaisId AND [CiudadId] = @EspectaculoCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00069", "SELECT TM1.[VentaId], TM1.[VentaFecha_GXI], T2.[EspectaculoNombre], T2.[EspectaculoFecha], T5.[PaisNombre] AS VentaPaisNombre, T5.[PaisBandera_GXI] AS VentaPaisBandera_GXI, T6.[CiudadNombre] AS VentaCiudadNombre, T3.[PaisNombre] AS EspectaculoPaisNombre, T3.[PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, T4.[CiudadNombre] AS EspectaculoCiudadNombre, TM1.[EspectaculoId], TM1.[VentaPaisId] AS VentaPaisId, TM1.[VentaCiudadId] AS VentaCiudadId, T2.[EspectaculoPaisId] AS EspectaculoPaisId, T2.[EspectaculoCiudadId] AS EspectaculoCiudadId, TM1.[VentaFecha], T5.[PaisBandera] AS VentaPaisBandera, T3.[PaisBandera] AS EspectaculoPaisBandera FROM ((((([Venta] TM1 INNER JOIN [Espectaculo] T2 ON T2.[EspectaculoId] = TM1.[EspectaculoId]) INNER JOIN [Pais] T3 ON T3.[PaisId] = T2.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T4 ON T4.[PaisId] = T2.[EspectaculoPaisId] AND T4.[CiudadId] = T2.[EspectaculoCiudadId]) INNER JOIN [Pais] T5 ON T5.[PaisId] = TM1.[VentaPaisId]) INNER JOIN [PaisCiudad] T6 ON T6.[PaisId] = TM1.[VentaPaisId] AND T6.[CiudadId] = TM1.[VentaCiudadId]) WHERE TM1.[VentaId] = @VentaId ORDER BY TM1.[VentaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000610", "SELECT [EspectaculoNombre], [EspectaculoFecha], [EspectaculoPaisId] AS EspectaculoPaisId, [EspectaculoCiudadId] AS EspectaculoCiudadId FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000611", "SELECT [PaisNombre] AS EspectaculoPaisNombre, [PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, [PaisBandera] AS EspectaculoPaisBandera FROM [Pais] WHERE [PaisId] = @EspectaculoPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000612", "SELECT [CiudadNombre] AS EspectaculoCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @EspectaculoPaisId AND [CiudadId] = @EspectaculoCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000612,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000613", "SELECT [PaisNombre] AS VentaPaisNombre, [PaisBandera_GXI] AS VentaPaisBandera_GXI, [PaisBandera] AS VentaPaisBandera FROM [Pais] WHERE [PaisId] = @VentaPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000614", "SELECT [CiudadNombre] AS VentaCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @VentaPaisId AND [CiudadId] = @VentaCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000615", "SELECT [VentaId] FROM [Venta] WHERE [VentaId] = @VentaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000616", "SELECT TOP 1 [VentaId] FROM [Venta] WHERE ( [VentaId] > @VentaId) ORDER BY [VentaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000616,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000617", "SELECT TOP 1 [VentaId] FROM [Venta] WHERE ( [VentaId] < @VentaId) ORDER BY [VentaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000617,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000618", "INSERT INTO [Venta]([VentaId], [VentaFecha], [VentaFecha_GXI], [EspectaculoId], [VentaPaisId], [VentaCiudadId]) VALUES(@VentaId, @VentaFecha, @VentaFecha_GXI, @EspectaculoId, @VentaPaisId, @VentaCiudadId)", GxErrorMask.GX_NOMASK,prmT000618)
             ,new CursorDef("T000619", "UPDATE [Venta] SET [EspectaculoId]=@EspectaculoId, [VentaPaisId]=@VentaPaisId, [VentaCiudadId]=@VentaCiudadId  WHERE [VentaId] = @VentaId", GxErrorMask.GX_NOMASK,prmT000619)
             ,new CursorDef("T000620", "UPDATE [Venta] SET [VentaFecha]=@VentaFecha, [VentaFecha_GXI]=@VentaFecha_GXI  WHERE [VentaId] = @VentaId", GxErrorMask.GX_NOMASK,prmT000620)
             ,new CursorDef("T000621", "DELETE FROM [Venta]  WHERE [VentaId] = @VentaId", GxErrorMask.GX_NOMASK,prmT000621)
             ,new CursorDef("T000622", "SELECT [EspectaculoNombre], [EspectaculoFecha], [EspectaculoPaisId] AS EspectaculoPaisId, [EspectaculoCiudadId] AS EspectaculoCiudadId FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000622,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000623", "SELECT [PaisNombre] AS EspectaculoPaisNombre, [PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, [PaisBandera] AS EspectaculoPaisBandera FROM [Pais] WHERE [PaisId] = @EspectaculoPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000623,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000624", "SELECT [CiudadNombre] AS EspectaculoCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @EspectaculoPaisId AND [CiudadId] = @EspectaculoCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000624,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000625", "SELECT [PaisNombre] AS VentaPaisNombre, [PaisBandera_GXI] AS VentaPaisBandera_GXI, [PaisBandera] AS VentaPaisBandera FROM [Pais] WHERE [PaisId] = @VentaPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000625,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000626", "SELECT [CiudadNombre] AS VentaCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @VentaPaisId AND [CiudadId] = @VentaCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000626,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000627", "SELECT TOP 1 [EntradaId] FROM [Entrada] WHERE [VentaId] = @VentaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000627,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000628", "SELECT [VentaId] FROM [Venta] ORDER BY [VentaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000628,100, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(2)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(2)) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 100) ;
                ((String[]) buf[8])[0] = rslt.getString(8, 100) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaUri(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((String[]) buf[11])[0] = rslt.getString(10, 100) ;
                ((short[]) buf[12])[0] = rslt.getShort(11) ;
                ((short[]) buf[13])[0] = rslt.getShort(12) ;
                ((short[]) buf[14])[0] = rslt.getShort(13) ;
                ((short[]) buf[15])[0] = rslt.getShort(14) ;
                ((short[]) buf[16])[0] = rslt.getShort(15) ;
                ((String[]) buf[17])[0] = rslt.getMultimediaFile(16, rslt.getVarchar(2)) ;
                ((String[]) buf[18])[0] = rslt.getMultimediaFile(17, rslt.getVarchar(6)) ;
                ((String[]) buf[19])[0] = rslt.getMultimediaFile(18, rslt.getVarchar(9)) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 26 :
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
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameterBlob(2, (String)parms[1], false);
                stmt.SetParameterMultimedia(3, (String)parms[2], (String)parms[1], "Venta", "VentaFecha");
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 18 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Venta", "VentaFecha");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
