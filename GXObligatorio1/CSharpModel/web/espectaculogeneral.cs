/*
               File: EspectaculoGeneral
        Description: Espectaculo General
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:51:3.29
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
   public class espectaculogeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public espectaculogeneral( )
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

      public espectaculogeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EspectaculoId )
      {
         this.A34EspectaculoId = aP0_EspectaculoId;
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
                  A34EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A34EspectaculoId});
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
            PA1T2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "EspectaculoGeneral";
               context.Gx_err = 0;
               WS1T2( ) ;
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
            context.SendWebValue( "Espectaculo General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202162151333", false, true);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("espectaculogeneral.aspx") + "?" + UrlEncode("" +A34EspectaculoId)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", sPrefix+"hsh"+"EspectaculoGeneral");
         forbiddenHiddens.Add("TipoEspectaculoId", context.localUtil.Format( (decimal)(A6TipoEspectaculoId), "ZZZ9"));
         forbiddenHiddens.Add("LugarId", context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9"));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("espectaculogeneral:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA34EspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA34EspectaculoId), 4, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm1T2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("espectaculogeneral.js", "?20202162151336", false, true);
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
         return "EspectaculoGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Espectaculo General" ;
      }

      protected void WB1T0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "espectaculogeneral.aspx");
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
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Update", bttBtnupdate_Jsonclick, 7, "Update", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e111t1_client"+"'", TempTags, "", 2, "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Delete", bttBtndelete_Jsonclick, 7, "Delete", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e121t1_client"+"'", TempTags, "", 2, "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEspectaculoId_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")), ((edtEspectaculoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoNombre_Internalname, "Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoNombre_Internalname, StringUtil.RTrim( A35EspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoFecha_Internalname, "Fecha", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtEspectaculoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtEspectaculoFecha_Internalname, context.localUtil.Format(A36EspectaculoFecha, "99/99/99"), context.localUtil.Format( A36EspectaculoFecha, "99/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoFecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_bitmap( context, edtEspectaculoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEspectaculoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoEspectaculoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipoEspectaculoId_Internalname, "Tipo Espectaculo Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtTipoEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TipoEspectaculoId), 4, 0, ".", "")), ((edtTipoEspectaculoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6TipoEspectaculoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A6TipoEspectaculoId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoEspectaculoId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtTipoEspectaculoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoEspectaculoNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTipoEspectaculoNombre_Internalname, "Tipo Espectaculo Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtTipoEspectaculoNombre_Internalname, StringUtil.RTrim( A7TipoEspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A7TipoEspectaculoNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtTipoEspectaculoNombre_Link, "", "", "", edtTipoEspectaculoNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtTipoEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoPaisId_Internalname, "Pais Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")), ((edtEspectaculoPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoPaisNombre_Internalname, "Pais Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisNombre_Internalname, StringUtil.RTrim( A20EspectaculoPaisNombre), StringUtil.RTrim( context.localUtil.Format( A20EspectaculoPaisNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoCiudadId_Internalname, "Ciudad Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")), ((edtEspectaculoCiudadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoCiudadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoCiudadNombre_Internalname, "Ciudad Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadNombre_Internalname, StringUtil.RTrim( A23EspectaculoCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A23EspectaculoCiudadNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLugarId_Internalname, "Lugar Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")), ((edtLugarId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9")) : context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLugarId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtLugarNombre_Internalname, "Lugar Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarNombre_Internalname, StringUtil.RTrim( A9LugarNombre), StringUtil.RTrim( context.localUtil.Format( A9LugarNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtLugarNombre_Link, "", "", "", edtLugarNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLugarNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarPaisId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLugarPaisId_Internalname, "Pais Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29LugarPaisId), 4, 0, ".", "")), ((edtLugarPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A29LugarPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A29LugarPaisId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarPaisId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLugarPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarPaisNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLugarPaisNombre_Internalname, "Pais Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarPaisNombre_Internalname, StringUtil.RTrim( A30LugarPaisNombre), StringUtil.RTrim( context.localUtil.Format( A30LugarPaisNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarPaisNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLugarPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarCiudadId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLugarCiudadId_Internalname, "Ciudad Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32LugarCiudadId), 4, 0, ".", "")), ((edtLugarCiudadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32LugarCiudadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A32LugarCiudadId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarCiudadId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLugarCiudadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarCiudadNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLugarCiudadNombre_Internalname, "Ciudad Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarCiudadNombre_Internalname, StringUtil.RTrim( A33LugarCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A33LugarCiudadNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarCiudadNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtLugarCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divImagestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Pais Bandera", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A21EspectaculoPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000EspectaculoPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera));
            GxWebStd.gx_bitmap( context, imgEspectaculoPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A21EspectaculoPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Lugar Foto", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A10LugarFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40003LugarFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.PathToRelativeUrl( A10LugarFoto));
            GxWebStd.gx_bitmap( context, imgLugarFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A10LugarFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_EspectaculoGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Pais Bandera", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A31LugarPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40001LugarPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40001LugarPaisBandera_GXI : context.PathToRelativeUrl( A31LugarPaisBandera));
            GxWebStd.gx_bitmap( context, imgLugarPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A31LugarPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_EspectaculoGeneral.htm");
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

      protected void START1T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "Espectaculo General", 0) ;
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
               STRUP1T0( ) ;
            }
         }
      }

      protected void WS1T2( )
      {
         START1T2( ) ;
         EVT1T2( ) ;
      }

      protected void EVT1T2( )
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
                                 STRUP1T0( ) ;
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
                                 STRUP1T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E131T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E141T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1T0( ) ;
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
                                 STRUP1T0( ) ;
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

      protected void WE1T2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1T2( ) ;
            }
         }
      }

      protected void PA1T2( )
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
         RF1T2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "EspectaculoGeneral";
         context.Gx_err = 0;
      }

      protected void RF1T2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001T2 */
            pr_default.execute(0, new Object[] {A34EspectaculoId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40001LugarPaisBandera_GXI = H001T2_A40001LugarPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40001LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
               n40001LugarPaisBandera_GXI = H001T2_n40001LugarPaisBandera_GXI[0];
               A40003LugarFoto_GXI = H001T2_A40003LugarFoto_GXI[0];
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A40000EspectaculoPaisBandera_GXI = H001T2_A40000EspectaculoPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40000EspectaculoPaisBandera_GXI = H001T2_n40000EspectaculoPaisBandera_GXI[0];
               A33LugarCiudadNombre = H001T2_A33LugarCiudadNombre[0];
               AssignAttri(sPrefix, false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
               A32LugarCiudadId = H001T2_A32LugarCiudadId[0];
               AssignAttri(sPrefix, false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
               A30LugarPaisNombre = H001T2_A30LugarPaisNombre[0];
               AssignAttri(sPrefix, false, "A30LugarPaisNombre", A30LugarPaisNombre);
               A29LugarPaisId = H001T2_A29LugarPaisId[0];
               AssignAttri(sPrefix, false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
               A9LugarNombre = H001T2_A9LugarNombre[0];
               AssignAttri(sPrefix, false, "A9LugarNombre", A9LugarNombre);
               A8LugarId = H001T2_A8LugarId[0];
               AssignAttri(sPrefix, false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               A23EspectaculoCiudadNombre = H001T2_A23EspectaculoCiudadNombre[0];
               AssignAttri(sPrefix, false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
               A22EspectaculoCiudadId = H001T2_A22EspectaculoCiudadId[0];
               AssignAttri(sPrefix, false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
               A20EspectaculoPaisNombre = H001T2_A20EspectaculoPaisNombre[0];
               AssignAttri(sPrefix, false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
               A19EspectaculoPaisId = H001T2_A19EspectaculoPaisId[0];
               AssignAttri(sPrefix, false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
               A7TipoEspectaculoNombre = H001T2_A7TipoEspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
               A6TipoEspectaculoId = H001T2_A6TipoEspectaculoId[0];
               AssignAttri(sPrefix, false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
               A36EspectaculoFecha = H001T2_A36EspectaculoFecha[0];
               AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               A35EspectaculoNombre = H001T2_A35EspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
               A31LugarPaisBandera = H001T2_A31LugarPaisBandera[0];
               AssignAttri(sPrefix, false, "A31LugarPaisBandera", A31LugarPaisBandera);
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40001LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
               A10LugarFoto = H001T2_A10LugarFoto[0];
               AssignAttri(sPrefix, false, "A10LugarFoto", A10LugarFoto);
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A21EspectaculoPaisBandera = H001T2_A21EspectaculoPaisBandera[0];
               AssignAttri(sPrefix, false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A40001LugarPaisBandera_GXI = H001T2_A40001LugarPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40001LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
               n40001LugarPaisBandera_GXI = H001T2_n40001LugarPaisBandera_GXI[0];
               A30LugarPaisNombre = H001T2_A30LugarPaisNombre[0];
               AssignAttri(sPrefix, false, "A30LugarPaisNombre", A30LugarPaisNombre);
               A31LugarPaisBandera = H001T2_A31LugarPaisBandera[0];
               AssignAttri(sPrefix, false, "A31LugarPaisBandera", A31LugarPaisBandera);
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40001LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
               AssignProp(sPrefix, false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
               A33LugarCiudadNombre = H001T2_A33LugarCiudadNombre[0];
               AssignAttri(sPrefix, false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
               A40003LugarFoto_GXI = H001T2_A40003LugarFoto_GXI[0];
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A9LugarNombre = H001T2_A9LugarNombre[0];
               AssignAttri(sPrefix, false, "A9LugarNombre", A9LugarNombre);
               A10LugarFoto = H001T2_A10LugarFoto[0];
               AssignAttri(sPrefix, false, "A10LugarFoto", A10LugarFoto);
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
               AssignProp(sPrefix, false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A40000EspectaculoPaisBandera_GXI = H001T2_A40000EspectaculoPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40000EspectaculoPaisBandera_GXI = H001T2_n40000EspectaculoPaisBandera_GXI[0];
               A20EspectaculoPaisNombre = H001T2_A20EspectaculoPaisNombre[0];
               AssignAttri(sPrefix, false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
               A21EspectaculoPaisBandera = H001T2_A21EspectaculoPaisBandera[0];
               AssignAttri(sPrefix, false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A23EspectaculoCiudadNombre = H001T2_A23EspectaculoCiudadNombre[0];
               AssignAttri(sPrefix, false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
               A7TipoEspectaculoNombre = H001T2_A7TipoEspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
               /* Execute user event: Load */
               E141T2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB1T0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1T2( )
      {
      }

      protected void STRUP1T0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "EspectaculoGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E131T2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOA34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA34EspectaculoId"), ".", ","));
            /* Read variables values. */
            A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
            AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = context.localUtil.CToD( cgiGet( edtEspectaculoFecha_Internalname), 1);
            AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A6TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtTipoEspectaculoId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
            A7TipoEspectaculoNombre = cgiGet( edtTipoEspectaculoNombre_Internalname);
            AssignAttri(sPrefix, false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
            A19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A20EspectaculoPaisNombre = cgiGet( edtEspectaculoPaisNombre_Internalname);
            AssignAttri(sPrefix, false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            A23EspectaculoCiudadNombre = cgiGet( edtEspectaculoCiudadNombre_Internalname);
            AssignAttri(sPrefix, false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            A8LugarId = (short)(context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            A9LugarNombre = cgiGet( edtLugarNombre_Internalname);
            AssignAttri(sPrefix, false, "A9LugarNombre", A9LugarNombre);
            A29LugarPaisId = (short)(context.localUtil.CToN( cgiGet( edtLugarPaisId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
            A30LugarPaisNombre = cgiGet( edtLugarPaisNombre_Internalname);
            AssignAttri(sPrefix, false, "A30LugarPaisNombre", A30LugarPaisNombre);
            A32LugarCiudadId = (short)(context.localUtil.CToN( cgiGet( edtLugarCiudadId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
            A33LugarCiudadNombre = cgiGet( edtLugarCiudadNombre_Internalname);
            AssignAttri(sPrefix, false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
            A21EspectaculoPaisBandera = cgiGet( imgEspectaculoPaisBandera_Internalname);
            AssignAttri(sPrefix, false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            A10LugarFoto = cgiGet( imgLugarFoto_Internalname);
            AssignAttri(sPrefix, false, "A10LugarFoto", A10LugarFoto);
            A31LugarPaisBandera = cgiGet( imgLugarPaisBandera_Internalname);
            AssignAttri(sPrefix, false, "A31LugarPaisBandera", A31LugarPaisBandera);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = new GXProperties();
            forbiddenHiddens.Add("hshsalt", sPrefix+"hsh"+"EspectaculoGeneral");
            A6TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtTipoEspectaculoId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
            forbiddenHiddens.Add("TipoEspectaculoId", context.localUtil.Format( (decimal)(A6TipoEspectaculoId), "ZZZ9"));
            A8LugarId = (short)(context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            forbiddenHiddens.Add("LugarId", context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9"));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
            {
               GXUtil.WriteLog("espectaculogeneral:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
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
         E131T2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131T2( )
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

      protected void E141T2( )
      {
         /* Load Routine */
         edtTipoEspectaculoNombre_Link = formatLink("viewtipoespectaculo.aspx") + "?" + UrlEncode("" +A6TipoEspectaculoId) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtTipoEspectaculoNombre_Internalname, "Link", edtTipoEspectaculoNombre_Link, true);
         edtLugarNombre_Link = formatLink("viewlugar.aspx") + "?" + UrlEncode("" +A8LugarId) + "," + UrlEncode(StringUtil.RTrim(""));
         AssignProp(sPrefix, false, edtLugarNombre_Internalname, "Link", edtLugarNombre_Link, true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "Espectaculo";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "EspectaculoId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6EspectaculoId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "GXObligatorio1"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A34EspectaculoId = Convert.ToInt16(getParm(obj,0));
         AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
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
         PA1T2( ) ;
         WS1T2( ) ;
         WE1T2( ) ;
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
         sCtrlA34EspectaculoId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1T2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "espectaculogeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1T2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A34EspectaculoId = Convert.ToInt16(getParm(obj,2));
            AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         }
         wcpOA34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA34EspectaculoId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A34EspectaculoId != wcpOA34EspectaculoId ) ) )
         {
            setjustcreated();
         }
         wcpOA34EspectaculoId = A34EspectaculoId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA34EspectaculoId = cgiGet( sPrefix+"A34EspectaculoId_CTRL");
         if ( StringUtil.Len( sCtrlA34EspectaculoId) > 0 )
         {
            A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( sCtrlA34EspectaculoId), ".", ","));
            AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         }
         else
         {
            A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A34EspectaculoId_PARM"), ".", ","));
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
         PA1T2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1T2( ) ;
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
         WS1T2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A34EspectaculoId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA34EspectaculoId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A34EspectaculoId_CTRL", StringUtil.RTrim( sCtrlA34EspectaculoId));
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
         WE1T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202162151395", true, true);
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
         context.AddJavascriptSource("espectaculogeneral.js", "?20202162151395", false, true);
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
         edtEspectaculoId_Internalname = sPrefix+"ESPECTACULOID";
         edtEspectaculoNombre_Internalname = sPrefix+"ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = sPrefix+"ESPECTACULOFECHA";
         edtTipoEspectaculoId_Internalname = sPrefix+"TIPOESPECTACULOID";
         edtTipoEspectaculoNombre_Internalname = sPrefix+"TIPOESPECTACULONOMBRE";
         edtEspectaculoPaisId_Internalname = sPrefix+"ESPECTACULOPAISID";
         edtEspectaculoPaisNombre_Internalname = sPrefix+"ESPECTACULOPAISNOMBRE";
         edtEspectaculoCiudadId_Internalname = sPrefix+"ESPECTACULOCIUDADID";
         edtEspectaculoCiudadNombre_Internalname = sPrefix+"ESPECTACULOCIUDADNOMBRE";
         edtLugarId_Internalname = sPrefix+"LUGARID";
         edtLugarNombre_Internalname = sPrefix+"LUGARNOMBRE";
         edtLugarPaisId_Internalname = sPrefix+"LUGARPAISID";
         edtLugarPaisNombre_Internalname = sPrefix+"LUGARPAISNOMBRE";
         edtLugarCiudadId_Internalname = sPrefix+"LUGARCIUDADID";
         edtLugarCiudadNombre_Internalname = sPrefix+"LUGARCIUDADNOMBRE";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         imgEspectaculoPaisBandera_Internalname = sPrefix+"ESPECTACULOPAISBANDERA";
         imgLugarFoto_Internalname = sPrefix+"LUGARFOTO";
         imgLugarPaisBandera_Internalname = sPrefix+"LUGARPAISBANDERA";
         divImagestable_Internalname = sPrefix+"IMAGESTABLE";
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
         edtLugarCiudadNombre_Jsonclick = "";
         edtLugarCiudadNombre_Enabled = 0;
         edtLugarCiudadId_Jsonclick = "";
         edtLugarCiudadId_Enabled = 0;
         edtLugarPaisNombre_Jsonclick = "";
         edtLugarPaisNombre_Enabled = 0;
         edtLugarPaisId_Jsonclick = "";
         edtLugarPaisId_Enabled = 0;
         edtLugarNombre_Jsonclick = "";
         edtLugarNombre_Link = "";
         edtLugarNombre_Enabled = 0;
         edtLugarId_Jsonclick = "";
         edtLugarId_Enabled = 0;
         edtEspectaculoCiudadNombre_Jsonclick = "";
         edtEspectaculoCiudadNombre_Enabled = 0;
         edtEspectaculoCiudadId_Jsonclick = "";
         edtEspectaculoCiudadId_Enabled = 0;
         edtEspectaculoPaisNombre_Jsonclick = "";
         edtEspectaculoPaisNombre_Enabled = 0;
         edtEspectaculoPaisId_Jsonclick = "";
         edtEspectaculoPaisId_Enabled = 0;
         edtTipoEspectaculoNombre_Jsonclick = "";
         edtTipoEspectaculoNombre_Link = "";
         edtTipoEspectaculoNombre_Enabled = 0;
         edtTipoEspectaculoId_Jsonclick = "";
         edtTipoEspectaculoId_Enabled = 0;
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoFecha_Enabled = 0;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Enabled = 0;
         edtEspectaculoId_Jsonclick = "";
         edtEspectaculoId_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'},{av:'A6TipoEspectaculoId',fld:'TIPOESPECTACULOID',pic:'ZZZ9'},{av:'A8LugarId',fld:'LUGARID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E111T1',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E121T1',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOID","{handler:'Valid_Espectaculoid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOID",",oparms:[]}");
         setEventMetadata("VALID_TIPOESPECTACULOID","{handler:'Valid_Tipoespectaculoid',iparms:[]");
         setEventMetadata("VALID_TIPOESPECTACULOID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOPAISID","{handler:'Valid_Espectaculopaisid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOPAISID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOCIUDADID","{handler:'Valid_Espectaculociudadid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOCIUDADID",",oparms:[]}");
         setEventMetadata("VALID_LUGARID","{handler:'Valid_Lugarid',iparms:[]");
         setEventMetadata("VALID_LUGARID",",oparms:[]}");
         setEventMetadata("VALID_LUGARPAISID","{handler:'Valid_Lugarpaisid',iparms:[]");
         setEventMetadata("VALID_LUGARPAISID",",oparms:[]}");
         setEventMetadata("VALID_LUGARCIUDADID","{handler:'Valid_Lugarciudadid',iparms:[]");
         setEventMetadata("VALID_LUGARCIUDADID",",oparms:[]}");
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
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A7TipoEspectaculoNombre = "";
         A20EspectaculoPaisNombre = "";
         A23EspectaculoCiudadNombre = "";
         A9LugarNombre = "";
         A30LugarPaisNombre = "";
         A33LugarCiudadNombre = "";
         A21EspectaculoPaisBandera = "";
         A40000EspectaculoPaisBandera_GXI = "";
         sImgUrl = "";
         A10LugarFoto = "";
         A40003LugarFoto_GXI = "";
         A31LugarPaisBandera = "";
         A40001LugarPaisBandera_GXI = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H001T2_A34EspectaculoId = new short[1] ;
         H001T2_A40001LugarPaisBandera_GXI = new String[] {""} ;
         H001T2_n40001LugarPaisBandera_GXI = new bool[] {false} ;
         H001T2_A40003LugarFoto_GXI = new String[] {""} ;
         H001T2_A40000EspectaculoPaisBandera_GXI = new String[] {""} ;
         H001T2_n40000EspectaculoPaisBandera_GXI = new bool[] {false} ;
         H001T2_A33LugarCiudadNombre = new String[] {""} ;
         H001T2_A32LugarCiudadId = new short[1] ;
         H001T2_A30LugarPaisNombre = new String[] {""} ;
         H001T2_A29LugarPaisId = new short[1] ;
         H001T2_A9LugarNombre = new String[] {""} ;
         H001T2_A8LugarId = new short[1] ;
         H001T2_A23EspectaculoCiudadNombre = new String[] {""} ;
         H001T2_A22EspectaculoCiudadId = new short[1] ;
         H001T2_A20EspectaculoPaisNombre = new String[] {""} ;
         H001T2_A19EspectaculoPaisId = new short[1] ;
         H001T2_A7TipoEspectaculoNombre = new String[] {""} ;
         H001T2_A6TipoEspectaculoId = new short[1] ;
         H001T2_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         H001T2_A35EspectaculoNombre = new String[] {""} ;
         H001T2_A31LugarPaisBandera = new String[] {""} ;
         H001T2_A10LugarFoto = new String[] {""} ;
         H001T2_A21EspectaculoPaisBandera = new String[] {""} ;
         hsh = "";
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA34EspectaculoId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.espectaculogeneral__default(),
            new Object[][] {
                new Object[] {
               H001T2_A34EspectaculoId, H001T2_A40001LugarPaisBandera_GXI, H001T2_n40001LugarPaisBandera_GXI, H001T2_A40003LugarFoto_GXI, H001T2_A40000EspectaculoPaisBandera_GXI, H001T2_n40000EspectaculoPaisBandera_GXI, H001T2_A33LugarCiudadNombre, H001T2_A32LugarCiudadId, H001T2_A30LugarPaisNombre, H001T2_A29LugarPaisId,
               H001T2_A9LugarNombre, H001T2_A8LugarId, H001T2_A23EspectaculoCiudadNombre, H001T2_A22EspectaculoCiudadId, H001T2_A20EspectaculoPaisNombre, H001T2_A19EspectaculoPaisId, H001T2_A7TipoEspectaculoNombre, H001T2_A6TipoEspectaculoId, H001T2_A36EspectaculoFecha, H001T2_A35EspectaculoNombre,
               H001T2_A31LugarPaisBandera, H001T2_A10LugarFoto, H001T2_A21EspectaculoPaisBandera
               }
            }
         );
         AV13Pgmname = "EspectaculoGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "EspectaculoGeneral";
         context.Gx_err = 0;
      }

      private short A34EspectaculoId ;
      private short wcpOA34EspectaculoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short A6TipoEspectaculoId ;
      private short A8LugarId ;
      private short wbEnd ;
      private short wbStart ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short A29LugarPaisId ;
      private short A32LugarCiudadId ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6EspectaculoId ;
      private short nGXWrapped ;
      private int edtEspectaculoId_Enabled ;
      private int edtEspectaculoNombre_Enabled ;
      private int edtEspectaculoFecha_Enabled ;
      private int edtTipoEspectaculoId_Enabled ;
      private int edtTipoEspectaculoNombre_Enabled ;
      private int edtEspectaculoPaisId_Enabled ;
      private int edtEspectaculoPaisNombre_Enabled ;
      private int edtEspectaculoCiudadId_Enabled ;
      private int edtEspectaculoCiudadNombre_Enabled ;
      private int edtLugarId_Enabled ;
      private int edtLugarNombre_Enabled ;
      private int edtLugarPaisId_Enabled ;
      private int edtLugarPaisNombre_Enabled ;
      private int edtLugarCiudadId_Enabled ;
      private int edtLugarCiudadNombre_Enabled ;
      private int idxLst ;
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
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Internalname ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtTipoEspectaculoId_Internalname ;
      private String edtTipoEspectaculoId_Jsonclick ;
      private String edtTipoEspectaculoNombre_Internalname ;
      private String A7TipoEspectaculoNombre ;
      private String edtTipoEspectaculoNombre_Link ;
      private String edtTipoEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoPaisId_Internalname ;
      private String edtEspectaculoPaisId_Jsonclick ;
      private String edtEspectaculoPaisNombre_Internalname ;
      private String A20EspectaculoPaisNombre ;
      private String edtEspectaculoPaisNombre_Jsonclick ;
      private String edtEspectaculoCiudadId_Internalname ;
      private String edtEspectaculoCiudadId_Jsonclick ;
      private String edtEspectaculoCiudadNombre_Internalname ;
      private String A23EspectaculoCiudadNombre ;
      private String edtEspectaculoCiudadNombre_Jsonclick ;
      private String edtLugarId_Internalname ;
      private String edtLugarId_Jsonclick ;
      private String edtLugarNombre_Internalname ;
      private String A9LugarNombre ;
      private String edtLugarNombre_Link ;
      private String edtLugarNombre_Jsonclick ;
      private String edtLugarPaisId_Internalname ;
      private String edtLugarPaisId_Jsonclick ;
      private String edtLugarPaisNombre_Internalname ;
      private String A30LugarPaisNombre ;
      private String edtLugarPaisNombre_Jsonclick ;
      private String edtLugarCiudadId_Internalname ;
      private String edtLugarCiudadId_Jsonclick ;
      private String edtLugarCiudadNombre_Internalname ;
      private String A33LugarCiudadNombre ;
      private String edtLugarCiudadNombre_Jsonclick ;
      private String divImagestable_Internalname ;
      private String sImgUrl ;
      private String imgEspectaculoPaisBandera_Internalname ;
      private String imgLugarFoto_Internalname ;
      private String imgLugarPaisBandera_Internalname ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA34EspectaculoId ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A21EspectaculoPaisBandera_IsBlob ;
      private bool A10LugarFoto_IsBlob ;
      private bool A31LugarPaisBandera_IsBlob ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n40001LugarPaisBandera_GXI ;
      private bool n40000EspectaculoPaisBandera_GXI ;
      private bool returnInSub ;
      private String A40000EspectaculoPaisBandera_GXI ;
      private String A40003LugarFoto_GXI ;
      private String A40001LugarPaisBandera_GXI ;
      private String A21EspectaculoPaisBandera ;
      private String A10LugarFoto ;
      private String A31LugarPaisBandera ;
      private GXProperties forbiddenHiddens ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H001T2_A34EspectaculoId ;
      private String[] H001T2_A40001LugarPaisBandera_GXI ;
      private bool[] H001T2_n40001LugarPaisBandera_GXI ;
      private String[] H001T2_A40003LugarFoto_GXI ;
      private String[] H001T2_A40000EspectaculoPaisBandera_GXI ;
      private bool[] H001T2_n40000EspectaculoPaisBandera_GXI ;
      private String[] H001T2_A33LugarCiudadNombre ;
      private short[] H001T2_A32LugarCiudadId ;
      private String[] H001T2_A30LugarPaisNombre ;
      private short[] H001T2_A29LugarPaisId ;
      private String[] H001T2_A9LugarNombre ;
      private short[] H001T2_A8LugarId ;
      private String[] H001T2_A23EspectaculoCiudadNombre ;
      private short[] H001T2_A22EspectaculoCiudadId ;
      private String[] H001T2_A20EspectaculoPaisNombre ;
      private short[] H001T2_A19EspectaculoPaisId ;
      private String[] H001T2_A7TipoEspectaculoNombre ;
      private short[] H001T2_A6TipoEspectaculoId ;
      private DateTime[] H001T2_A36EspectaculoFecha ;
      private String[] H001T2_A35EspectaculoNombre ;
      private String[] H001T2_A31LugarPaisBandera ;
      private String[] H001T2_A10LugarFoto ;
      private String[] H001T2_A21EspectaculoPaisBandera ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class espectaculogeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001T2 ;
          prmH001T2 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001T2", "SELECT T1.[EspectaculoId], T2.[PaisBandera_GXI] AS LugarPaisBandera_GXI, T4.[LugarFoto_GXI], T5.[PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, T3.[CiudadNombre] AS LugarCiudadNombre, T1.[LugarCiudadId] AS LugarCiudadId, T2.[PaisNombre] AS LugarPaisNombre, T1.[LugarPaisId] AS LugarPaisId, T4.[LugarNombre], T1.[LugarId], T6.[CiudadNombre] AS EspectaculoCiudadNombre, T1.[EspectaculoCiudadId] AS EspectaculoCiudadId, T5.[PaisNombre] AS EspectaculoPaisNombre, T1.[EspectaculoPaisId] AS EspectaculoPaisId, T7.[TipoEspectaculoNombre], T1.[TipoEspectaculoId], T1.[EspectaculoFecha], T1.[EspectaculoNombre], T2.[PaisBandera] AS LugarPaisBandera, T4.[LugarFoto], T5.[PaisBandera] AS EspectaculoPaisBandera FROM (((((([Espectaculo] T1 INNER JOIN [Pais] T2 ON T2.[PaisId] = T1.[LugarPaisId]) INNER JOIN [PaisCiudad] T3 ON T3.[PaisId] = T1.[LugarPaisId] AND T3.[CiudadId] = T1.[LugarCiudadId]) INNER JOIN [Lugar] T4 ON T4.[LugarId] = T1.[LugarId]) INNER JOIN [Pais] T5 ON T5.[PaisId] = T1.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T6 ON T6.[PaisId] = T1.[EspectaculoPaisId] AND T6.[CiudadId] = T1.[EspectaculoCiudadId]) INNER JOIN [TipoEspectaculo] T7 ON T7.[TipoEspectaculoId] = T1.[TipoEspectaculoId]) WHERE T1.[EspectaculoId] = @EspectaculoId ORDER BY T1.[EspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001T2,1, GxCacheFrequency.OFF ,true,true )
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[4])[0] = rslt.getMultimediaUri(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 100) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((String[]) buf[8])[0] = rslt.getString(7, 100) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getString(9, 100) ;
                ((short[]) buf[11])[0] = rslt.getShort(10) ;
                ((String[]) buf[12])[0] = rslt.getString(11, 100) ;
                ((short[]) buf[13])[0] = rslt.getShort(12) ;
                ((String[]) buf[14])[0] = rslt.getString(13, 100) ;
                ((short[]) buf[15])[0] = rslt.getShort(14) ;
                ((String[]) buf[16])[0] = rslt.getString(15, 100) ;
                ((short[]) buf[17])[0] = rslt.getShort(16) ;
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(17) ;
                ((String[]) buf[19])[0] = rslt.getString(18, 100) ;
                ((String[]) buf[20])[0] = rslt.getMultimediaFile(19, rslt.getVarchar(2)) ;
                ((String[]) buf[21])[0] = rslt.getMultimediaFile(20, rslt.getVarchar(3)) ;
                ((String[]) buf[22])[0] = rslt.getMultimediaFile(21, rslt.getVarchar(4)) ;
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
