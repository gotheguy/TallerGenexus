/*
               File: Venta
        Description: Venta
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:25.5
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action20") == 0 )
         {
            A37VentaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_20_068( A37VentaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_22") == 0 )
         {
            A34EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_22( A34EspectaculoId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_23") == 0 )
         {
            A34EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A11LocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_23( A34EspectaculoId, A11LocalidadId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_24") == 0 )
         {
            A34EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A11LocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            A17SectorId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_24( A34EspectaculoId, A11LocalidadId, A17SectorId) ;
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
               AV20VentaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV20VentaId", StringUtil.LTrimStr( (decimal)(AV20VentaId), 4, 0));
               AssignAttri("", false, "gxhash_vVENTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20VentaId), "ZZZ9"), context));
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
         GX_FocusControl = edtEspectaculoId_Internalname;
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
         this.AV20VentaId = aP1_VentaId;
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
         GxWebStd.gx_single_line_edit( context, edtVentaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")), ((edtVentaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
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
         GxWebStd.gx_single_line_edit( context, edtEspectaculoFecha_Internalname, context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"), context.localUtil.Format( A36EspectaculoFecha, "99/99/9999"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoFecha_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_bitmap( context, edtEspectaculoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEspectaculoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Venta.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadId_Internalname, "Localidad Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_11_Internalname, sImgUrl, imgprompt_11_Link, "", "", context.GetTheme( ), imgprompt_11_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadNombre_Internalname, "Localidad Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtLocalidadNombre_Internalname, StringUtil.RTrim( A12LocalidadNombre), StringUtil.RTrim( context.localUtil.Format( A12LocalidadNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadPrecio_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadPrecio_Internalname, "Localidad Precio", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtLocalidadPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")), ((edtLocalidadPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")) : context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadPrecio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadPrecio_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadCapacidad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadCapacidad_Internalname, "Localidad Capacidad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtLocalidadCapacidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")), ((edtLocalidadCapacidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")) : context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadCapacidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadCapacidad_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaCantidadEntradas_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtVentaCantidadEntradas_Internalname, "Cantidad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtVentaCantidadEntradas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A43VentaCantidadEntradas), 4, 0, ".", "")), ((edtVentaCantidadEntradas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A43VentaCantidadEntradas), "ZZZ9")) : context.localUtil.Format( (decimal)(A43VentaCantidadEntradas), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaCantidadEntradas_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVentaCantidadEntradas_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSectorId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtSectorId_Internalname, "Sector Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtSectorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A17SectorId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSectorId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSectorId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Venta.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_17_Internalname, sImgUrl, imgprompt_17_Link, "", "", context.GetTheme( ), imgprompt_17_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSectorNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtSectorNombre_Internalname, "Sector Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtSectorNombre_Internalname, StringUtil.RTrim( A18SectorNombre), StringUtil.RTrim( context.localUtil.Format( A18SectorNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSectorNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSectorNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Venta.htm");
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Venta.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
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
               Z38VentaFecha = context.localUtil.CToD( cgiGet( "Z38VentaFecha"), 0);
               Z43VentaCantidadEntradas = (short)(context.localUtil.CToN( cgiGet( "Z43VentaCantidadEntradas"), ".", ","));
               Z34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "Z34EspectaculoId"), ".", ","));
               Z11LocalidadId = (short)(context.localUtil.CToN( cgiGet( "Z11LocalidadId"), ".", ","));
               Z17SectorId = (short)(context.localUtil.CToN( cgiGet( "Z17SectorId"), ".", ","));
               Z12LocalidadNombre = cgiGet( "Z12LocalidadNombre");
               Z13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( "Z13LocalidadCapacidad"), ".", ","));
               Z14LocalidadPrecio = context.localUtil.CToN( cgiGet( "Z14LocalidadPrecio"), ".", ",");
               A38VentaFecha = context.localUtil.CToD( cgiGet( "Z38VentaFecha"), 0);
               O15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( "O15LocalidadesVendidas"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "N34EspectaculoId"), ".", ","));
               N11LocalidadId = (short)(context.localUtil.CToN( cgiGet( "N11LocalidadId"), ".", ","));
               N17SectorId = (short)(context.localUtil.CToN( cgiGet( "N17SectorId"), ".", ","));
               A40VentaTotal = context.localUtil.CToN( cgiGet( "VENTATOTAL"), ".", ",");
               A16LocalidadesDisponibles = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADESDISPONIBLES"), ".", ","));
               AV20VentaId = (short)(context.localUtil.CToN( cgiGet( "vVENTAID"), ".", ","));
               AV11Insert_EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ESPECTACULOID"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV17Insert_LocalidadId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_LOCALIDADID"), ".", ","));
               AV19Insert_SectorId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_SECTORID"), ".", ","));
               A15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADESVENDIDAS"), ".", ","));
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0);
               A38VentaFecha = context.localUtil.CToD( cgiGet( "VENTAFECHA"), 0);
               AV23Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               A37VentaId = (short)(context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ","));
               AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
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
               AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
               if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LOCALIDADID");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11LocalidadId = 0;
                  AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               }
               else
               {
                  A11LocalidadId = (short)(context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ","));
                  AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               }
               A12LocalidadNombre = cgiGet( edtLocalidadNombre_Internalname);
               AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
               A14LocalidadPrecio = context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",");
               AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
               A13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ","));
               AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
               if ( ( ( context.localUtil.CToN( cgiGet( edtVentaCantidadEntradas_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVentaCantidadEntradas_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VENTACANTIDADENTRADAS");
                  AnyError = 1;
                  GX_FocusControl = edtVentaCantidadEntradas_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A43VentaCantidadEntradas = 0;
                  AssignAttri("", false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
               }
               else
               {
                  A43VentaCantidadEntradas = (short)(context.localUtil.CToN( cgiGet( edtVentaCantidadEntradas_Internalname), ".", ","));
                  AssignAttri("", false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SECTORID");
                  AnyError = 1;
                  GX_FocusControl = edtSectorId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A17SectorId = 0;
                  AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
               }
               else
               {
                  A17SectorId = (short)(context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ","));
                  AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
               }
               A18SectorNombre = cgiGet( edtSectorNombre_Internalname);
               AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Venta");
               A37VentaId = (short)(context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ","));
               AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               forbiddenHiddens.Add("VentaId", context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9"));
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               forbiddenHiddens.Add("VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
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
         if ( ! new isauthorized(context).executeUdp(  AV23Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV23Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "GXObligatorio1");
         AV11Insert_EspectaculoId = 0;
         AssignAttri("", false, "AV11Insert_EspectaculoId", StringUtil.LTrimStr( (decimal)(AV11Insert_EspectaculoId), 4, 0));
         AV17Insert_LocalidadId = 0;
         AssignAttri("", false, "AV17Insert_LocalidadId", StringUtil.LTrimStr( (decimal)(AV17Insert_LocalidadId), 4, 0));
         AV19Insert_SectorId = 0;
         AssignAttri("", false, "AV19Insert_SectorId", StringUtil.LTrimStr( (decimal)(AV19Insert_SectorId), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV23Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV24GXV1 = 1;
            AssignAttri("", false, "AV24GXV1", StringUtil.LTrimStr( (decimal)(AV24GXV1), 8, 0));
            while ( AV24GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV24GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "EspectaculoId") == 0 )
               {
                  AV11Insert_EspectaculoId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_EspectaculoId", StringUtil.LTrimStr( (decimal)(AV11Insert_EspectaculoId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "LocalidadId") == 0 )
               {
                  AV17Insert_LocalidadId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV17Insert_LocalidadId", StringUtil.LTrimStr( (decimal)(AV17Insert_LocalidadId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "SectorId") == 0 )
               {
                  AV19Insert_SectorId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV19Insert_SectorId", StringUtil.LTrimStr( (decimal)(AV19Insert_SectorId), 4, 0));
               }
               AV24GXV1 = (int)(AV24GXV1+1);
               AssignAttri("", false, "AV24GXV1", StringUtil.LTrimStr( (decimal)(AV24GXV1), 8, 0));
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
         if ( ( GX_JID == 21 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z38VentaFecha = T00063_A38VentaFecha[0];
               Z43VentaCantidadEntradas = T00063_A43VentaCantidadEntradas[0];
               Z34EspectaculoId = T00063_A34EspectaculoId[0];
               Z11LocalidadId = T00063_A11LocalidadId[0];
               Z17SectorId = T00063_A17SectorId[0];
            }
            else
            {
               Z38VentaFecha = A38VentaFecha;
               Z43VentaCantidadEntradas = A43VentaCantidadEntradas;
               Z34EspectaculoId = A34EspectaculoId;
               Z11LocalidadId = A11LocalidadId;
               Z17SectorId = A17SectorId;
            }
         }
         if ( ( GX_JID == 23 ) || ( GX_JID == 0 ) )
         {
            Z12LocalidadNombre = T00066_A12LocalidadNombre[0];
            Z13LocalidadCapacidad = T00066_A13LocalidadCapacidad[0];
            Z14LocalidadPrecio = T00066_A14LocalidadPrecio[0];
         }
         if ( GX_JID == -21 )
         {
            Z37VentaId = A37VentaId;
            Z38VentaFecha = A38VentaFecha;
            Z43VentaCantidadEntradas = A43VentaCantidadEntradas;
            Z34EspectaculoId = A34EspectaculoId;
            Z11LocalidadId = A11LocalidadId;
            Z17SectorId = A17SectorId;
            Z35EspectaculoNombre = A35EspectaculoNombre;
            Z36EspectaculoFecha = A36EspectaculoFecha;
            Z15LocalidadesVendidas = A15LocalidadesVendidas;
            Z12LocalidadNombre = A12LocalidadNombre;
            Z13LocalidadCapacidad = A13LocalidadCapacidad;
            Z14LocalidadPrecio = A14LocalidadPrecio;
            Z18SectorNombre = A18SectorNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         edtVentaId_Enabled = 0;
         AssignProp("", false, edtVentaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaId_Enabled), 5, 0), true);
         Gx_BScreen = 0;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( context);
         AssignAttri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         imgprompt_34_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0070.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESPECTACULOID"+"'), id:'"+"ESPECTACULOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00e1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESPECTACULOID"+"'), id:'"+"ESPECTACULOID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"LOCALIDADID"+"'), id:'"+"LOCALIDADID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESPECTACULOID"+"'), id:'"+"ESPECTACULOID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"LOCALIDADID"+"'), id:'"+"LOCALIDADID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"SECTORID"+"'), id:'"+"SECTORID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtVentaId_Enabled = 0;
         AssignProp("", false, edtVentaId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaId_Enabled), 5, 0), true);
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV20VentaId) )
         {
            A37VentaId = AV20VentaId;
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV17Insert_LocalidadId) )
         {
            edtLocalidadId_Enabled = 0;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         }
         else
         {
            edtLocalidadId_Enabled = 1;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV19Insert_SectorId) )
         {
            edtSectorId_Enabled = 0;
            AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), true);
         }
         else
         {
            edtSectorId_Enabled = 1;
            AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( IsUpd( )  )
         {
            edtLocalidadId_Enabled = 0;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         }
         if ( IsUpd( )  )
         {
            edtEspectaculoId_Enabled = 0;
            AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV19Insert_SectorId) )
         {
            A17SectorId = AV19Insert_SectorId;
            AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV17Insert_LocalidadId) )
         {
            A11LocalidadId = AV17Insert_LocalidadId;
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_EspectaculoId) )
         {
            A34EspectaculoId = AV11Insert_EspectaculoId;
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         }
         else
         {
            if ( IsIns( )  && (0==A34EspectaculoId) && ( Gx_BScreen == 0 ) )
            {
               A34EspectaculoId = 1;
               AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            }
         }
         if ( IsIns( )  && (DateTime.MinValue==A38VentaFecha) && ( Gx_BScreen == 0 ) )
         {
            A38VentaFecha = Gx_date;
            AssignAttri("", false, "A38VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV23Pgmname = "Venta";
            AssignAttri("", false, "AV23Pgmname", AV23Pgmname);
            /* Using cursor T00064 */
            pr_default.execute(2, new Object[] {A34EspectaculoId});
            A35EspectaculoNombre = T00064_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T00064_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
            pr_default.close(2);
            /* Using cursor T00066 */
            pr_default.execute(4, new Object[] {A34EspectaculoId, A11LocalidadId});
            ZM068( 23) ;
            A15LocalidadesVendidas = T00066_A15LocalidadesVendidas[0];
            A12LocalidadNombre = T00066_A12LocalidadNombre[0];
            AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
            A13LocalidadCapacidad = T00066_A13LocalidadCapacidad[0];
            AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
            A14LocalidadPrecio = T00066_A14LocalidadPrecio[0];
            AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
            O15LocalidadesVendidas = A15LocalidadesVendidas;
            AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
            pr_default.close(4);
            A16LocalidadesDisponibles = A13LocalidadCapacidad;
            AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
            /* Using cursor T00067 */
            pr_default.execute(5, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
            A18SectorNombre = T00067_A18SectorNombre[0];
            AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
            pr_default.close(5);
         }
      }

      protected void Load068( )
      {
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound8 = 1;
            A15LocalidadesVendidas = T00068_A15LocalidadesVendidas[0];
            A38VentaFecha = T00068_A38VentaFecha[0];
            A35EspectaculoNombre = T00068_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T00068_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
            A43VentaCantidadEntradas = T00068_A43VentaCantidadEntradas[0];
            AssignAttri("", false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
            A12LocalidadNombre = T00068_A12LocalidadNombre[0];
            AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
            A13LocalidadCapacidad = T00068_A13LocalidadCapacidad[0];
            AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
            A14LocalidadPrecio = T00068_A14LocalidadPrecio[0];
            AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
            A18SectorNombre = T00068_A18SectorNombre[0];
            AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
            A34EspectaculoId = T00068_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A11LocalidadId = T00068_A11LocalidadId[0];
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            A17SectorId = T00068_A17SectorId[0];
            AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
            ZM068( -21) ;
         }
         pr_default.close(6);
         OnLoadActions068( ) ;
      }

      protected void OnLoadActions068( )
      {
         O15LocalidadesVendidas = A15LocalidadesVendidas;
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         AV23Pgmname = "Venta";
         AssignAttri("", false, "AV23Pgmname", AV23Pgmname);
         A15LocalidadesVendidas = (int)(O15LocalidadesVendidas+A43VentaCantidadEntradas);
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         A16LocalidadesDisponibles = A13LocalidadCapacidad;
         AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
         A40VentaTotal = (decimal)(A14LocalidadPrecio*A43VentaCantidadEntradas);
         AssignAttri("", false, "A40VentaTotal", StringUtil.LTrimStr( A40VentaTotal, 9, 2));
      }

      protected void CheckExtendedTable068( )
      {
         nIsDirty_8 = 0;
         Gx_BScreen = 1;
         AssignAttri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV23Pgmname = "Venta";
         AssignAttri("", false, "AV23Pgmname", AV23Pgmname);
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
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
         pr_default.close(2);
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A34EspectaculoId, A11LocalidadId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A15LocalidadesVendidas = T00066_A15LocalidadesVendidas[0];
         A12LocalidadNombre = T00066_A12LocalidadNombre[0];
         AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
         A13LocalidadCapacidad = T00066_A13LocalidadCapacidad[0];
         AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
         A14LocalidadPrecio = T00066_A14LocalidadPrecio[0];
         AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
         nIsDirty_8 = 1;
         O15LocalidadesVendidas = A15LocalidadesVendidas;
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         pr_default.close(4);
         nIsDirty_8 = 1;
         A15LocalidadesVendidas = (int)(O15LocalidadesVendidas+A43VentaCantidadEntradas);
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         nIsDirty_8 = 1;
         A16LocalidadesDisponibles = A13LocalidadCapacidad;
         AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
         nIsDirty_8 = 1;
         A40VentaTotal = (decimal)(A14LocalidadPrecio*A43VentaCantidadEntradas);
         AssignAttri("", false, "A40VentaTotal", StringUtil.LTrimStr( A40VentaTotal, 9, 2));
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Sector'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18SectorNombre = T00067_A18SectorNombre[0];
         AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors068( )
      {
         pr_default.close(2);
         pr_default.close(4);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_22( short A34EspectaculoId )
      {
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A35EspectaculoNombre = T00069_A35EspectaculoNombre[0];
         AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
         A36EspectaculoFecha = T00069_A36EspectaculoFecha[0];
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A35EspectaculoNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(7) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(7);
      }

      protected void gxLoad_23( short A34EspectaculoId ,
                                short A11LocalidadId )
      {
         /* Using cursor T000610 */
         pr_default.execute(8, new Object[] {A34EspectaculoId, A11LocalidadId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A15LocalidadesVendidas = T000610_A15LocalidadesVendidas[0];
         A12LocalidadNombre = T000610_A12LocalidadNombre[0];
         AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
         A13LocalidadCapacidad = T000610_A13LocalidadCapacidad[0];
         AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
         A14LocalidadPrecio = T000610_A14LocalidadPrecio[0];
         AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
         O15LocalidadesVendidas = A15LocalidadesVendidas;
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A12LocalidadNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(8) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(8);
      }

      protected void gxLoad_24( short A34EspectaculoId ,
                                short A11LocalidadId ,
                                short A17SectorId )
      {
         /* Using cursor T000611 */
         pr_default.execute(9, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Sector'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18SectorNombre = T000611_A18SectorNombre[0];
         AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A18SectorNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(9) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(9);
      }

      protected void GetKey068( )
      {
         /* Using cursor T000612 */
         pr_default.execute(10, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM068( 21) ;
            RcdFound8 = 1;
            A37VentaId = T00063_A37VentaId[0];
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
            A38VentaFecha = T00063_A38VentaFecha[0];
            A43VentaCantidadEntradas = T00063_A43VentaCantidadEntradas[0];
            AssignAttri("", false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
            A34EspectaculoId = T00063_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A11LocalidadId = T00063_A11LocalidadId[0];
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            A17SectorId = T00063_A17SectorId[0];
            AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
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
         /* Using cursor T000613 */
         pr_default.execute(11, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000613_A37VentaId[0] < A37VentaId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000613_A37VentaId[0] > A37VentaId ) ) )
            {
               A37VentaId = T000613_A37VentaId[0];
               AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               RcdFound8 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0;
         /* Using cursor T000614 */
         pr_default.execute(12, new Object[] {A37VentaId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000614_A37VentaId[0] > A37VentaId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000614_A37VentaId[0] < A37VentaId ) ) )
            {
               A37VentaId = T000614_A37VentaId[0];
               AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               RcdFound8 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey068( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtEspectaculoId_Internalname;
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
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update068( ) ;
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A37VentaId != Z37VentaId )
               {
                  /* Insert record */
                  GX_FocusControl = edtEspectaculoId_Internalname;
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
                     GX_FocusControl = edtEspectaculoId_Internalname;
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
            GX_FocusControl = edtEspectaculoId_Internalname;
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
            if ( (pr_default.getStatus(0) == 101) || ( Z38VentaFecha != T00062_A38VentaFecha[0] ) || ( Z43VentaCantidadEntradas != T00062_A43VentaCantidadEntradas[0] ) || ( Z34EspectaculoId != T00062_A34EspectaculoId[0] ) || ( Z11LocalidadId != T00062_A11LocalidadId[0] ) || ( Z17SectorId != T00062_A17SectorId[0] ) )
            {
               if ( Z38VentaFecha != T00062_A38VentaFecha[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"VentaFecha");
                  GXUtil.WriteLogRaw("Old: ",Z38VentaFecha);
                  GXUtil.WriteLogRaw("Current: ",T00062_A38VentaFecha[0]);
               }
               if ( Z43VentaCantidadEntradas != T00062_A43VentaCantidadEntradas[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"VentaCantidadEntradas");
                  GXUtil.WriteLogRaw("Old: ",Z43VentaCantidadEntradas);
                  GXUtil.WriteLogRaw("Current: ",T00062_A43VentaCantidadEntradas[0]);
               }
               if ( Z34EspectaculoId != T00062_A34EspectaculoId[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"EspectaculoId");
                  GXUtil.WriteLogRaw("Old: ",Z34EspectaculoId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A34EspectaculoId[0]);
               }
               if ( Z11LocalidadId != T00062_A11LocalidadId[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"LocalidadId");
                  GXUtil.WriteLogRaw("Old: ",Z11LocalidadId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A11LocalidadId[0]);
               }
               if ( Z17SectorId != T00062_A17SectorId[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"SectorId");
                  GXUtil.WriteLogRaw("Old: ",Z17SectorId);
                  GXUtil.WriteLogRaw("Current: ",T00062_A17SectorId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Venta"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A34EspectaculoId, A11LocalidadId});
         if ( (pr_default.getStatus(3) == 103) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EspectaculoLocalidad"}), "RecordIsLocked", 1, "");
            AnyError = 1;
            return  ;
         }
         if ( ! IsIns( ) )
         {
            if ( false || ( StringUtil.StrCmp(Z12LocalidadNombre, T00065_A12LocalidadNombre[0]) != 0 ) || ( Z13LocalidadCapacidad != T00065_A13LocalidadCapacidad[0] ) || ( Z14LocalidadPrecio != T00065_A14LocalidadPrecio[0] ) )
            {
               if ( StringUtil.StrCmp(Z12LocalidadNombre, T00065_A12LocalidadNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"LocalidadNombre");
                  GXUtil.WriteLogRaw("Old: ",Z12LocalidadNombre);
                  GXUtil.WriteLogRaw("Current: ",T00065_A12LocalidadNombre[0]);
               }
               if ( Z13LocalidadCapacidad != T00065_A13LocalidadCapacidad[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"LocalidadCapacidad");
                  GXUtil.WriteLogRaw("Old: ",Z13LocalidadCapacidad);
                  GXUtil.WriteLogRaw("Current: ",T00065_A13LocalidadCapacidad[0]);
               }
               if ( Z14LocalidadPrecio != T00065_A14LocalidadPrecio[0] )
               {
                  GXUtil.WriteLog("venta:[seudo value changed for attri]"+"LocalidadPrecio");
                  GXUtil.WriteLogRaw("Old: ",Z14LocalidadPrecio);
                  GXUtil.WriteLogRaw("Current: ",T00065_A14LocalidadPrecio[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EspectaculoLocalidad"}), "RecordWasChanged", 1, "");
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
                     /* Using cursor T000615 */
                     pr_default.execute(13, new Object[] {A38VentaFecha, A43VentaCantidadEntradas, A34EspectaculoId, A11LocalidadId, A17SectorId});
                     A37VentaId = T000615_A37VentaId[0];
                     AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( AnyError == 0 )
                     {
                        UpdateTablesN1068( ) ;
                        /* Start of After( Insert) rules */
                        CallWebObject(formatLink("imprimirentradas.aspx") + "?" + UrlEncode("" +A37VentaId));
                        context.wjLocDisableFrm = 0;
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
                     /* Using cursor T000616 */
                     pr_default.execute(14, new Object[] {A38VentaFecha, A43VentaCantidadEntradas, A34EspectaculoId, A11LocalidadId, A17SectorId, A37VentaId});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Venta"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate068( ) ;
                     if ( AnyError == 0 )
                     {
                        UpdateTablesN1068( ) ;
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
                  /* Using cursor T000617 */
                  pr_default.execute(15, new Object[] {A37VentaId});
                  pr_default.close(15);
                  dsDefault.SmartCacheProvider.SetUpdated("Venta") ;
                  if ( AnyError == 0 )
                  {
                     UpdateTablesN1068( ) ;
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
            AV23Pgmname = "Venta";
            AssignAttri("", false, "AV23Pgmname", AV23Pgmname);
            /* Using cursor T000618 */
            pr_default.execute(16, new Object[] {A34EspectaculoId});
            A35EspectaculoNombre = T000618_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T000618_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
            pr_default.close(16);
            /* Using cursor T000619 */
            pr_default.execute(17, new Object[] {A34EspectaculoId, A11LocalidadId});
            Z12LocalidadNombre = T000619_A12LocalidadNombre[0];
            Z13LocalidadCapacidad = T000619_A13LocalidadCapacidad[0];
            Z14LocalidadPrecio = T000619_A14LocalidadPrecio[0];
            A15LocalidadesVendidas = T000619_A15LocalidadesVendidas[0];
            A12LocalidadNombre = T000619_A12LocalidadNombre[0];
            AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
            A13LocalidadCapacidad = T000619_A13LocalidadCapacidad[0];
            AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
            A14LocalidadPrecio = T000619_A14LocalidadPrecio[0];
            AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
            O15LocalidadesVendidas = A15LocalidadesVendidas;
            AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
            pr_default.close(17);
            A15LocalidadesVendidas = (int)(O15LocalidadesVendidas+A43VentaCantidadEntradas);
            AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
            A16LocalidadesDisponibles = A13LocalidadCapacidad;
            AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
            A40VentaTotal = (decimal)(A14LocalidadPrecio*A43VentaCantidadEntradas);
            AssignAttri("", false, "A40VentaTotal", StringUtil.LTrimStr( A40VentaTotal, 9, 2));
            /* Using cursor T000620 */
            pr_default.execute(18, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
            A18SectorNombre = T000620_A18SectorNombre[0];
            AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
            pr_default.close(18);
         }
      }

      protected void UpdateTablesN1068( )
      {
         /* Using cursor T000621 */
         pr_default.execute(19, new Object[] {A15LocalidadesVendidas, A34EspectaculoId, A11LocalidadId});
         pr_default.close(19);
         dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidad") ;
      }

      protected void EndLevel068( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         pr_default.close(3);
         if ( AnyError == 0 )
         {
            BeforeComplete068( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(18);
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
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(18);
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
         /* Using cursor T000622 */
         pr_default.execute(20);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound8 = 1;
            A37VentaId = T000622_A37VentaId[0];
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext068( )
      {
         /* Scan next routine */
         pr_default.readNext(20);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound8 = 1;
            A37VentaId = T000622_A37VentaId[0];
            AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
      }

      protected void ScanEnd068( )
      {
         pr_default.close(20);
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
         edtEspectaculoId_Enabled = 0;
         AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         edtEspectaculoNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoNombre_Enabled), 5, 0), true);
         edtEspectaculoFecha_Enabled = 0;
         AssignProp("", false, edtEspectaculoFecha_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoFecha_Enabled), 5, 0), true);
         edtLocalidadId_Enabled = 0;
         AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         edtLocalidadNombre_Enabled = 0;
         AssignProp("", false, edtLocalidadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadNombre_Enabled), 5, 0), true);
         edtLocalidadPrecio_Enabled = 0;
         AssignProp("", false, edtLocalidadPrecio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadPrecio_Enabled), 5, 0), true);
         edtLocalidadCapacidad_Enabled = 0;
         AssignProp("", false, edtLocalidadCapacidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0), true);
         edtVentaCantidadEntradas_Enabled = 0;
         AssignProp("", false, edtVentaCantidadEntradas_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtVentaCantidadEntradas_Enabled), 5, 0), true);
         edtSectorId_Enabled = 0;
         AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), true);
         edtSectorNombre_Enabled = 0;
         AssignProp("", false, edtSectorNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorNombre_Enabled), 5, 0), true);
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
         context.AddJavascriptSource("gxcfg.js", "?202022521452665", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("venta.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV20VentaId)+"\">") ;
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
         forbiddenHiddens.Add("VentaId", context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9"));
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         forbiddenHiddens.Add("VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("venta:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z37VentaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37VentaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z38VentaFecha", context.localUtil.DToC( Z38VentaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z43VentaCantidadEntradas", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z43VentaCantidadEntradas), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z34EspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z11LocalidadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11LocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z17SectorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z12LocalidadNombre", StringUtil.RTrim( Z12LocalidadNombre));
         GxWebStd.gx_hidden_field( context, "Z13LocalidadCapacidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13LocalidadCapacidad), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z14LocalidadPrecio", StringUtil.LTrim( StringUtil.NToC( Z14LocalidadPrecio, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "O15LocalidadesVendidas", StringUtil.LTrim( StringUtil.NToC( (decimal)(O15LocalidadesVendidas), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N34EspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N11LocalidadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N17SectorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "VENTATOTAL", StringUtil.LTrim( StringUtil.NToC( A40VentaTotal, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADESDISPONIBLES", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vVENTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20VentaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vVENTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20VentaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_ESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_LOCALIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Insert_LocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_SECTORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19Insert_SectorId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADESVENDIDAS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "VENTAFECHA", context.localUtil.DToC( A38VentaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV23Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         return formatLink("venta.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV20VentaId) ;
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
         A11LocalidadId = 0;
         AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
         A17SectorId = 0;
         AssignAttri("", false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
         A15LocalidadesVendidas = 0;
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         A16LocalidadesDisponibles = 0;
         AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
         A40VentaTotal = 0;
         AssignAttri("", false, "A40VentaTotal", StringUtil.LTrimStr( A40VentaTotal, 9, 2));
         A35EspectaculoNombre = "";
         AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
         A36EspectaculoFecha = DateTime.MinValue;
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
         A43VentaCantidadEntradas = 0;
         AssignAttri("", false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
         A12LocalidadNombre = "";
         AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
         A13LocalidadCapacidad = 0;
         AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
         A14LocalidadPrecio = 0;
         AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
         A18SectorNombre = "";
         AssignAttri("", false, "A18SectorNombre", A18SectorNombre);
         A34EspectaculoId = 1;
         AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         A38VentaFecha = Gx_date;
         AssignAttri("", false, "A38VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
         O15LocalidadesVendidas = A15LocalidadesVendidas;
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         Z38VentaFecha = DateTime.MinValue;
         Z43VentaCantidadEntradas = 0;
         Z34EspectaculoId = 0;
         Z11LocalidadId = 0;
         Z17SectorId = 0;
         Z12LocalidadNombre = "";
         Z13LocalidadCapacidad = 0;
         Z14LocalidadPrecio = 0;
      }

      protected void InitAll068( )
      {
         A37VentaId = 0;
         AssignAttri("", false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         InitializeNonKey068( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A34EspectaculoId = i34EspectaculoId;
         AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         A38VentaFecha = i38VentaFecha;
         AssignAttri("", false, "A38VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022521452682", true, true);
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
         context.AddJavascriptSource("venta.js", "?202022521452682", false, true);
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
         edtEspectaculoId_Internalname = "ESPECTACULOID";
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = "ESPECTACULOFECHA";
         edtLocalidadId_Internalname = "LOCALIDADID";
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE";
         edtLocalidadPrecio_Internalname = "LOCALIDADPRECIO";
         edtLocalidadCapacidad_Internalname = "LOCALIDADCAPACIDAD";
         edtVentaCantidadEntradas_Internalname = "VENTACANTIDADENTRADAS";
         edtSectorId_Internalname = "SECTORID";
         edtSectorNombre_Internalname = "SECTORNOMBRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_34_Internalname = "PROMPT_34";
         imgprompt_11_Internalname = "PROMPT_11";
         imgprompt_17_Internalname = "PROMPT_17";
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
         edtSectorNombre_Jsonclick = "";
         edtSectorNombre_Enabled = 0;
         imgprompt_17_Visible = 1;
         imgprompt_17_Link = "";
         edtSectorId_Jsonclick = "";
         edtSectorId_Enabled = 1;
         edtVentaCantidadEntradas_Jsonclick = "";
         edtVentaCantidadEntradas_Enabled = 1;
         edtLocalidadCapacidad_Jsonclick = "";
         edtLocalidadCapacidad_Enabled = 0;
         edtLocalidadPrecio_Jsonclick = "";
         edtLocalidadPrecio_Enabled = 0;
         edtLocalidadNombre_Jsonclick = "";
         edtLocalidadNombre_Enabled = 0;
         imgprompt_11_Visible = 1;
         imgprompt_11_Link = "";
         edtLocalidadId_Jsonclick = "";
         edtLocalidadId_Enabled = 1;
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoFecha_Enabled = 0;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Enabled = 0;
         imgprompt_34_Visible = 1;
         imgprompt_34_Link = "";
         edtEspectaculoId_Jsonclick = "";
         edtEspectaculoId_Enabled = 1;
         edtVentaId_Jsonclick = "";
         edtVentaId_Enabled = 0;
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

      protected void XC_20_068( short A37VentaId )
      {
         CallWebObject(formatLink("imprimirentradas.aspx") + "?" + UrlEncode("" +A37VentaId));
         context.wjLocDisableFrm = 0;
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "]") ;
         if ( true )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
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
         /* Using cursor T000618 */
         pr_default.execute(16, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
         }
         A35EspectaculoNombre = T000618_A35EspectaculoNombre[0];
         A36EspectaculoFecha = T000618_A36EspectaculoFecha[0];
         pr_default.close(16);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A35EspectaculoNombre", StringUtil.RTrim( A35EspectaculoNombre));
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
      }

      public void Valid_Localidadid( )
      {
         /* Using cursor T000619 */
         pr_default.execute(17, new Object[] {A34EspectaculoId, A11LocalidadId});
         Z12LocalidadNombre = T000619_A12LocalidadNombre[0];
         Z13LocalidadCapacidad = T000619_A13LocalidadCapacidad[0];
         Z14LocalidadPrecio = T000619_A14LocalidadPrecio[0];
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Localidad'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
         }
         A15LocalidadesVendidas = T000619_A15LocalidadesVendidas[0];
         A12LocalidadNombre = T000619_A12LocalidadNombre[0];
         A13LocalidadCapacidad = T000619_A13LocalidadCapacidad[0];
         A14LocalidadPrecio = T000619_A14LocalidadPrecio[0];
         O15LocalidadesVendidas = A15LocalidadesVendidas;
         pr_default.close(17);
         A16LocalidadesDisponibles = A13LocalidadCapacidad;
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "O15LocalidadesVendidas", StringUtil.LTrim( StringUtil.NToC( (decimal)(O15LocalidadesVendidas), 5, 0, ".", "")));
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")));
         AssignAttri("", false, "A12LocalidadNombre", StringUtil.RTrim( A12LocalidadNombre));
         AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")));
         AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")));
         AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", "")));
      }

      public void Valid_Sectorid( )
      {
         /* Using cursor T000620 */
         pr_default.execute(18, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No matching 'Sector'.", "ForeignKeyNotFound", 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
         }
         A18SectorNombre = T000620_A18SectorNombre[0];
         pr_default.close(18);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A18SectorNombre", StringUtil.RTrim( A18SectorNombre));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV20VentaId',fld:'vVENTAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV20VentaId',fld:'vVENTAID',pic:'ZZZ9',hsh:true},{av:'A37VentaId',fld:'VENTAID',pic:'ZZZ9'},{av:'A38VentaFecha',fld:'VENTAFECHA',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12062',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_VENTAID","{handler:'Valid_Ventaid',iparms:[]");
         setEventMetadata("VALID_VENTAID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOID","{handler:'Valid_Espectaculoid',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'},{av:'A35EspectaculoNombre',fld:'ESPECTACULONOMBRE',pic:''},{av:'A36EspectaculoFecha',fld:'ESPECTACULOFECHA',pic:''}]");
         setEventMetadata("VALID_ESPECTACULOID",",oparms:[{av:'A35EspectaculoNombre',fld:'ESPECTACULONOMBRE',pic:''},{av:'A36EspectaculoFecha',fld:'ESPECTACULOFECHA',pic:''}]}");
         setEventMetadata("VALID_LOCALIDADID","{handler:'Valid_Localidadid',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'},{av:'A11LocalidadId',fld:'LOCALIDADID',pic:'ZZZ9'},{av:'A13LocalidadCapacidad',fld:'LOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'A15LocalidadesVendidas',fld:'LOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'A12LocalidadNombre',fld:'LOCALIDADNOMBRE',pic:''},{av:'A14LocalidadPrecio',fld:'LOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'A16LocalidadesDisponibles',fld:'LOCALIDADESDISPONIBLES',pic:'ZZZZ9'}]");
         setEventMetadata("VALID_LOCALIDADID",",oparms:[{av:'O15LocalidadesVendidas'},{av:'A15LocalidadesVendidas',fld:'LOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'A12LocalidadNombre',fld:'LOCALIDADNOMBRE',pic:''},{av:'A13LocalidadCapacidad',fld:'LOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'A14LocalidadPrecio',fld:'LOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'A16LocalidadesDisponibles',fld:'LOCALIDADESDISPONIBLES',pic:'ZZZZ9'}]}");
         setEventMetadata("VALID_LOCALIDADPRECIO","{handler:'Valid_Localidadprecio',iparms:[]");
         setEventMetadata("VALID_LOCALIDADPRECIO",",oparms:[]}");
         setEventMetadata("VALID_LOCALIDADCAPACIDAD","{handler:'Valid_Localidadcapacidad',iparms:[]");
         setEventMetadata("VALID_LOCALIDADCAPACIDAD",",oparms:[]}");
         setEventMetadata("VALID_VENTACANTIDADENTRADAS","{handler:'Valid_Ventacantidadentradas',iparms:[]");
         setEventMetadata("VALID_VENTACANTIDADENTRADAS",",oparms:[]}");
         setEventMetadata("VALID_SECTORID","{handler:'Valid_Sectorid',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'},{av:'A11LocalidadId',fld:'LOCALIDADID',pic:'ZZZ9'},{av:'A17SectorId',fld:'SECTORID',pic:'ZZZ9'},{av:'A18SectorNombre',fld:'SECTORNOMBRE',pic:''}]");
         setEventMetadata("VALID_SECTORID",",oparms:[{av:'A18SectorNombre',fld:'SECTORNOMBRE',pic:''}]}");
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
         pr_default.close(16);
         pr_default.close(17);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z38VentaFecha = DateTime.MinValue;
         Z12LocalidadNombre = "";
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
         sImgUrl = "";
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A12LocalidadNombre = "";
         A18SectorNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         A38VentaFecha = DateTime.MinValue;
         AV11Insert_EspectaculoId = 1;
         Gx_date = DateTime.MinValue;
         AV23Pgmname = "";
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
         Z35EspectaculoNombre = "";
         Z36EspectaculoFecha = DateTime.MinValue;
         Z18SectorNombre = "";
         T00064_A35EspectaculoNombre = new String[] {""} ;
         T00064_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T00066_A15LocalidadesVendidas = new int[1] ;
         T00066_A12LocalidadNombre = new String[] {""} ;
         T00066_A13LocalidadCapacidad = new int[1] ;
         T00066_A14LocalidadPrecio = new decimal[1] ;
         T00067_A18SectorNombre = new String[] {""} ;
         T00068_A37VentaId = new short[1] ;
         T00068_A15LocalidadesVendidas = new int[1] ;
         T00068_A38VentaFecha = new DateTime[] {DateTime.MinValue} ;
         T00068_A35EspectaculoNombre = new String[] {""} ;
         T00068_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T00068_A43VentaCantidadEntradas = new short[1] ;
         T00068_A12LocalidadNombre = new String[] {""} ;
         T00068_A13LocalidadCapacidad = new int[1] ;
         T00068_A14LocalidadPrecio = new decimal[1] ;
         T00068_A18SectorNombre = new String[] {""} ;
         T00068_A34EspectaculoId = new short[1] ;
         T00068_A11LocalidadId = new short[1] ;
         T00068_A17SectorId = new short[1] ;
         T00069_A35EspectaculoNombre = new String[] {""} ;
         T00069_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T000610_A15LocalidadesVendidas = new int[1] ;
         T000610_A12LocalidadNombre = new String[] {""} ;
         T000610_A13LocalidadCapacidad = new int[1] ;
         T000610_A14LocalidadPrecio = new decimal[1] ;
         T000611_A18SectorNombre = new String[] {""} ;
         T000612_A37VentaId = new short[1] ;
         T00063_A37VentaId = new short[1] ;
         T00063_A38VentaFecha = new DateTime[] {DateTime.MinValue} ;
         T00063_A43VentaCantidadEntradas = new short[1] ;
         T00063_A34EspectaculoId = new short[1] ;
         T00063_A11LocalidadId = new short[1] ;
         T00063_A17SectorId = new short[1] ;
         T000613_A37VentaId = new short[1] ;
         T000614_A37VentaId = new short[1] ;
         T00062_A37VentaId = new short[1] ;
         T00062_A38VentaFecha = new DateTime[] {DateTime.MinValue} ;
         T00062_A43VentaCantidadEntradas = new short[1] ;
         T00062_A34EspectaculoId = new short[1] ;
         T00062_A11LocalidadId = new short[1] ;
         T00062_A17SectorId = new short[1] ;
         T00065_A15LocalidadesVendidas = new int[1] ;
         T00065_A12LocalidadNombre = new String[] {""} ;
         T00065_A13LocalidadCapacidad = new int[1] ;
         T00065_A14LocalidadPrecio = new decimal[1] ;
         T000615_A37VentaId = new short[1] ;
         T000618_A35EspectaculoNombre = new String[] {""} ;
         T000618_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T000619_A15LocalidadesVendidas = new int[1] ;
         T000619_A12LocalidadNombre = new String[] {""} ;
         T000619_A13LocalidadCapacidad = new int[1] ;
         T000619_A14LocalidadPrecio = new decimal[1] ;
         T000620_A18SectorNombre = new String[] {""} ;
         T000622_A37VentaId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i38VentaFecha = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.venta__default(),
            new Object[][] {
                new Object[] {
               T00062_A37VentaId, T00062_A38VentaFecha, T00062_A43VentaCantidadEntradas, T00062_A34EspectaculoId, T00062_A11LocalidadId, T00062_A17SectorId
               }
               , new Object[] {
               T00063_A37VentaId, T00063_A38VentaFecha, T00063_A43VentaCantidadEntradas, T00063_A34EspectaculoId, T00063_A11LocalidadId, T00063_A17SectorId
               }
               , new Object[] {
               T00064_A35EspectaculoNombre, T00064_A36EspectaculoFecha
               }
               , new Object[] {
               T00065_A15LocalidadesVendidas, T00065_A12LocalidadNombre, T00065_A13LocalidadCapacidad, T00065_A14LocalidadPrecio
               }
               , new Object[] {
               T00066_A15LocalidadesVendidas, T00066_A12LocalidadNombre, T00066_A13LocalidadCapacidad, T00066_A14LocalidadPrecio
               }
               , new Object[] {
               T00067_A18SectorNombre
               }
               , new Object[] {
               T00068_A37VentaId, T00068_A15LocalidadesVendidas, T00068_A38VentaFecha, T00068_A35EspectaculoNombre, T00068_A36EspectaculoFecha, T00068_A43VentaCantidadEntradas, T00068_A12LocalidadNombre, T00068_A13LocalidadCapacidad, T00068_A14LocalidadPrecio, T00068_A18SectorNombre,
               T00068_A34EspectaculoId, T00068_A11LocalidadId, T00068_A17SectorId
               }
               , new Object[] {
               T00069_A35EspectaculoNombre, T00069_A36EspectaculoFecha
               }
               , new Object[] {
               T000610_A15LocalidadesVendidas, T000610_A12LocalidadNombre, T000610_A13LocalidadCapacidad, T000610_A14LocalidadPrecio
               }
               , new Object[] {
               T000611_A18SectorNombre
               }
               , new Object[] {
               T000612_A37VentaId
               }
               , new Object[] {
               T000613_A37VentaId
               }
               , new Object[] {
               T000614_A37VentaId
               }
               , new Object[] {
               T000615_A37VentaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000618_A35EspectaculoNombre, T000618_A36EspectaculoFecha
               }
               , new Object[] {
               T000619_A15LocalidadesVendidas, T000619_A12LocalidadNombre, T000619_A13LocalidadCapacidad, T000619_A14LocalidadPrecio
               }
               , new Object[] {
               T000620_A18SectorNombre
               }
               , new Object[] {
               }
               , new Object[] {
               T000622_A37VentaId
               }
            }
         );
         Z34EspectaculoId = 1;
         N34EspectaculoId = 1;
         i34EspectaculoId = 1;
         A34EspectaculoId = 1;
         AV23Pgmname = "Venta";
         Z38VentaFecha = DateTime.MinValue;
         A38VentaFecha = DateTime.MinValue;
         i38VentaFecha = DateTime.MinValue;
         Gx_date = DateTimeUtil.Today( context);
      }

      private short wcpOAV20VentaId ;
      private short Z37VentaId ;
      private short Z43VentaCantidadEntradas ;
      private short Z34EspectaculoId ;
      private short Z11LocalidadId ;
      private short Z17SectorId ;
      private short N34EspectaculoId ;
      private short N11LocalidadId ;
      private short N17SectorId ;
      private short GxWebError ;
      private short A37VentaId ;
      private short A34EspectaculoId ;
      private short A11LocalidadId ;
      private short A17SectorId ;
      private short AV20VentaId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A43VentaCantidadEntradas ;
      private short AV11Insert_EspectaculoId ;
      private short Gx_BScreen ;
      private short AV17Insert_LocalidadId ;
      private short AV19Insert_SectorId ;
      private short RcdFound8 ;
      private short GX_JID ;
      private short nIsDirty_8 ;
      private short gxajaxcallmode ;
      private short i34EspectaculoId ;
      private int Z13LocalidadCapacidad ;
      private int O15LocalidadesVendidas ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtVentaId_Enabled ;
      private int edtEspectaculoId_Enabled ;
      private int imgprompt_34_Visible ;
      private int edtEspectaculoNombre_Enabled ;
      private int edtEspectaculoFecha_Enabled ;
      private int edtLocalidadId_Enabled ;
      private int imgprompt_11_Visible ;
      private int edtLocalidadNombre_Enabled ;
      private int edtLocalidadPrecio_Enabled ;
      private int A13LocalidadCapacidad ;
      private int edtLocalidadCapacidad_Enabled ;
      private int edtVentaCantidadEntradas_Enabled ;
      private int edtSectorId_Enabled ;
      private int imgprompt_17_Visible ;
      private int edtSectorNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int A16LocalidadesDisponibles ;
      private int A15LocalidadesVendidas ;
      private int AV24GXV1 ;
      private int Z15LocalidadesVendidas ;
      private int idxLst ;
      private int ZO15LocalidadesVendidas ;
      private int Z16LocalidadesDisponibles ;
      private decimal Z14LocalidadPrecio ;
      private decimal A14LocalidadPrecio ;
      private decimal A40VentaTotal ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z12LocalidadNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEspectaculoId_Internalname ;
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
      private String edtVentaId_Internalname ;
      private String edtVentaId_Jsonclick ;
      private String edtEspectaculoId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_34_Internalname ;
      private String imgprompt_34_Link ;
      private String edtEspectaculoNombre_Internalname ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtLocalidadId_Internalname ;
      private String edtLocalidadId_Jsonclick ;
      private String imgprompt_11_Internalname ;
      private String imgprompt_11_Link ;
      private String edtLocalidadNombre_Internalname ;
      private String A12LocalidadNombre ;
      private String edtLocalidadNombre_Jsonclick ;
      private String edtLocalidadPrecio_Internalname ;
      private String edtLocalidadPrecio_Jsonclick ;
      private String edtLocalidadCapacidad_Internalname ;
      private String edtLocalidadCapacidad_Jsonclick ;
      private String edtVentaCantidadEntradas_Internalname ;
      private String edtVentaCantidadEntradas_Jsonclick ;
      private String edtSectorId_Internalname ;
      private String edtSectorId_Jsonclick ;
      private String imgprompt_17_Internalname ;
      private String imgprompt_17_Link ;
      private String edtSectorNombre_Internalname ;
      private String A18SectorNombre ;
      private String edtSectorNombre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV23Pgmname ;
      private String hsh ;
      private String sMode8 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z35EspectaculoNombre ;
      private String Z18SectorNombre ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z38VentaFecha ;
      private DateTime A36EspectaculoFecha ;
      private DateTime A38VentaFecha ;
      private DateTime Gx_date ;
      private DateTime Z36EspectaculoFecha ;
      private DateTime i38VentaFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00064_A35EspectaculoNombre ;
      private DateTime[] T00064_A36EspectaculoFecha ;
      private int[] T00066_A15LocalidadesVendidas ;
      private String[] T00066_A12LocalidadNombre ;
      private int[] T00066_A13LocalidadCapacidad ;
      private decimal[] T00066_A14LocalidadPrecio ;
      private String[] T00067_A18SectorNombre ;
      private short[] T00068_A37VentaId ;
      private int[] T00068_A15LocalidadesVendidas ;
      private DateTime[] T00068_A38VentaFecha ;
      private String[] T00068_A35EspectaculoNombre ;
      private DateTime[] T00068_A36EspectaculoFecha ;
      private short[] T00068_A43VentaCantidadEntradas ;
      private String[] T00068_A12LocalidadNombre ;
      private int[] T00068_A13LocalidadCapacidad ;
      private decimal[] T00068_A14LocalidadPrecio ;
      private String[] T00068_A18SectorNombre ;
      private short[] T00068_A34EspectaculoId ;
      private short[] T00068_A11LocalidadId ;
      private short[] T00068_A17SectorId ;
      private String[] T00069_A35EspectaculoNombre ;
      private DateTime[] T00069_A36EspectaculoFecha ;
      private int[] T000610_A15LocalidadesVendidas ;
      private String[] T000610_A12LocalidadNombre ;
      private int[] T000610_A13LocalidadCapacidad ;
      private decimal[] T000610_A14LocalidadPrecio ;
      private String[] T000611_A18SectorNombre ;
      private short[] T000612_A37VentaId ;
      private short[] T00063_A37VentaId ;
      private DateTime[] T00063_A38VentaFecha ;
      private short[] T00063_A43VentaCantidadEntradas ;
      private short[] T00063_A34EspectaculoId ;
      private short[] T00063_A11LocalidadId ;
      private short[] T00063_A17SectorId ;
      private short[] T000613_A37VentaId ;
      private short[] T000614_A37VentaId ;
      private short[] T00062_A37VentaId ;
      private DateTime[] T00062_A38VentaFecha ;
      private short[] T00062_A43VentaCantidadEntradas ;
      private short[] T00062_A34EspectaculoId ;
      private short[] T00062_A11LocalidadId ;
      private short[] T00062_A17SectorId ;
      private int[] T00065_A15LocalidadesVendidas ;
      private String[] T00065_A12LocalidadNombre ;
      private int[] T00065_A13LocalidadCapacidad ;
      private decimal[] T00065_A14LocalidadPrecio ;
      private short[] T000615_A37VentaId ;
      private String[] T000618_A35EspectaculoNombre ;
      private DateTime[] T000618_A36EspectaculoFecha ;
      private int[] T000619_A15LocalidadesVendidas ;
      private String[] T000619_A12LocalidadNombre ;
      private int[] T000619_A13LocalidadCapacidad ;
      private decimal[] T000619_A14LocalidadPrecio ;
      private String[] T000620_A18SectorNombre ;
      private short[] T000622_A37VentaId ;
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
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@VentaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@VentaCantidadEntradas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@VentaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@VentaCantidadEntradas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000617 ;
          prmT000617 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000621 ;
          prmT000621 = new Object[] {
          new Object[] {"@LocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000622 ;
          prmT000622 = new Object[] {
          } ;
          Object[] prmT000618 ;
          prmT000618 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000619 ;
          prmT000619 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000620 ;
          prmT000620 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [VentaId], [VentaFecha], [VentaCantidadEntradas], [EspectaculoId], [LocalidadId], [SectorId] FROM [Venta] WITH (UPDLOCK) WHERE [VentaId] = @VentaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00063", "SELECT [VentaId], [VentaFecha], [VentaCantidadEntradas], [EspectaculoId], [LocalidadId], [SectorId] FROM [Venta] WHERE [VentaId] = @VentaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00064", "SELECT [EspectaculoNombre], [EspectaculoFecha] FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00065", "SELECT [LocalidadesVendidas], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio] FROM [EspectaculoLocalidad] WITH (UPDLOCK) WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00066", "SELECT [LocalidadesVendidas], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00067", "SELECT [SectorNombre] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00068", "SELECT TM1.[VentaId], T3.[LocalidadesVendidas], TM1.[VentaFecha], T2.[EspectaculoNombre], T2.[EspectaculoFecha], TM1.[VentaCantidadEntradas], T3.[LocalidadNombre], T3.[LocalidadCapacidad], T3.[LocalidadPrecio], T4.[SectorNombre], TM1.[EspectaculoId], TM1.[LocalidadId], TM1.[SectorId] FROM ((([Venta] TM1 INNER JOIN [Espectaculo] T2 ON T2.[EspectaculoId] = TM1.[EspectaculoId]) INNER JOIN [EspectaculoLocalidad] T3 ON T3.[EspectaculoId] = TM1.[EspectaculoId] AND T3.[LocalidadId] = TM1.[LocalidadId]) INNER JOIN [EspectaculoLocalidadSector] T4 ON T4.[EspectaculoId] = TM1.[EspectaculoId] AND T4.[LocalidadId] = TM1.[LocalidadId] AND T4.[SectorId] = TM1.[SectorId]) WHERE TM1.[VentaId] = @VentaId ORDER BY TM1.[VentaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00069", "SELECT [EspectaculoNombre], [EspectaculoFecha] FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000610", "SELECT [LocalidadesVendidas], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000611", "SELECT [SectorNombre] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000612", "SELECT [VentaId] FROM [Venta] WHERE [VentaId] = @VentaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000612,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000613", "SELECT TOP 1 [VentaId] FROM [Venta] WHERE ( [VentaId] > @VentaId) ORDER BY [VentaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000614", "SELECT TOP 1 [VentaId] FROM [Venta] WHERE ( [VentaId] < @VentaId) ORDER BY [VentaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000615", "INSERT INTO [Venta]([VentaFecha], [VentaCantidadEntradas], [EspectaculoId], [LocalidadId], [SectorId]) VALUES(@VentaFecha, @VentaCantidadEntradas, @EspectaculoId, @LocalidadId, @SectorId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000615)
             ,new CursorDef("T000616", "UPDATE [Venta] SET [VentaFecha]=@VentaFecha, [VentaCantidadEntradas]=@VentaCantidadEntradas, [EspectaculoId]=@EspectaculoId, [LocalidadId]=@LocalidadId, [SectorId]=@SectorId  WHERE [VentaId] = @VentaId", GxErrorMask.GX_NOMASK,prmT000616)
             ,new CursorDef("T000617", "DELETE FROM [Venta]  WHERE [VentaId] = @VentaId", GxErrorMask.GX_NOMASK,prmT000617)
             ,new CursorDef("T000618", "SELECT [EspectaculoNombre], [EspectaculoFecha] FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000618,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000619", "SELECT [LocalidadesVendidas], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000619,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000620", "SELECT [SectorNombre] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000620,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000621", "UPDATE [EspectaculoLocalidad] SET [LocalidadesVendidas]=@LocalidadesVendidas  WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId", GxErrorMask.GX_NOMASK,prmT000621)
             ,new CursorDef("T000622", "SELECT [VentaId] FROM [Venta] ORDER BY [VentaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000622,100, GxCacheFrequency.OFF ,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 100) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 100) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 20 :
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 14 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 19 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
