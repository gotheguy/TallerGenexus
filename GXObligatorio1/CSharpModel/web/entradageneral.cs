/*
               File: EntradaGeneral
        Description: Entrada General
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:51:2.81
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
   public class entradageneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public entradageneral( )
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

      public entradageneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EntradaId )
      {
         this.A39EntradaId = aP0_EntradaId;
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
                  A39EntradaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri(sPrefix, false, "A39EntradaId", StringUtil.LTrimStr( (decimal)(A39EntradaId), 4, 0));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A39EntradaId});
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
            PA1D2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "EntradaGeneral";
               context.Gx_err = 0;
               WS1D2( ) ;
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
            context.SendWebValue( "Entrada General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202162151285", false, true);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("entradageneral.aspx") + "?" + UrlEncode("" +A39EntradaId)+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA39EntradaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA39EntradaId), 4, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm1D2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("entradageneral.js", "?20202162151287", false, true);
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
         return "EntradaGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Entrada General" ;
      }

      protected void WB1D0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "entradageneral.aspx");
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
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Update", bttBtnupdate_Jsonclick, 7, "Update", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e111d1_client"+"'", TempTags, "", 2, "HLP_EntradaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Delete", bttBtndelete_Jsonclick, 7, "Delete", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e121d1_client"+"'", TempTags, "", 2, "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEntradaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEntradaId_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEntradaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39EntradaId), 4, 0, ".", "")), ((edtEntradaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A39EntradaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A39EntradaId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEntradaId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEntradaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVentaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVentaId_Internalname, "Venta Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")), ((edtVentaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")), ((edtEspectaculoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEspectaculoNombre_Internalname, StringUtil.RTrim( A35EspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtEspectaculoNombre_Link, "", "", "", edtEspectaculoNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtEspectaculoFecha_Internalname, context.localUtil.Format(A36EspectaculoFecha, "99/99/99"), context.localUtil.Format( A36EspectaculoFecha, "99/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoFecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_EntradaGeneral.htm");
            GxWebStd.gx_bitmap( context, edtEspectaculoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEspectaculoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtVentaPaisId_Internalname, "Venta Pais Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A24VentaPaisId), 4, 0, ".", "")), ((edtVentaPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A24VentaPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A24VentaPaisId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaPaisId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtVentaPaisNombre_Internalname, "Venta Pais Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaPaisNombre_Internalname, StringUtil.RTrim( A25VentaPaisNombre), StringUtil.RTrim( context.localUtil.Format( A25VentaPaisNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaPaisNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtVentaCiudadId_Internalname, "Venta Ciudad Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A27VentaCiudadId), 4, 0, ".", "")), ((edtVentaCiudadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A27VentaCiudadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A27VentaCiudadId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaCiudadId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaCiudadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtVentaCiudadNombre_Internalname, "Venta Ciudad Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVentaCiudadNombre_Internalname, StringUtil.RTrim( A28VentaCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A28VentaCiudadNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVentaCiudadNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtVentaCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoPaisId_Internalname, "Espectaculo Pais Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")), ((edtEspectaculoPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoPaisNombre_Internalname, "Espectaculo Pais Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisNombre_Internalname, StringUtil.RTrim( A20EspectaculoPaisNombre), StringUtil.RTrim( context.localUtil.Format( A20EspectaculoPaisNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoCiudadId_Internalname, "Espectaculo Ciudad Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")), ((edtEspectaculoCiudadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoCiudadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, edtEspectaculoCiudadNombre_Internalname, "Espectaculo Ciudad Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadNombre_Internalname, StringUtil.RTrim( A23EspectaculoCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A23EspectaculoCiudadNombre, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, "", "Venta Fecha", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A38VentaFecha_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000VentaFecha_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.PathToRelativeUrl( A38VentaFecha));
            GxWebStd.gx_bitmap( context, imgVentaFecha_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A38VentaFecha_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, "", "Venta Pais Bandera", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A26VentaPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40001VentaPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.PathToRelativeUrl( A26VentaPaisBandera));
            GxWebStd.gx_bitmap( context, imgVentaPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A26VentaPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_EntradaGeneral.htm");
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
            GxWebStd.gx_label_element( context, "", "Espectaculo Pais Bandera", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A21EspectaculoPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40004EspectaculoPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera));
            GxWebStd.gx_bitmap( context, imgEspectaculoPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A21EspectaculoPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_EntradaGeneral.htm");
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

      protected void START1D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "Entrada General", 0) ;
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
               STRUP1D0( ) ;
            }
         }
      }

      protected void WS1D2( )
      {
         START1D2( ) ;
         EVT1D2( ) ;
      }

      protected void EVT1D2( )
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
                                 STRUP1D0( ) ;
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
                                 STRUP1D0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E131D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1D0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E141D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1D0( ) ;
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
                                 STRUP1D0( ) ;
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

      protected void WE1D2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1D2( ) ;
            }
         }
      }

      protected void PA1D2( )
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
         RF1D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "EntradaGeneral";
         context.Gx_err = 0;
      }

      protected void RF1D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001D2 */
            pr_default.execute(0, new Object[] {A39EntradaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40004EspectaculoPaisBandera_GXI = H001D2_A40004EspectaculoPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40004EspectaculoPaisBandera_GXI = H001D2_n40004EspectaculoPaisBandera_GXI[0];
               A40001VentaPaisBandera_GXI = H001D2_A40001VentaPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               n40001VentaPaisBandera_GXI = H001D2_n40001VentaPaisBandera_GXI[0];
               A40000VentaFecha_GXI = H001D2_A40000VentaFecha_GXI[0];
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A23EspectaculoCiudadNombre = H001D2_A23EspectaculoCiudadNombre[0];
               AssignAttri(sPrefix, false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
               A22EspectaculoCiudadId = H001D2_A22EspectaculoCiudadId[0];
               AssignAttri(sPrefix, false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
               A20EspectaculoPaisNombre = H001D2_A20EspectaculoPaisNombre[0];
               AssignAttri(sPrefix, false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
               A19EspectaculoPaisId = H001D2_A19EspectaculoPaisId[0];
               AssignAttri(sPrefix, false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
               A28VentaCiudadNombre = H001D2_A28VentaCiudadNombre[0];
               AssignAttri(sPrefix, false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
               A27VentaCiudadId = H001D2_A27VentaCiudadId[0];
               AssignAttri(sPrefix, false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
               A25VentaPaisNombre = H001D2_A25VentaPaisNombre[0];
               AssignAttri(sPrefix, false, "A25VentaPaisNombre", A25VentaPaisNombre);
               A24VentaPaisId = H001D2_A24VentaPaisId[0];
               AssignAttri(sPrefix, false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
               A36EspectaculoFecha = H001D2_A36EspectaculoFecha[0];
               AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               A35EspectaculoNombre = H001D2_A35EspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
               A34EspectaculoId = H001D2_A34EspectaculoId[0];
               AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               A37VentaId = H001D2_A37VentaId[0];
               AssignAttri(sPrefix, false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
               A21EspectaculoPaisBandera = H001D2_A21EspectaculoPaisBandera[0];
               AssignAttri(sPrefix, false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A26VentaPaisBandera = H001D2_A26VentaPaisBandera[0];
               AssignAttri(sPrefix, false, "A26VentaPaisBandera", A26VentaPaisBandera);
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               A38VentaFecha = H001D2_A38VentaFecha[0];
               AssignAttri(sPrefix, false, "A38VentaFecha", A38VentaFecha);
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A40000VentaFecha_GXI = H001D2_A40000VentaFecha_GXI[0];
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A27VentaCiudadId = H001D2_A27VentaCiudadId[0];
               AssignAttri(sPrefix, false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
               A24VentaPaisId = H001D2_A24VentaPaisId[0];
               AssignAttri(sPrefix, false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
               A34EspectaculoId = H001D2_A34EspectaculoId[0];
               AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               A38VentaFecha = H001D2_A38VentaFecha[0];
               AssignAttri(sPrefix, false, "A38VentaFecha", A38VentaFecha);
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), true);
               AssignProp(sPrefix, false, imgVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A40001VentaPaisBandera_GXI = H001D2_A40001VentaPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               n40001VentaPaisBandera_GXI = H001D2_n40001VentaPaisBandera_GXI[0];
               A25VentaPaisNombre = H001D2_A25VentaPaisNombre[0];
               AssignAttri(sPrefix, false, "A25VentaPaisNombre", A25VentaPaisNombre);
               A26VentaPaisBandera = H001D2_A26VentaPaisBandera[0];
               AssignAttri(sPrefix, false, "A26VentaPaisBandera", A26VentaPaisBandera);
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), true);
               AssignProp(sPrefix, false, imgVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               A28VentaCiudadNombre = H001D2_A28VentaCiudadNombre[0];
               AssignAttri(sPrefix, false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
               A22EspectaculoCiudadId = H001D2_A22EspectaculoCiudadId[0];
               AssignAttri(sPrefix, false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
               A19EspectaculoPaisId = H001D2_A19EspectaculoPaisId[0];
               AssignAttri(sPrefix, false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
               A36EspectaculoFecha = H001D2_A36EspectaculoFecha[0];
               AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               A35EspectaculoNombre = H001D2_A35EspectaculoNombre[0];
               AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
               A40004EspectaculoPaisBandera_GXI = H001D2_A40004EspectaculoPaisBandera_GXI[0];
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40004EspectaculoPaisBandera_GXI = H001D2_n40004EspectaculoPaisBandera_GXI[0];
               A20EspectaculoPaisNombre = H001D2_A20EspectaculoPaisNombre[0];
               AssignAttri(sPrefix, false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
               A21EspectaculoPaisBandera = H001D2_A21EspectaculoPaisBandera[0];
               AssignAttri(sPrefix, false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
               AssignProp(sPrefix, false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A23EspectaculoCiudadNombre = H001D2_A23EspectaculoCiudadNombre[0];
               AssignAttri(sPrefix, false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
               /* Execute user event: Load */
               E141D2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB1D0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1D2( )
      {
      }

      protected void STRUP1D0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "EntradaGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E131D2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOA39EntradaId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA39EntradaId"), ".", ","));
            /* Read variables values. */
            A37VentaId = (short)(context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A37VentaId", StringUtil.LTrimStr( (decimal)(A37VentaId), 4, 0));
            A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
            AssignAttri(sPrefix, false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = context.localUtil.CToD( cgiGet( edtEspectaculoFecha_Internalname), 1);
            AssignAttri(sPrefix, false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A24VentaPaisId = (short)(context.localUtil.CToN( cgiGet( edtVentaPaisId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A24VentaPaisId", StringUtil.LTrimStr( (decimal)(A24VentaPaisId), 4, 0));
            A25VentaPaisNombre = cgiGet( edtVentaPaisNombre_Internalname);
            AssignAttri(sPrefix, false, "A25VentaPaisNombre", A25VentaPaisNombre);
            A27VentaCiudadId = (short)(context.localUtil.CToN( cgiGet( edtVentaCiudadId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A27VentaCiudadId", StringUtil.LTrimStr( (decimal)(A27VentaCiudadId), 4, 0));
            A28VentaCiudadNombre = cgiGet( edtVentaCiudadNombre_Internalname);
            AssignAttri(sPrefix, false, "A28VentaCiudadNombre", A28VentaCiudadNombre);
            A19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A20EspectaculoPaisNombre = cgiGet( edtEspectaculoPaisNombre_Internalname);
            AssignAttri(sPrefix, false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            A23EspectaculoCiudadNombre = cgiGet( edtEspectaculoCiudadNombre_Internalname);
            AssignAttri(sPrefix, false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            A38VentaFecha = cgiGet( imgVentaFecha_Internalname);
            AssignAttri(sPrefix, false, "A38VentaFecha", A38VentaFecha);
            A26VentaPaisBandera = cgiGet( imgVentaPaisBandera_Internalname);
            AssignAttri(sPrefix, false, "A26VentaPaisBandera", A26VentaPaisBandera);
            A21EspectaculoPaisBandera = cgiGet( imgEspectaculoPaisBandera_Internalname);
            AssignAttri(sPrefix, false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E131D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131D2( )
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

      protected void E141D2( )
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
         AV7TrnContext.gxTpr_Transactionname = "Entrada";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "EntradaId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6EntradaId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "GXObligatorio1"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A39EntradaId = Convert.ToInt16(getParm(obj,0));
         AssignAttri(sPrefix, false, "A39EntradaId", StringUtil.LTrimStr( (decimal)(A39EntradaId), 4, 0));
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
         PA1D2( ) ;
         WS1D2( ) ;
         WE1D2( ) ;
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
         sCtrlA39EntradaId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1D2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "entradageneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1D2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A39EntradaId = Convert.ToInt16(getParm(obj,2));
            AssignAttri(sPrefix, false, "A39EntradaId", StringUtil.LTrimStr( (decimal)(A39EntradaId), 4, 0));
         }
         wcpOA39EntradaId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA39EntradaId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A39EntradaId != wcpOA39EntradaId ) ) )
         {
            setjustcreated();
         }
         wcpOA39EntradaId = A39EntradaId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA39EntradaId = cgiGet( sPrefix+"A39EntradaId_CTRL");
         if ( StringUtil.Len( sCtrlA39EntradaId) > 0 )
         {
            A39EntradaId = (short)(context.localUtil.CToN( cgiGet( sCtrlA39EntradaId), ".", ","));
            AssignAttri(sPrefix, false, "A39EntradaId", StringUtil.LTrimStr( (decimal)(A39EntradaId), 4, 0));
         }
         else
         {
            A39EntradaId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A39EntradaId_PARM"), ".", ","));
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
         PA1D2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1D2( ) ;
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
         WS1D2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A39EntradaId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39EntradaId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA39EntradaId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A39EntradaId_CTRL", StringUtil.RTrim( sCtrlA39EntradaId));
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
         WE1D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202162151341", true, true);
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
         context.AddJavascriptSource("entradageneral.js", "?20202162151342", false, true);
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
         edtEntradaId_Internalname = sPrefix+"ENTRADAID";
         edtVentaId_Internalname = sPrefix+"VENTAID";
         edtEspectaculoId_Internalname = sPrefix+"ESPECTACULOID";
         edtEspectaculoNombre_Internalname = sPrefix+"ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = sPrefix+"ESPECTACULOFECHA";
         edtVentaPaisId_Internalname = sPrefix+"VENTAPAISID";
         edtVentaPaisNombre_Internalname = sPrefix+"VENTAPAISNOMBRE";
         edtVentaCiudadId_Internalname = sPrefix+"VENTACIUDADID";
         edtVentaCiudadNombre_Internalname = sPrefix+"VENTACIUDADNOMBRE";
         edtEspectaculoPaisId_Internalname = sPrefix+"ESPECTACULOPAISID";
         edtEspectaculoPaisNombre_Internalname = sPrefix+"ESPECTACULOPAISNOMBRE";
         edtEspectaculoCiudadId_Internalname = sPrefix+"ESPECTACULOCIUDADID";
         edtEspectaculoCiudadNombre_Internalname = sPrefix+"ESPECTACULOCIUDADNOMBRE";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         imgVentaFecha_Internalname = sPrefix+"VENTAFECHA";
         imgVentaPaisBandera_Internalname = sPrefix+"VENTAPAISBANDERA";
         imgEspectaculoPaisBandera_Internalname = sPrefix+"ESPECTACULOPAISBANDERA";
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
         edtEspectaculoCiudadNombre_Jsonclick = "";
         edtEspectaculoCiudadNombre_Enabled = 0;
         edtEspectaculoCiudadId_Jsonclick = "";
         edtEspectaculoCiudadId_Enabled = 0;
         edtEspectaculoPaisNombre_Jsonclick = "";
         edtEspectaculoPaisNombre_Enabled = 0;
         edtEspectaculoPaisId_Jsonclick = "";
         edtEspectaculoPaisId_Enabled = 0;
         edtVentaCiudadNombre_Jsonclick = "";
         edtVentaCiudadNombre_Enabled = 0;
         edtVentaCiudadId_Jsonclick = "";
         edtVentaCiudadId_Enabled = 0;
         edtVentaPaisNombre_Jsonclick = "";
         edtVentaPaisNombre_Enabled = 0;
         edtVentaPaisId_Jsonclick = "";
         edtVentaPaisId_Enabled = 0;
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoFecha_Enabled = 0;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Link = "";
         edtEspectaculoNombre_Enabled = 0;
         edtEspectaculoId_Jsonclick = "";
         edtEspectaculoId_Enabled = 0;
         edtVentaId_Jsonclick = "";
         edtVentaId_Enabled = 0;
         edtEntradaId_Jsonclick = "";
         edtEntradaId_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A39EntradaId',fld:'ENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E111D1',iparms:[{av:'A39EntradaId',fld:'ENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E121D1',iparms:[{av:'A39EntradaId',fld:'ENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
         setEventMetadata("VALID_ENTRADAID","{handler:'Valid_Entradaid',iparms:[]");
         setEventMetadata("VALID_ENTRADAID",",oparms:[]}");
         setEventMetadata("VALID_VENTAID","{handler:'Valid_Ventaid',iparms:[]");
         setEventMetadata("VALID_VENTAID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOID","{handler:'Valid_Espectaculoid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOID",",oparms:[]}");
         setEventMetadata("VALID_VENTAPAISID","{handler:'Valid_Ventapaisid',iparms:[]");
         setEventMetadata("VALID_VENTAPAISID",",oparms:[]}");
         setEventMetadata("VALID_VENTACIUDADID","{handler:'Valid_Ventaciudadid',iparms:[]");
         setEventMetadata("VALID_VENTACIUDADID",",oparms:[]}");
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
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A25VentaPaisNombre = "";
         A28VentaCiudadNombre = "";
         A20EspectaculoPaisNombre = "";
         A23EspectaculoCiudadNombre = "";
         A38VentaFecha = "";
         A40000VentaFecha_GXI = "";
         sImgUrl = "";
         A26VentaPaisBandera = "";
         A40001VentaPaisBandera_GXI = "";
         A21EspectaculoPaisBandera = "";
         A40004EspectaculoPaisBandera_GXI = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H001D2_A39EntradaId = new short[1] ;
         H001D2_A40004EspectaculoPaisBandera_GXI = new String[] {""} ;
         H001D2_n40004EspectaculoPaisBandera_GXI = new bool[] {false} ;
         H001D2_A40001VentaPaisBandera_GXI = new String[] {""} ;
         H001D2_n40001VentaPaisBandera_GXI = new bool[] {false} ;
         H001D2_A40000VentaFecha_GXI = new String[] {""} ;
         H001D2_A23EspectaculoCiudadNombre = new String[] {""} ;
         H001D2_A22EspectaculoCiudadId = new short[1] ;
         H001D2_A20EspectaculoPaisNombre = new String[] {""} ;
         H001D2_A19EspectaculoPaisId = new short[1] ;
         H001D2_A28VentaCiudadNombre = new String[] {""} ;
         H001D2_A27VentaCiudadId = new short[1] ;
         H001D2_A25VentaPaisNombre = new String[] {""} ;
         H001D2_A24VentaPaisId = new short[1] ;
         H001D2_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         H001D2_A35EspectaculoNombre = new String[] {""} ;
         H001D2_A34EspectaculoId = new short[1] ;
         H001D2_A37VentaId = new short[1] ;
         H001D2_A21EspectaculoPaisBandera = new String[] {""} ;
         H001D2_A26VentaPaisBandera = new String[] {""} ;
         H001D2_A38VentaFecha = new String[] {""} ;
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA39EntradaId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.entradageneral__default(),
            new Object[][] {
                new Object[] {
               H001D2_A39EntradaId, H001D2_A40004EspectaculoPaisBandera_GXI, H001D2_n40004EspectaculoPaisBandera_GXI, H001D2_A40001VentaPaisBandera_GXI, H001D2_n40001VentaPaisBandera_GXI, H001D2_A40000VentaFecha_GXI, H001D2_A23EspectaculoCiudadNombre, H001D2_A22EspectaculoCiudadId, H001D2_A20EspectaculoPaisNombre, H001D2_A19EspectaculoPaisId,
               H001D2_A28VentaCiudadNombre, H001D2_A27VentaCiudadId, H001D2_A25VentaPaisNombre, H001D2_A24VentaPaisId, H001D2_A36EspectaculoFecha, H001D2_A35EspectaculoNombre, H001D2_A34EspectaculoId, H001D2_A37VentaId, H001D2_A21EspectaculoPaisBandera, H001D2_A26VentaPaisBandera,
               H001D2_A38VentaFecha
               }
            }
         );
         AV13Pgmname = "EntradaGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "EntradaGeneral";
         context.Gx_err = 0;
      }

      private short A39EntradaId ;
      private short wcpOA39EntradaId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A37VentaId ;
      private short A34EspectaculoId ;
      private short A24VentaPaisId ;
      private short A27VentaCiudadId ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6EntradaId ;
      private short nGXWrapped ;
      private int edtEntradaId_Enabled ;
      private int edtVentaId_Enabled ;
      private int edtEspectaculoId_Enabled ;
      private int edtEspectaculoNombre_Enabled ;
      private int edtEspectaculoFecha_Enabled ;
      private int edtVentaPaisId_Enabled ;
      private int edtVentaPaisNombre_Enabled ;
      private int edtVentaCiudadId_Enabled ;
      private int edtVentaCiudadNombre_Enabled ;
      private int edtEspectaculoPaisId_Enabled ;
      private int edtEspectaculoPaisNombre_Enabled ;
      private int edtEspectaculoCiudadId_Enabled ;
      private int edtEspectaculoCiudadNombre_Enabled ;
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
      private String edtEntradaId_Internalname ;
      private String edtEntradaId_Jsonclick ;
      private String edtVentaId_Internalname ;
      private String edtVentaId_Jsonclick ;
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Internalname ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Link ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtVentaPaisId_Internalname ;
      private String edtVentaPaisId_Jsonclick ;
      private String edtVentaPaisNombre_Internalname ;
      private String A25VentaPaisNombre ;
      private String edtVentaPaisNombre_Jsonclick ;
      private String edtVentaCiudadId_Internalname ;
      private String edtVentaCiudadId_Jsonclick ;
      private String edtVentaCiudadNombre_Internalname ;
      private String A28VentaCiudadNombre ;
      private String edtVentaCiudadNombre_Jsonclick ;
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
      private String divImagestable_Internalname ;
      private String sImgUrl ;
      private String imgVentaFecha_Internalname ;
      private String imgVentaPaisBandera_Internalname ;
      private String imgEspectaculoPaisBandera_Internalname ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA39EntradaId ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A38VentaFecha_IsBlob ;
      private bool A26VentaPaisBandera_IsBlob ;
      private bool A21EspectaculoPaisBandera_IsBlob ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n40004EspectaculoPaisBandera_GXI ;
      private bool n40001VentaPaisBandera_GXI ;
      private bool returnInSub ;
      private String A40000VentaFecha_GXI ;
      private String A40001VentaPaisBandera_GXI ;
      private String A40004EspectaculoPaisBandera_GXI ;
      private String A38VentaFecha ;
      private String A26VentaPaisBandera ;
      private String A21EspectaculoPaisBandera ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H001D2_A39EntradaId ;
      private String[] H001D2_A40004EspectaculoPaisBandera_GXI ;
      private bool[] H001D2_n40004EspectaculoPaisBandera_GXI ;
      private String[] H001D2_A40001VentaPaisBandera_GXI ;
      private bool[] H001D2_n40001VentaPaisBandera_GXI ;
      private String[] H001D2_A40000VentaFecha_GXI ;
      private String[] H001D2_A23EspectaculoCiudadNombre ;
      private short[] H001D2_A22EspectaculoCiudadId ;
      private String[] H001D2_A20EspectaculoPaisNombre ;
      private short[] H001D2_A19EspectaculoPaisId ;
      private String[] H001D2_A28VentaCiudadNombre ;
      private short[] H001D2_A27VentaCiudadId ;
      private String[] H001D2_A25VentaPaisNombre ;
      private short[] H001D2_A24VentaPaisId ;
      private DateTime[] H001D2_A36EspectaculoFecha ;
      private String[] H001D2_A35EspectaculoNombre ;
      private short[] H001D2_A34EspectaculoId ;
      private short[] H001D2_A37VentaId ;
      private String[] H001D2_A21EspectaculoPaisBandera ;
      private String[] H001D2_A26VentaPaisBandera ;
      private String[] H001D2_A38VentaFecha ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class entradageneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001D2 ;
          prmH001D2 = new Object[] {
          new Object[] {"@EntradaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001D2", "SELECT T1.[EntradaId], T6.[PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, T3.[PaisBandera_GXI] AS VentaPaisBandera_GXI, T2.[VentaFecha_GXI], T7.[CiudadNombre] AS EspectaculoCiudadNombre, T5.[EspectaculoCiudadId] AS EspectaculoCiudadId, T6.[PaisNombre] AS EspectaculoPaisNombre, T5.[EspectaculoPaisId] AS EspectaculoPaisId, T4.[CiudadNombre] AS VentaCiudadNombre, T2.[VentaCiudadId] AS VentaCiudadId, T3.[PaisNombre] AS VentaPaisNombre, T2.[VentaPaisId] AS VentaPaisId, T5.[EspectaculoFecha], T5.[EspectaculoNombre], T2.[EspectaculoId], T1.[VentaId], T6.[PaisBandera] AS EspectaculoPaisBandera, T3.[PaisBandera] AS VentaPaisBandera, T2.[VentaFecha] FROM (((((([Entrada] T1 INNER JOIN [Venta] T2 ON T2.[VentaId] = T1.[VentaId]) INNER JOIN [Pais] T3 ON T3.[PaisId] = T2.[VentaPaisId]) INNER JOIN [PaisCiudad] T4 ON T4.[PaisId] = T2.[VentaPaisId] AND T4.[CiudadId] = T2.[VentaCiudadId]) INNER JOIN [Espectaculo] T5 ON T5.[EspectaculoId] = T2.[EspectaculoId]) INNER JOIN [Pais] T6 ON T6.[PaisId] = T5.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T7 ON T7.[PaisId] = T5.[EspectaculoPaisId] AND T7.[CiudadId] = T5.[EspectaculoCiudadId]) WHERE T1.[EntradaId] = @EntradaId ORDER BY T1.[EntradaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001D2,1, GxCacheFrequency.OFF ,true,true )
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
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getMultimediaUri(4) ;
                ((String[]) buf[6])[0] = rslt.getString(5, 100) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((String[]) buf[8])[0] = rslt.getString(7, 100) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getString(9, 100) ;
                ((short[]) buf[11])[0] = rslt.getShort(10) ;
                ((String[]) buf[12])[0] = rslt.getString(11, 100) ;
                ((short[]) buf[13])[0] = rslt.getShort(12) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDate(13) ;
                ((String[]) buf[15])[0] = rslt.getString(14, 100) ;
                ((short[]) buf[16])[0] = rslt.getShort(15) ;
                ((short[]) buf[17])[0] = rslt.getShort(16) ;
                ((String[]) buf[18])[0] = rslt.getMultimediaFile(17, rslt.getVarchar(2)) ;
                ((String[]) buf[19])[0] = rslt.getMultimediaFile(18, rslt.getVarchar(3)) ;
                ((String[]) buf[20])[0] = rslt.getMultimediaFile(19, rslt.getVarchar(4)) ;
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
