/*
               File: VentaGeneral
        Description: Venta General
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:24.82
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class ventageneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public ventageneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public ventageneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_VentaId )
      {
         this.A37VentaId = aP0_VentaId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            if ( nGotPars == 0 )
            {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  A37VentaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri(sPrefix, false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A37VentaId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA2M2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "VentaGeneral";
               context.Gx_err = 0;
               WS2M2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Venta General") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202022521452487", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 138086), false, true);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("ventageneral.aspx") + "?" + UrlEncode("" +A37VentaId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            AssignProp(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", sPrefix+"hsh"+"VentaGeneral");
         forbiddenHiddens.Add("EspectaculoId", context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("ventageneral:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA37VentaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA37VentaId), 4, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm2M2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("ventageneral.js", "?202022521452490", false, true);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "VentaGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Venta General" ;
      }

      protected void WB2M0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "ventageneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Update", bttBtnupdate_Jsonclick, 7, "Update", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e112m1_client"+"'", TempTags, "", 2, "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Delete", bttBtndelete_Jsonclick, 7, "Delete", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e122m1_client"+"'", TempTags, "", 2, "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVentaId_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")), ((edtVentaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVentaFecha_Internalname, "Fecha", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtVentaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtVentaFecha_Internalname, context.localUtil.Format(A38VentaFecha, "99/99/9999"), context.localUtil.Format( A38VentaFecha, "99/99/9999"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaFecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaFecha_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_bitmap( context, edtVentaFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtVentaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_VentaGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEspectaculoId_Internalname, "Espectaculo Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")), ((edtEspectaculoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_VentaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoNombre_Internalname, "Espectaculo Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoNombre_Internalname, StringUtil.RTrim( A35EspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtEspectaculoNombre_Link, "", "", "", edtEspectaculoNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_VentaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoFecha_Internalname, "Espectaculo Fecha", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtEspectaculoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtEspectaculoFecha_Internalname, context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"), context.localUtil.Format( A36EspectaculoFecha, "99/99/9999"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoFecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoFecha_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_bitmap( context, edtEspectaculoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEspectaculoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_VentaGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaCantidadEntradas_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVentaCantidadEntradas_Internalname, "Cantidad Entradas", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaCantidadEntradas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A43VentaCantidadEntradas), 4, 0, ".", "")), ((edtVentaCantidadEntradas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A43VentaCantidadEntradas), "ZZZ9")) : context.localUtil.Format( (decimal)(A43VentaCantidadEntradas), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaCantidadEntradas_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaCantidadEntradas_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaTotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVentaTotal_Internalname, "Total", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A40VentaTotal, 9, 2, ".", "")), ((edtVentaTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A40VentaTotal, "ZZZZZ9.99")) : context.localUtil.Format( A40VentaTotal, "ZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaTotal_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaTotal_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLocalidadId_Internalname, "Localidad Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLocalidadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")), ((edtLocalidadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLocalidadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLocalidadNombre_Internalname, "Localidad Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLocalidadNombre_Internalname, StringUtil.RTrim( A12LocalidadNombre), StringUtil.RTrim( context.localUtil.Format( A12LocalidadNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLocalidadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadCapacidad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLocalidadCapacidad_Internalname, "Localidad Capacidad", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLocalidadCapacidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")), ((edtLocalidadCapacidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")) : context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadCapacidad_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLocalidadCapacidad_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadPrecio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLocalidadPrecio_Internalname, "Localidad Precio", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLocalidadPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")), ((edtLocalidadPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")) : context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadPrecio_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLocalidadPrecio_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadesVendidas_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLocalidadesVendidas_Internalname, "Localidades Vendidas", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLocalidadesVendidas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")), ((edtLocalidadesVendidas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A15LocalidadesVendidas), "ZZZZ9")) : context.localUtil.Format( (decimal)(A15LocalidadesVendidas), "ZZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadesVendidas_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLocalidadesVendidas_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadesDisponibles_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLocalidadesDisponibles_Internalname, "Localidades Disponibles", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLocalidadesDisponibles_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", "")), ((edtLocalidadesDisponibles_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")) : context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadesDisponibles_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLocalidadesDisponibles_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSectorId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSectorId_Internalname, "Sector Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSectorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")), ((edtSectorId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A17SectorId), "ZZZ9")) : context.localUtil.Format( (decimal)(A17SectorId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSectorId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSectorId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSectorNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSectorNombre_Internalname, "Sector Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSectorNombre_Internalname, StringUtil.RTrim( A18SectorNombre), StringUtil.RTrim( context.localUtil.Format( A18SectorNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSectorNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSectorNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_VentaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START2M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "Venta General", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP2M0( ) ;
            }
         }
      }

      protected void WS2M2( )
      {
         START2M2( ) ;
         EVT2M2( ) ;
      }

      protected void EVT2M2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E132M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E142M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                              dynload_actions( ) ;
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
      }

      protected void WE2M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2M2( ) ;
            }
         }
      }

      protected void PA2M2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "VentaGeneral";
         context.Gx_err = 0;
      }

      protected void RF2M2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H002M2 */
            pr_default.execute(0, new Object[] {A37VentaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A18SectorNombre = H002M2_A18SectorNombre[0];
               AssignAttri(sPrefix, false, "A18SectorNombre", A18SectorNombre);
               A17SectorId = H002M2_A17SectorId[0];
               AssignAttri(sPrefix, false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
               A15LocalidadesVendidas = H002M2_A15LocalidadesVendidas[0];
               AssignAttri(sPrefix, false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
               A12LocalidadNombre = H002M2_A12LocalidadNombre[0];
               AssignAttri(sPrefix, false, "A12LocalidadNombre", A12LocalidadNombre);
               A11LocalidadId = H002M2_A11LocalidadId[0];
               AssignAttri(sPrefix, false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               A36EspectaculoFecha = H002M2_A36EspectaculoFecha[0];
               AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
               A35EspectaculoNombre = H002M2_A35EspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
               A34EspectaculoId = H002M2_A34EspectaculoId[0];
               AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               A38VentaFecha = H002M2_A38VentaFecha[0];
               AssignAttri(sPrefix, false, "A38VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
               A14LocalidadPrecio = H002M2_A14LocalidadPrecio[0];
               AssignAttri(sPrefix, false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
               A43VentaCantidadEntradas = H002M2_A43VentaCantidadEntradas[0];
               AssignAttri(sPrefix, false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
               A13LocalidadCapacidad = H002M2_A13LocalidadCapacidad[0];
               AssignAttri(sPrefix, false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
               A36EspectaculoFecha = H002M2_A36EspectaculoFecha[0];
               AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
               A35EspectaculoNombre = H002M2_A35EspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
               A15LocalidadesVendidas = H002M2_A15LocalidadesVendidas[0];
               AssignAttri(sPrefix, false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
               A12LocalidadNombre = H002M2_A12LocalidadNombre[0];
               AssignAttri(sPrefix, false, "A12LocalidadNombre", A12LocalidadNombre);
               A14LocalidadPrecio = H002M2_A14LocalidadPrecio[0];
               AssignAttri(sPrefix, false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
               A13LocalidadCapacidad = H002M2_A13LocalidadCapacidad[0];
               AssignAttri(sPrefix, false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
               A18SectorNombre = H002M2_A18SectorNombre[0];
               AssignAttri(sPrefix, false, "A18SectorNombre", A18SectorNombre);
               A40VentaTotal = (decimal)(A14LocalidadPrecio*A43VentaCantidadEntradas);
               AssignAttri(sPrefix, false, "A40VentaTotal", StringUtil.LTrimStr( A40VentaTotal, 9, 2));
               A16LocalidadesDisponibles = A13LocalidadCapacidad;
               AssignAttri(sPrefix, false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
               /* Execute user event: Load */
               E142M2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB2M0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes2M2( )
      {
      }

      protected void STRUP2M0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "VentaGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E132M2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOA37VentaId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA37VentaId"), ".", ","));
            /* Read variables values. */
            A38VentaFecha = context.localUtil.CToD( cgiGet( edtVentaFecha_Internalname), 1);
            AssignAttri(sPrefix, false, "A38VentaFecha", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
            A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
            AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = context.localUtil.CToD( cgiGet( edtEspectaculoFecha_Internalname), 1);
            AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/9999"));
            A43VentaCantidadEntradas = (short)(context.localUtil.CToN( cgiGet( edtVentaCantidadEntradas_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A43VentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(A43VentaCantidadEntradas), 4, 0));
            A40VentaTotal = context.localUtil.CToN( cgiGet( edtVentaTotal_Internalname), ".", ",");
            AssignAttri(sPrefix, false, "A40VentaTotal", StringUtil.LTrimStr( A40VentaTotal, 9, 2));
            A11LocalidadId = (short)(context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            A12LocalidadNombre = cgiGet( edtLocalidadNombre_Internalname);
            AssignAttri(sPrefix, false, "A12LocalidadNombre", A12LocalidadNombre);
            A13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
            A14LocalidadPrecio = context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",");
            AssignAttri(sPrefix, false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
            A15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
            A16LocalidadesDisponibles = (int)(context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
            A17SectorId = (short)(context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A17SectorId", StringUtil.LTrimStr( (decimal)(A17SectorId), 4, 0));
            A18SectorNombre = cgiGet( edtSectorNombre_Internalname);
            AssignAttri(sPrefix, false, "A18SectorNombre", A18SectorNombre);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = new GXProperties();
            forbiddenHiddens.Add("hshsalt", sPrefix+"hsh"+"VentaGeneral");
            A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            forbiddenHiddens.Add("EspectaculoId", context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
            {
               GXUtil.WriteLog("ventageneral:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E132M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132M2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E142M2( )
      {
         /* Load Routine */
         edtEspectaculoNombre_Link = formatLink("viewespectaculo.aspx") + "?" + UrlEncode("" +A34EspectaculoId) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtEspectaculoNombre_Internalname, "Link", edtEspectaculoNombre_Link, true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "Venta";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "VentaId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6VentaId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "GXObligatorio1"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A37VentaId = Convert.ToInt16(getParm(obj,0));
         AssignAttri(sPrefix, false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA2M2( ) ;
         WS2M2( ) ;
         WE2M2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA37VentaId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA2M2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "ventageneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA2M2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A37VentaId = Convert.ToInt16(getParm(obj,2));
            AssignAttri(sPrefix, false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
         wcpOA37VentaId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA37VentaId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A37VentaId != wcpOA37VentaId ) ) )
         {
            setjustcreated();
         }
         wcpOA37VentaId = A37VentaId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA37VentaId = cgiGet( sPrefix+"A37VentaId_CTRL");
         if ( StringUtil.Len( sCtrlA37VentaId) > 0 )
         {
            A37VentaId = (short)(context.localUtil.CToN( cgiGet( sCtrlA37VentaId), ".", ","));
            AssignAttri(sPrefix, false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
         }
         else
         {
            A37VentaId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A37VentaId_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA2M2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS2M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS2M2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A37VentaId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA37VentaId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A37VentaId_CTRL", StringUtil.RTrim( sCtrlA37VentaId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE2M2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022521452542", true, true);
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
         context.AddJavascriptSource("ventageneral.js", "?202022521452542", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtVentaId_Internalname = sPrefix+"VENTAID";
         edtVentaFecha_Internalname = sPrefix+"VENTAFECHA";
         edtEspectaculoId_Internalname = sPrefix+"ESPECTACULOID";
         edtEspectaculoNombre_Internalname = sPrefix+"ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = sPrefix+"ESPECTACULOFECHA";
         edtVentaCantidadEntradas_Internalname = sPrefix+"VENTACANTIDADENTRADAS";
         edtVentaTotal_Internalname = sPrefix+"VENTATOTAL";
         edtLocalidadId_Internalname = sPrefix+"LOCALIDADID";
         edtLocalidadNombre_Internalname = sPrefix+"LOCALIDADNOMBRE";
         edtLocalidadCapacidad_Internalname = sPrefix+"LOCALIDADCAPACIDAD";
         edtLocalidadPrecio_Internalname = sPrefix+"LOCALIDADPRECIO";
         edtLocalidadesVendidas_Internalname = sPrefix+"LOCALIDADESVENDIDAS";
         edtLocalidadesDisponibles_Internalname = sPrefix+"LOCALIDADESDISPONIBLES";
         edtSectorId_Internalname = sPrefix+"SECTORID";
         edtSectorNombre_Internalname = sPrefix+"SECTORNOMBRE";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtSectorNombre_Jsonclick = "";
         edtSectorNombre_Enabled = 0;
         edtSectorId_Jsonclick = "";
         edtSectorId_Enabled = 0;
         edtLocalidadesDisponibles_Jsonclick = "";
         edtLocalidadesDisponibles_Enabled = 0;
         edtLocalidadesVendidas_Jsonclick = "";
         edtLocalidadesVendidas_Enabled = 0;
         edtLocalidadPrecio_Jsonclick = "";
         edtLocalidadPrecio_Enabled = 0;
         edtLocalidadCapacidad_Jsonclick = "";
         edtLocalidadCapacidad_Enabled = 0;
         edtLocalidadNombre_Jsonclick = "";
         edtLocalidadNombre_Enabled = 0;
         edtLocalidadId_Jsonclick = "";
         edtLocalidadId_Enabled = 0;
         edtVentaTotal_Jsonclick = "";
         edtVentaTotal_Enabled = 0;
         edtVentaCantidadEntradas_Jsonclick = "";
         edtVentaCantidadEntradas_Enabled = 0;
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoFecha_Enabled = 0;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Link = "";
         edtEspectaculoNombre_Enabled = 0;
         edtEspectaculoId_Jsonclick = "";
         edtEspectaculoId_Enabled = 0;
         edtVentaFecha_Jsonclick = "";
         edtVentaFecha_Enabled = 0;
         edtVentaId_Jsonclick = "";
         edtVentaId_Enabled = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A37VentaId',fld:'VENTAID',pic:'ZZZ9'},{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E112M1',iparms:[{av:'A37VentaId',fld:'VENTAID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E122M1',iparms:[{av:'A37VentaId',fld:'VENTAID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
         setEventMetadata("VALID_VENTAID","{handler:'Valid_Ventaid',iparms:[]");
         setEventMetadata("VALID_VENTAID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOID","{handler:'Valid_Espectaculoid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOID",",oparms:[]}");
         setEventMetadata("VALID_VENTACANTIDADENTRADAS","{handler:'Valid_Ventacantidadentradas',iparms:[]");
         setEventMetadata("VALID_VENTACANTIDADENTRADAS",",oparms:[]}");
         setEventMetadata("VALID_LOCALIDADID","{handler:'Valid_Localidadid',iparms:[]");
         setEventMetadata("VALID_LOCALIDADID",",oparms:[]}");
         setEventMetadata("VALID_LOCALIDADCAPACIDAD","{handler:'Valid_Localidadcapacidad',iparms:[]");
         setEventMetadata("VALID_LOCALIDADCAPACIDAD",",oparms:[]}");
         setEventMetadata("VALID_LOCALIDADPRECIO","{handler:'Valid_Localidadprecio',iparms:[]");
         setEventMetadata("VALID_LOCALIDADPRECIO",",oparms:[]}");
         setEventMetadata("VALID_SECTORID","{handler:'Valid_Sectorid',iparms:[]");
         setEventMetadata("VALID_SECTORID",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV13Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = new GXProperties();
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A38VentaFecha = DateTime.MinValue;
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A12LocalidadNombre = "";
         A18SectorNombre = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H002M2_A37VentaId = new short[1] ;
         H002M2_A18SectorNombre = new String[] {""} ;
         H002M2_A17SectorId = new short[1] ;
         H002M2_A15LocalidadesVendidas = new int[1] ;
         H002M2_A12LocalidadNombre = new String[] {""} ;
         H002M2_A11LocalidadId = new short[1] ;
         H002M2_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         H002M2_A35EspectaculoNombre = new String[] {""} ;
         H002M2_A34EspectaculoId = new short[1] ;
         H002M2_A38VentaFecha = new DateTime[] {DateTime.MinValue} ;
         H002M2_A14LocalidadPrecio = new decimal[1] ;
         H002M2_A43VentaCantidadEntradas = new short[1] ;
         H002M2_A13LocalidadCapacidad = new int[1] ;
         hsh = "";
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA37VentaId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ventageneral__default(),
            new Object[][] {
                new Object[] {
               H002M2_A37VentaId, H002M2_A18SectorNombre, H002M2_A17SectorId, H002M2_A15LocalidadesVendidas, H002M2_A12LocalidadNombre, H002M2_A11LocalidadId, H002M2_A36EspectaculoFecha, H002M2_A35EspectaculoNombre, H002M2_A34EspectaculoId, H002M2_A38VentaFecha,
               H002M2_A14LocalidadPrecio, H002M2_A43VentaCantidadEntradas, H002M2_A13LocalidadCapacidad
               }
            }
         );
         AV13Pgmname = "VentaGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "VentaGeneral";
         context.Gx_err = 0;
      }

      private short A37VentaId ;
      private short wcpOA37VentaId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short A34EspectaculoId ;
      private short wbEnd ;
      private short wbStart ;
      private short A43VentaCantidadEntradas ;
      private short A11LocalidadId ;
      private short A17SectorId ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6VentaId ;
      private short nGXWrapped ;
      private int edtVentaId_Enabled ;
      private int edtVentaFecha_Enabled ;
      private int edtEspectaculoId_Enabled ;
      private int edtEspectaculoNombre_Enabled ;
      private int edtEspectaculoFecha_Enabled ;
      private int edtVentaCantidadEntradas_Enabled ;
      private int edtVentaTotal_Enabled ;
      private int edtLocalidadId_Enabled ;
      private int edtLocalidadNombre_Enabled ;
      private int A13LocalidadCapacidad ;
      private int edtLocalidadCapacidad_Enabled ;
      private int edtLocalidadPrecio_Enabled ;
      private int A15LocalidadesVendidas ;
      private int edtLocalidadesVendidas_Enabled ;
      private int A16LocalidadesDisponibles ;
      private int edtLocalidadesDisponibles_Enabled ;
      private int edtSectorId_Enabled ;
      private int edtSectorNombre_Enabled ;
      private int idxLst ;
      private decimal A40VentaTotal ;
      private decimal A14LocalidadPrecio ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV13Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divAttributestable_Internalname ;
      private String edtVentaId_Internalname ;
      private String edtVentaId_Jsonclick ;
      private String edtVentaFecha_Internalname ;
      private String edtVentaFecha_Jsonclick ;
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Internalname ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Link ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtVentaCantidadEntradas_Internalname ;
      private String edtVentaCantidadEntradas_Jsonclick ;
      private String edtVentaTotal_Internalname ;
      private String edtVentaTotal_Jsonclick ;
      private String edtLocalidadId_Internalname ;
      private String edtLocalidadId_Jsonclick ;
      private String edtLocalidadNombre_Internalname ;
      private String A12LocalidadNombre ;
      private String edtLocalidadNombre_Jsonclick ;
      private String edtLocalidadCapacidad_Internalname ;
      private String edtLocalidadCapacidad_Jsonclick ;
      private String edtLocalidadPrecio_Internalname ;
      private String edtLocalidadPrecio_Jsonclick ;
      private String edtLocalidadesVendidas_Internalname ;
      private String edtLocalidadesVendidas_Jsonclick ;
      private String edtLocalidadesDisponibles_Internalname ;
      private String edtLocalidadesDisponibles_Jsonclick ;
      private String edtSectorId_Internalname ;
      private String edtSectorId_Jsonclick ;
      private String edtSectorNombre_Internalname ;
      private String A18SectorNombre ;
      private String edtSectorNombre_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA37VentaId ;
      private DateTime A38VentaFecha ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXProperties forbiddenHiddens ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H002M2_A37VentaId ;
      private String[] H002M2_A18SectorNombre ;
      private short[] H002M2_A17SectorId ;
      private int[] H002M2_A15LocalidadesVendidas ;
      private String[] H002M2_A12LocalidadNombre ;
      private short[] H002M2_A11LocalidadId ;
      private DateTime[] H002M2_A36EspectaculoFecha ;
      private String[] H002M2_A35EspectaculoNombre ;
      private short[] H002M2_A34EspectaculoId ;
      private DateTime[] H002M2_A38VentaFecha ;
      private decimal[] H002M2_A14LocalidadPrecio ;
      private short[] H002M2_A43VentaCantidadEntradas ;
      private int[] H002M2_A13LocalidadCapacidad ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class ventageneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002M2 ;
          prmH002M2 = new Object[] {
          new Object[] {"@VentaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002M2", "SELECT T1.[VentaId], T4.[SectorNombre], T1.[SectorId], T3.[LocalidadesVendidas], T3.[LocalidadNombre], T1.[LocalidadId], T2.[EspectaculoFecha], T2.[EspectaculoNombre], T1.[EspectaculoId], T1.[VentaFecha], T3.[LocalidadPrecio], T1.[VentaCantidadEntradas], T3.[LocalidadCapacidad] FROM ((([Venta] T1 INNER JOIN [Espectaculo] T2 ON T2.[EspectaculoId] = T1.[EspectaculoId]) INNER JOIN [EspectaculoLocalidad] T3 ON T3.[EspectaculoId] = T1.[EspectaculoId] AND T3.[LocalidadId] = T1.[LocalidadId]) INNER JOIN [EspectaculoLocalidadSector] T4 ON T4.[EspectaculoId] = T1.[EspectaculoId] AND T4.[LocalidadId] = T1.[LocalidadId] AND T4.[SectorId] = T1.[SectorId]) WHERE T1.[VentaId] = @VentaId ORDER BY T1.[VentaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M2,1, GxCacheFrequency.OFF ,true,true )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 100) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
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
