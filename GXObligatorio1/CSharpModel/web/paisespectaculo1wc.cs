/*
               File: PaisEspectaculo1WC
        Description: Pais Espectaculo1 WC
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:51:3.68
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
   public class paisespectaculo1wc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public paisespectaculo1wc( )
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

      public paisespectaculo1wc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_LugarPaisId )
      {
         this.AV6LugarPaisId = aP0_LugarPaisId;
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
                  AV6LugarPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri(sPrefix, false, "AV6LugarPaisId", StringUtil.LTrimStr( (decimal)(AV6LugarPaisId), 4, 0));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV6LugarPaisId});
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
               {
                  nRC_GXsfl_20 = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_20_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_20_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  AV11Update = GetNextPar( );
                  AV12Delete = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGrid_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  AV6LugarPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV11Update = GetNextPar( );
                  AV12Delete = GetNextPar( );
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV6LugarPaisId, AV11Update, AV12Delete, sPrefix) ;
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  send_integrity_footer_hashes( ) ;
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  AddString( context.getJSONResponse( )) ;
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
            PA152( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "PaisEspectaculo1WC";
               context.Gx_err = 0;
               edtavUpdate_Enabled = 0;
               AssignProp(sPrefix, false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_20_Refreshing);
               edtavDelete_Enabled = 0;
               AssignProp(sPrefix, false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_20_Refreshing);
               WS152( ) ;
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
            context.SendWebValue( "Pais Espectaculo1 WC") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202162151373", false, true);
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
            FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("paisespectaculo1wc.aspx") + "?" + UrlEncode("" +AV6LugarPaisId)+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
               context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
               AssignProp(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
            }
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
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_20", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_20), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV6LugarPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV6LugarPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vLUGARPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6LugarPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm152( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("paisespectaculo1wc.js", "?20202162151375", false, true);
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
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
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
         return "PaisEspectaculo1WC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Pais Espectaculo1 WC" ;
      }

      protected void WB150( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "paisespectaculo1wc.aspx");
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "GridTabMainTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-2 col-sm-offset-1 ViewGridActionsCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(20), 2, 0)+","+"null"+");", "Insert", bttBtninsert_Jsonclick, 5, "Insert", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_PaisEspectaculo1WC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 ViewGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"20\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "ViewGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Espectaculo Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Espectaculo Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pais Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pais Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Pais Bandera") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ciudad Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ciudad Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Lugar Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Lugar Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Lugar Foto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ciudad Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Ciudad Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"TextActionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "ViewGrid");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A35EspectaculoNombre));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtEspectaculoNombre_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TipoEspectaculoId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A7TipoEspectaculoNombre));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtTipoEspectaculoNombre_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A20EspectaculoPaisNombre));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( A21EspectaculoPaisBandera));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A23EspectaculoCiudadNombre));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A9LugarNombre));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtLugarNombre_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( A10LugarFoto));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32LugarCiudadId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A33LugarCiudadNombre));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV11Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV12Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 20 )
         {
            wbEnd = 0;
            nRC_GXsfl_20 = (int)(nGXsfl_20_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLugarPaisId_Internalname, "Lugar Pais Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtLugarPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29LugarPaisId), 4, 0, ".", "")), ((edtLugarPaisId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A29LugarPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(A29LugarPaisId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarPaisId_Jsonclick, 0, "Attribute", "", "", "", "", edtLugarPaisId_Visible, edtLugarPaisId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_PaisEspectaculo1WC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 20 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
                  GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START152( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "Pais Espectaculo1 WC", 0) ;
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
               STRUP150( ) ;
            }
         }
      }

      protected void WS152( )
      {
         START152( ) ;
         EVT152( ) ;
      }

      protected void EVT152( )
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
                                 STRUP150( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP150( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E11152 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP150( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP150( ) ;
                              }
                              sEvt = cgiGet( sPrefix+"GRIDPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP150( ) ;
                              }
                              nGXsfl_20_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_20_idx), 4, 0), 4, "0");
                              SubsflControlProps_202( ) ;
                              A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                              A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
                              A36EspectaculoFecha = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtEspectaculoFecha_Internalname), 0));
                              A6TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtTipoEspectaculoId_Internalname), ".", ","));
                              A7TipoEspectaculoNombre = cgiGet( edtTipoEspectaculoNombre_Internalname);
                              A19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ","));
                              A20EspectaculoPaisNombre = cgiGet( edtEspectaculoPaisNombre_Internalname);
                              A21EspectaculoPaisBandera = cgiGet( edtEspectaculoPaisBandera_Internalname);
                              AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_20_Refreshing);
                              AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
                              A22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ","));
                              A23EspectaculoCiudadNombre = cgiGet( edtEspectaculoCiudadNombre_Internalname);
                              A8LugarId = (short)(context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ","));
                              A9LugarNombre = cgiGet( edtLugarNombre_Internalname);
                              A10LugarFoto = cgiGet( edtLugarFoto_Internalname);
                              AssignProp(sPrefix, false, edtLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), !bGXsfl_20_Refreshing);
                              AssignProp(sPrefix, false, edtLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
                              A32LugarCiudadId = (short)(context.localUtil.CToN( cgiGet( edtLugarCiudadId_Internalname), ".", ","));
                              A33LugarCiudadNombre = cgiGet( edtLugarCiudadNombre_Internalname);
                              AV11Update = cgiGet( edtavUpdate_Internalname);
                              AssignAttri(sPrefix, false, edtavUpdate_Internalname, AV11Update);
                              AV12Delete = cgiGet( edtavDelete_Internalname);
                              AssignAttri(sPrefix, false, edtavDelete_Internalname, AV12Delete);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: Start */
                                          E12152 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          E13152 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
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
                                       STRUP150( ) ;
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
      }

      protected void WE152( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm152( ) ;
            }
         }
      }

      protected void PA152( )
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

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_202( ) ;
         while ( nGXsfl_20_idx <= nRC_GXsfl_20 )
         {
            sendrow_202( ) ;
            nGXsfl_20_idx = ((subGrid_Islastpage==1)&&(nGXsfl_20_idx+1>subGrid_fnc_Recordsperpage( )) ? 1 : nGXsfl_20_idx+1);
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_20_idx), 4, 0), 4, "0");
            SubsflControlProps_202( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( GridContainer)) ;
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV6LugarPaisId ,
                                       String AV11Update ,
                                       String AV12Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID_nCurrentRecord = 0;
         RF152( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_ESPECTACULOID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"ESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
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
         RF152( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "PaisEspectaculo1WC";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         AssignProp(sPrefix, false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_20_Refreshing);
         edtavDelete_Enabled = 0;
         AssignProp(sPrefix, false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_20_Refreshing);
      }

      protected void RF152( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 20;
         nGXsfl_20_idx = 1;
         sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_20_idx), 4, 0), 4, "0");
         SubsflControlProps_202( ) ;
         bGXsfl_20_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "ViewGrid");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_202( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_fnc_Recordsperpage( )+1);
            /* Using cursor H00152 */
            pr_default.execute(0, new Object[] {AV6LugarPaisId, GXPagingFrom2, GXPagingTo2});
            nGXsfl_20_idx = 1;
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_20_idx), 4, 0), 4, "0");
            SubsflControlProps_202( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_fnc_Recordsperpage( ) ) ) ) )
            {
               A29LugarPaisId = H00152_A29LugarPaisId[0];
               AssignAttri(sPrefix, false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
               A33LugarCiudadNombre = H00152_A33LugarCiudadNombre[0];
               A32LugarCiudadId = H00152_A32LugarCiudadId[0];
               A40003LugarFoto_GXI = H00152_A40003LugarFoto_GXI[0];
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A9LugarNombre = H00152_A9LugarNombre[0];
               A8LugarId = H00152_A8LugarId[0];
               A23EspectaculoCiudadNombre = H00152_A23EspectaculoCiudadNombre[0];
               A22EspectaculoCiudadId = H00152_A22EspectaculoCiudadId[0];
               A40000EspectaculoPaisBandera_GXI = H00152_A40000EspectaculoPaisBandera_GXI[0];
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40000EspectaculoPaisBandera_GXI = H00152_n40000EspectaculoPaisBandera_GXI[0];
               A20EspectaculoPaisNombre = H00152_A20EspectaculoPaisNombre[0];
               A19EspectaculoPaisId = H00152_A19EspectaculoPaisId[0];
               A7TipoEspectaculoNombre = H00152_A7TipoEspectaculoNombre[0];
               A6TipoEspectaculoId = H00152_A6TipoEspectaculoId[0];
               A36EspectaculoFecha = H00152_A36EspectaculoFecha[0];
               A35EspectaculoNombre = H00152_A35EspectaculoNombre[0];
               A34EspectaculoId = H00152_A34EspectaculoId[0];
               A10LugarFoto = H00152_A10LugarFoto[0];
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A21EspectaculoPaisBandera = H00152_A21EspectaculoPaisBandera[0];
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A33LugarCiudadNombre = H00152_A33LugarCiudadNombre[0];
               A40003LugarFoto_GXI = H00152_A40003LugarFoto_GXI[0];
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A9LugarNombre = H00152_A9LugarNombre[0];
               A10LugarFoto = H00152_A10LugarFoto[0];
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
               A40000EspectaculoPaisBandera_GXI = H00152_A40000EspectaculoPaisBandera_GXI[0];
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40000EspectaculoPaisBandera_GXI = H00152_n40000EspectaculoPaisBandera_GXI[0];
               A20EspectaculoPaisNombre = H00152_A20EspectaculoPaisNombre[0];
               A21EspectaculoPaisBandera = H00152_A21EspectaculoPaisBandera[0];
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_20_Refreshing);
               AssignProp(sPrefix, false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A23EspectaculoCiudadNombre = H00152_A23EspectaculoCiudadNombre[0];
               A7TipoEspectaculoNombre = H00152_A7TipoEspectaculoNombre[0];
               E13152 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 20;
            WB150( ) ;
         }
         bGXsfl_20_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes152( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_ESPECTACULOID"+"_"+sGXsfl_20_idx, GetSecureSignedToken( sPrefix+sGXsfl_20_idx, context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"), context));
      }

      protected int subGrid_fnc_Pagecount( )
      {
         GRID_nRecordCount = subGrid_fnc_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_fnc_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_fnc_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_fnc_Recordcount( )
      {
         /* Using cursor H00153 */
         pr_default.execute(1, new Object[] {AV6LugarPaisId});
         GRID_nRecordCount = H00153_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_fnc_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_fnc_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6LugarPaisId, AV11Update, AV12Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_fnc_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_fnc_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6LugarPaisId, AV11Update, AV12Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_fnc_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6LugarPaisId, AV11Update, AV12Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_fnc_Recordcount( );
         if ( GRID_nRecordCount > subGrid_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_fnc_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_fnc_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6LugarPaisId, AV11Update, AV12Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV6LugarPaisId, AV11Update, AV12Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP150( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "PaisEspectaculo1WC";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         AssignProp(sPrefix, false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_20_Refreshing);
         edtavDelete_Enabled = 0;
         AssignProp(sPrefix, false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_20_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12152 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_20 = (int)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_20"), ".", ","));
            wcpOAV6LugarPaisId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6LugarPaisId"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read variables values. */
            A29LugarPaisId = (short)(context.localUtil.CToN( cgiGet( edtLugarPaisId_Internalname), ".", ","));
            AssignAttri(sPrefix, false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E12152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12152( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV16Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV11Update = "Update";
         AssignAttri(sPrefix, false, edtavUpdate_Internalname, AV11Update);
         AV12Delete = "Delete";
         AssignAttri(sPrefix, false, edtavDelete_Internalname, AV12Delete);
         edtLugarPaisId_Visible = 0;
         AssignProp(sPrefix, false, edtLugarPaisId_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(edtLugarPaisId_Visible), 5, 0), true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E13152( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("espectaculo.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A34EspectaculoId);
         edtavDelete_Link = formatLink("espectaculo.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A34EspectaculoId);
         edtEspectaculoNombre_Link = formatLink("viewespectaculo.aspx") + "?" + UrlEncode("" +A34EspectaculoId) + "," + UrlEncode(StringUtil.RTrim(""));
         edtTipoEspectaculoNombre_Link = formatLink("viewtipoespectaculo.aspx") + "?" + UrlEncode("" +A6TipoEspectaculoId) + "," + UrlEncode(StringUtil.RTrim(""));
         edtLugarNombre_Link = formatLink("viewlugar.aspx") + "?" + UrlEncode("" +A8LugarId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 20;
         }
         sendrow_202( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_20_Refreshing )
         {
            context.DoAjaxLoad(20, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E11152( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("espectaculo.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new SdtTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "Espectaculo";
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "LugarPaisId";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6LugarPaisId), 4, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV7Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "TransactionContext", "GXObligatorio1"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6LugarPaisId = Convert.ToInt16(getParm(obj,0));
         AssignAttri(sPrefix, false, "AV6LugarPaisId", StringUtil.LTrimStr( (decimal)(AV6LugarPaisId), 4, 0));
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
         PA152( ) ;
         WS152( ) ;
         WE152( ) ;
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
         sCtrlAV6LugarPaisId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA152( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "paisespectaculo1wc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA152( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV6LugarPaisId = Convert.ToInt16(getParm(obj,2));
            AssignAttri(sPrefix, false, "AV6LugarPaisId", StringUtil.LTrimStr( (decimal)(AV6LugarPaisId), 4, 0));
         }
         wcpOAV6LugarPaisId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV6LugarPaisId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV6LugarPaisId != wcpOAV6LugarPaisId ) ) )
         {
            setjustcreated();
         }
         wcpOAV6LugarPaisId = AV6LugarPaisId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV6LugarPaisId = cgiGet( sPrefix+"AV6LugarPaisId_CTRL");
         if ( StringUtil.Len( sCtrlAV6LugarPaisId) > 0 )
         {
            AV6LugarPaisId = (short)(context.localUtil.CToN( cgiGet( sCtrlAV6LugarPaisId), ".", ","));
            AssignAttri(sPrefix, false, "AV6LugarPaisId", StringUtil.LTrimStr( (decimal)(AV6LugarPaisId), 4, 0));
         }
         else
         {
            AV6LugarPaisId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV6LugarPaisId_PARM"), ".", ","));
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
         PA152( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS152( ) ;
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
         WS152( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV6LugarPaisId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6LugarPaisId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV6LugarPaisId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV6LugarPaisId_CTRL", StringUtil.RTrim( sCtrlAV6LugarPaisId));
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
         WE152( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202162151426", true, true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("paisespectaculo1wc.js", "?20202162151426", false, true);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_202( )
      {
         edtEspectaculoId_Internalname = sPrefix+"ESPECTACULOID_"+sGXsfl_20_idx;
         edtEspectaculoNombre_Internalname = sPrefix+"ESPECTACULONOMBRE_"+sGXsfl_20_idx;
         edtEspectaculoFecha_Internalname = sPrefix+"ESPECTACULOFECHA_"+sGXsfl_20_idx;
         edtTipoEspectaculoId_Internalname = sPrefix+"TIPOESPECTACULOID_"+sGXsfl_20_idx;
         edtTipoEspectaculoNombre_Internalname = sPrefix+"TIPOESPECTACULONOMBRE_"+sGXsfl_20_idx;
         edtEspectaculoPaisId_Internalname = sPrefix+"ESPECTACULOPAISID_"+sGXsfl_20_idx;
         edtEspectaculoPaisNombre_Internalname = sPrefix+"ESPECTACULOPAISNOMBRE_"+sGXsfl_20_idx;
         edtEspectaculoPaisBandera_Internalname = sPrefix+"ESPECTACULOPAISBANDERA_"+sGXsfl_20_idx;
         edtEspectaculoCiudadId_Internalname = sPrefix+"ESPECTACULOCIUDADID_"+sGXsfl_20_idx;
         edtEspectaculoCiudadNombre_Internalname = sPrefix+"ESPECTACULOCIUDADNOMBRE_"+sGXsfl_20_idx;
         edtLugarId_Internalname = sPrefix+"LUGARID_"+sGXsfl_20_idx;
         edtLugarNombre_Internalname = sPrefix+"LUGARNOMBRE_"+sGXsfl_20_idx;
         edtLugarFoto_Internalname = sPrefix+"LUGARFOTO_"+sGXsfl_20_idx;
         edtLugarCiudadId_Internalname = sPrefix+"LUGARCIUDADID_"+sGXsfl_20_idx;
         edtLugarCiudadNombre_Internalname = sPrefix+"LUGARCIUDADNOMBRE_"+sGXsfl_20_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_20_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_20_idx;
      }

      protected void SubsflControlProps_fel_202( )
      {
         edtEspectaculoId_Internalname = sPrefix+"ESPECTACULOID_"+sGXsfl_20_fel_idx;
         edtEspectaculoNombre_Internalname = sPrefix+"ESPECTACULONOMBRE_"+sGXsfl_20_fel_idx;
         edtEspectaculoFecha_Internalname = sPrefix+"ESPECTACULOFECHA_"+sGXsfl_20_fel_idx;
         edtTipoEspectaculoId_Internalname = sPrefix+"TIPOESPECTACULOID_"+sGXsfl_20_fel_idx;
         edtTipoEspectaculoNombre_Internalname = sPrefix+"TIPOESPECTACULONOMBRE_"+sGXsfl_20_fel_idx;
         edtEspectaculoPaisId_Internalname = sPrefix+"ESPECTACULOPAISID_"+sGXsfl_20_fel_idx;
         edtEspectaculoPaisNombre_Internalname = sPrefix+"ESPECTACULOPAISNOMBRE_"+sGXsfl_20_fel_idx;
         edtEspectaculoPaisBandera_Internalname = sPrefix+"ESPECTACULOPAISBANDERA_"+sGXsfl_20_fel_idx;
         edtEspectaculoCiudadId_Internalname = sPrefix+"ESPECTACULOCIUDADID_"+sGXsfl_20_fel_idx;
         edtEspectaculoCiudadNombre_Internalname = sPrefix+"ESPECTACULOCIUDADNOMBRE_"+sGXsfl_20_fel_idx;
         edtLugarId_Internalname = sPrefix+"LUGARID_"+sGXsfl_20_fel_idx;
         edtLugarNombre_Internalname = sPrefix+"LUGARNOMBRE_"+sGXsfl_20_fel_idx;
         edtLugarFoto_Internalname = sPrefix+"LUGARFOTO_"+sGXsfl_20_fel_idx;
         edtLugarCiudadId_Internalname = sPrefix+"LUGARCIUDADID_"+sGXsfl_20_fel_idx;
         edtLugarCiudadNombre_Internalname = sPrefix+"LUGARCIUDADNOMBRE_"+sGXsfl_20_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_20_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_20_fel_idx;
      }

      protected void sendrow_202( )
      {
         SubsflControlProps_202( ) ;
         WB150( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_20_idx <= subGrid_fnc_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)((nGXsfl_20_idx) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"ViewGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_20_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoNombre_Internalname,StringUtil.RTrim( A35EspectaculoNombre),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtEspectaculoNombre_Link,(String)"",(String)"",(String)"",(String)edtEspectaculoNombre_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoFecha_Internalname,context.localUtil.Format(A36EspectaculoFecha, "99/99/99"),context.localUtil.Format( A36EspectaculoFecha, "99/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoFecha_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoEspectaculoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TipoEspectaculoId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A6TipoEspectaculoId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTipoEspectaculoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoEspectaculoNombre_Internalname,StringUtil.RTrim( A7TipoEspectaculoNombre),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtTipoEspectaculoNombre_Link,(String)"",(String)"",(String)"",(String)edtTipoEspectaculoNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoPaisId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoPaisId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoPaisNombre_Internalname,StringUtil.RTrim( A20EspectaculoPaisNombre),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoPaisNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A21EspectaculoPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000EspectaculoPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoPaisBandera_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A21EspectaculoPaisBandera_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoCiudadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoCiudadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoCiudadNombre_Internalname,StringUtil.RTrim( A23EspectaculoCiudadNombre),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoCiudadNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLugarId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLugarId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLugarNombre_Internalname,StringUtil.RTrim( A9LugarNombre),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtLugarNombre_Link,(String)"",(String)"",(String)"",(String)edtLugarNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A10LugarFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40003LugarFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40003LugarFoto_GXI : context.PathToRelativeUrl( A10LugarFoto));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtLugarFoto_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A10LugarFoto_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLugarCiudadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32LugarCiudadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A32LugarCiudadId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLugarCiudadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLugarCiudadNombre_Internalname,StringUtil.RTrim( A33LugarCiudadNombre),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLugarCiudadNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "TextActionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV11Update),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"TextActionAttribute",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "TextActionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV12Delete),(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"TextActionAttribute",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)20,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            send_integrity_lvl_hashes152( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_20_idx = ((subGrid_Islastpage==1)&&(nGXsfl_20_idx+1>subGrid_fnc_Recordsperpage( )) ? 1 : nGXsfl_20_idx+1);
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_20_idx), 4, 0), 4, "0");
            SubsflControlProps_202( ) ;
         }
         /* End function sendrow_202 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         divTabletop_Internalname = sPrefix+"TABLETOP";
         edtEspectaculoId_Internalname = sPrefix+"ESPECTACULOID";
         edtEspectaculoNombre_Internalname = sPrefix+"ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = sPrefix+"ESPECTACULOFECHA";
         edtTipoEspectaculoId_Internalname = sPrefix+"TIPOESPECTACULOID";
         edtTipoEspectaculoNombre_Internalname = sPrefix+"TIPOESPECTACULONOMBRE";
         edtEspectaculoPaisId_Internalname = sPrefix+"ESPECTACULOPAISID";
         edtEspectaculoPaisNombre_Internalname = sPrefix+"ESPECTACULOPAISNOMBRE";
         edtEspectaculoPaisBandera_Internalname = sPrefix+"ESPECTACULOPAISBANDERA";
         edtEspectaculoCiudadId_Internalname = sPrefix+"ESPECTACULOCIUDADID";
         edtEspectaculoCiudadNombre_Internalname = sPrefix+"ESPECTACULOCIUDADNOMBRE";
         edtLugarId_Internalname = sPrefix+"LUGARID";
         edtLugarNombre_Internalname = sPrefix+"LUGARNOMBRE";
         edtLugarFoto_Internalname = sPrefix+"LUGARFOTO";
         edtLugarCiudadId_Internalname = sPrefix+"LUGARCIUDADID";
         edtLugarCiudadNombre_Internalname = sPrefix+"LUGARCIUDADNOMBRE";
         edtavUpdate_Internalname = sPrefix+"vUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         divGridtable_Internalname = sPrefix+"GRIDTABLE";
         divGridcell_Internalname = sPrefix+"GRIDCELL";
         edtLugarPaisId_Internalname = sPrefix+"LUGARPAISID";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
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
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtLugarCiudadNombre_Jsonclick = "";
         edtLugarCiudadId_Jsonclick = "";
         edtLugarNombre_Jsonclick = "";
         edtLugarId_Jsonclick = "";
         edtEspectaculoCiudadNombre_Jsonclick = "";
         edtEspectaculoCiudadId_Jsonclick = "";
         edtEspectaculoPaisNombre_Jsonclick = "";
         edtEspectaculoPaisId_Jsonclick = "";
         edtTipoEspectaculoNombre_Jsonclick = "";
         edtTipoEspectaculoId_Jsonclick = "";
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoId_Jsonclick = "";
         edtLugarPaisId_Jsonclick = "";
         edtLugarPaisId_Enabled = 0;
         edtLugarPaisId_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         edtLugarNombre_Link = "";
         edtTipoEspectaculoNombre_Link = "";
         edtEspectaculoNombre_Link = "";
         subGrid_Header = "";
         edtavDelete_Enabled = 0;
         edtavUpdate_Enabled = 0;
         subGrid_Class = "ViewGrid";
         subGrid_Backcolorstyle = 0;
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6LugarPaisId',fld:'vLUGARPAISID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E13152',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9',hsh:true},{av:'A6TipoEspectaculoId',fld:'TIPOESPECTACULOID',pic:'ZZZ9'},{av:'A8LugarId',fld:'LUGARID',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtEspectaculoNombre_Link',ctrl:'ESPECTACULONOMBRE',prop:'Link'},{av:'edtTipoEspectaculoNombre_Link',ctrl:'TIPOESPECTACULONOMBRE',prop:'Link'},{av:'edtLugarNombre_Link',ctrl:'LUGARNOMBRE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E11152',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6LugarPaisId',fld:'vLUGARPAISID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6LugarPaisId',fld:'vLUGARPAISID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6LugarPaisId',fld:'vLUGARPAISID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV6LugarPaisId',fld:'vLUGARPAISID',pic:'ZZZ9'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'sPrefix'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[]}");
         setEventMetadata("VALID_LUGARPAISID","{handler:'Valid_Lugarpaisid',iparms:[]");
         setEventMetadata("VALID_LUGARPAISID",",oparms:[]}");
         setEventMetadata("VALID_TIPOESPECTACULOID","{handler:'Valid_Tipoespectaculoid',iparms:[]");
         setEventMetadata("VALID_TIPOESPECTACULOID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOPAISID","{handler:'Valid_Espectaculopaisid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOPAISID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOCIUDADID","{handler:'Valid_Espectaculociudadid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOCIUDADID",",oparms:[]}");
         setEventMetadata("VALID_LUGARID","{handler:'Valid_Lugarid',iparms:[]");
         setEventMetadata("VALID_LUGARID",",oparms:[]}");
         setEventMetadata("VALID_LUGARCIUDADID","{handler:'Valid_Lugarciudadid',iparms:[]");
         setEventMetadata("VALID_LUGARCIUDADID",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Validv_Delete',iparms:[]");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV11Update = "";
         AV12Delete = "";
         GXKey = "";
         AV16Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A7TipoEspectaculoNombre = "";
         A20EspectaculoPaisNombre = "";
         A21EspectaculoPaisBandera = "";
         A23EspectaculoCiudadNombre = "";
         A9LugarNombre = "";
         A10LugarFoto = "";
         A33LugarCiudadNombre = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         A40000EspectaculoPaisBandera_GXI = "";
         A40003LugarFoto_GXI = "";
         scmdbuf = "";
         H00152_A29LugarPaisId = new short[1] ;
         H00152_A33LugarCiudadNombre = new String[] {""} ;
         H00152_A32LugarCiudadId = new short[1] ;
         H00152_A40003LugarFoto_GXI = new String[] {""} ;
         H00152_A9LugarNombre = new String[] {""} ;
         H00152_A8LugarId = new short[1] ;
         H00152_A23EspectaculoCiudadNombre = new String[] {""} ;
         H00152_A22EspectaculoCiudadId = new short[1] ;
         H00152_A40000EspectaculoPaisBandera_GXI = new String[] {""} ;
         H00152_n40000EspectaculoPaisBandera_GXI = new bool[] {false} ;
         H00152_A20EspectaculoPaisNombre = new String[] {""} ;
         H00152_A19EspectaculoPaisId = new short[1] ;
         H00152_A7TipoEspectaculoNombre = new String[] {""} ;
         H00152_A6TipoEspectaculoId = new short[1] ;
         H00152_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         H00152_A35EspectaculoNombre = new String[] {""} ;
         H00152_A34EspectaculoId = new short[1] ;
         H00152_A10LugarFoto = new String[] {""} ;
         H00152_A21EspectaculoPaisBandera = new String[] {""} ;
         H00153_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV9TrnContext = new SdtTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV7Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV6LugarPaisId = "";
         ROClassString = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.paisespectaculo1wc__default(),
            new Object[][] {
                new Object[] {
               H00152_A29LugarPaisId, H00152_A33LugarCiudadNombre, H00152_A32LugarCiudadId, H00152_A40003LugarFoto_GXI, H00152_A9LugarNombre, H00152_A8LugarId, H00152_A23EspectaculoCiudadNombre, H00152_A22EspectaculoCiudadId, H00152_A40000EspectaculoPaisBandera_GXI, H00152_n40000EspectaculoPaisBandera_GXI,
               H00152_A20EspectaculoPaisNombre, H00152_A19EspectaculoPaisId, H00152_A7TipoEspectaculoNombre, H00152_A6TipoEspectaculoId, H00152_A36EspectaculoFecha, H00152_A35EspectaculoNombre, H00152_A34EspectaculoId, H00152_A10LugarFoto, H00152_A21EspectaculoPaisBandera
               }
               , new Object[] {
               H00153_AGRID_nRecordCount
               }
            }
         );
         AV16Pgmname = "PaisEspectaculo1WC";
         /* GeneXus formulas. */
         AV16Pgmname = "PaisEspectaculo1WC";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short AV6LugarPaisId ;
      private short wcpOAV6LugarPaisId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short GRID_nEOF ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A34EspectaculoId ;
      private short A6TipoEspectaculoId ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short A8LugarId ;
      private short A32LugarCiudadId ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A29LugarPaisId ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backstyle ;
      private int nRC_GXsfl_20 ;
      private int nGXsfl_20_idx=1 ;
      private int subGrid_Rows ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtLugarPaisId_Enabled ;
      private int edtLugarPaisId_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_20_idx="0001" ;
      private String AV11Update ;
      private String AV12Delete ;
      private String GXKey ;
      private String AV16Pgmname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Link ;
      private String A7TipoEspectaculoNombre ;
      private String edtTipoEspectaculoNombre_Link ;
      private String A20EspectaculoPaisNombre ;
      private String A23EspectaculoCiudadNombre ;
      private String A9LugarNombre ;
      private String edtLugarNombre_Link ;
      private String A33LugarCiudadNombre ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String edtLugarPaisId_Internalname ;
      private String edtLugarPaisId_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoNombre_Internalname ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtTipoEspectaculoId_Internalname ;
      private String edtTipoEspectaculoNombre_Internalname ;
      private String edtEspectaculoPaisId_Internalname ;
      private String edtEspectaculoPaisNombre_Internalname ;
      private String edtEspectaculoPaisBandera_Internalname ;
      private String edtEspectaculoCiudadId_Internalname ;
      private String edtEspectaculoCiudadNombre_Internalname ;
      private String edtLugarId_Internalname ;
      private String edtLugarNombre_Internalname ;
      private String edtLugarFoto_Internalname ;
      private String edtLugarCiudadId_Internalname ;
      private String edtLugarCiudadNombre_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV6LugarPaisId ;
      private String sGXsfl_20_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtTipoEspectaculoId_Jsonclick ;
      private String edtTipoEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoPaisId_Jsonclick ;
      private String edtEspectaculoPaisNombre_Jsonclick ;
      private String sImgUrl ;
      private String edtEspectaculoCiudadId_Jsonclick ;
      private String edtEspectaculoCiudadNombre_Jsonclick ;
      private String edtLugarId_Jsonclick ;
      private String edtLugarNombre_Jsonclick ;
      private String edtLugarCiudadId_Jsonclick ;
      private String edtLugarCiudadNombre_Jsonclick ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool bGXsfl_20_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n40000EspectaculoPaisBandera_GXI ;
      private bool returnInSub ;
      private bool A21EspectaculoPaisBandera_IsBlob ;
      private bool A10LugarFoto_IsBlob ;
      private String A40000EspectaculoPaisBandera_GXI ;
      private String A40003LugarFoto_GXI ;
      private String A21EspectaculoPaisBandera ;
      private String A10LugarFoto ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00152_A29LugarPaisId ;
      private String[] H00152_A33LugarCiudadNombre ;
      private short[] H00152_A32LugarCiudadId ;
      private String[] H00152_A40003LugarFoto_GXI ;
      private String[] H00152_A9LugarNombre ;
      private short[] H00152_A8LugarId ;
      private String[] H00152_A23EspectaculoCiudadNombre ;
      private short[] H00152_A22EspectaculoCiudadId ;
      private String[] H00152_A40000EspectaculoPaisBandera_GXI ;
      private bool[] H00152_n40000EspectaculoPaisBandera_GXI ;
      private String[] H00152_A20EspectaculoPaisNombre ;
      private short[] H00152_A19EspectaculoPaisId ;
      private String[] H00152_A7TipoEspectaculoNombre ;
      private short[] H00152_A6TipoEspectaculoId ;
      private DateTime[] H00152_A36EspectaculoFecha ;
      private String[] H00152_A35EspectaculoNombre ;
      private short[] H00152_A34EspectaculoId ;
      private String[] H00152_A10LugarFoto ;
      private String[] H00152_A21EspectaculoPaisBandera ;
      private long[] H00153_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private IGxSession AV7Session ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class paisespectaculo1wc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00152 ;
          prmH00152 = new Object[] {
          new Object[] {"@AV6LugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00153 ;
          prmH00153 = new Object[] {
          new Object[] {"@AV6LugarPaisId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00152", "SELECT T1.[LugarPaisId] AS LugarPaisId, T2.[CiudadNombre] AS LugarCiudadNombre, T1.[LugarCiudadId] AS LugarCiudadId, T3.[LugarFoto_GXI], T3.[LugarNombre], T1.[LugarId], T5.[CiudadNombre] AS EspectaculoCiudadNombre, T1.[EspectaculoCiudadId] AS EspectaculoCiudadId, T4.[PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, T4.[PaisNombre] AS EspectaculoPaisNombre, T1.[EspectaculoPaisId] AS EspectaculoPaisId, T6.[TipoEspectaculoNombre], T1.[TipoEspectaculoId], T1.[EspectaculoFecha], T1.[EspectaculoNombre], T1.[EspectaculoId], T3.[LugarFoto], T4.[PaisBandera] AS EspectaculoPaisBandera FROM ((((([Espectaculo] T1 INNER JOIN [PaisCiudad] T2 ON T2.[PaisId] = T1.[LugarPaisId] AND T2.[CiudadId] = T1.[LugarCiudadId]) INNER JOIN [Lugar] T3 ON T3.[LugarId] = T1.[LugarId]) INNER JOIN [Pais] T4 ON T4.[PaisId] = T1.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T5 ON T5.[PaisId] = T1.[EspectaculoPaisId] AND T5.[CiudadId] = T1.[EspectaculoCiudadId]) INNER JOIN [TipoEspectaculo] T6 ON T6.[TipoEspectaculoId] = T1.[TipoEspectaculoId]) WHERE T1.[LugarPaisId] = @AV6LugarPaisId ORDER BY T1.[LugarPaisId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00152,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H00153", "SELECT COUNT(*) FROM ((((([Espectaculo] T1 INNER JOIN [PaisCiudad] T6 ON T6.[PaisId] = T1.[LugarPaisId] AND T6.[CiudadId] = T1.[LugarCiudadId]) INNER JOIN [Lugar] T2 ON T2.[LugarId] = T1.[LugarId]) INNER JOIN [Pais] T4 ON T4.[PaisId] = T1.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T5 ON T5.[PaisId] = T1.[EspectaculoPaisId] AND T5.[CiudadId] = T1.[EspectaculoCiudadId]) INNER JOIN [TipoEspectaculo] T3 ON T3.[TipoEspectaculoId] = T1.[TipoEspectaculoId]) WHERE T1.[LugarPaisId] = @AV6LugarPaisId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00153,1, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 100) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaUri(9) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                ((String[]) buf[10])[0] = rslt.getString(10, 100) ;
                ((short[]) buf[11])[0] = rslt.getShort(11) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 100) ;
                ((short[]) buf[13])[0] = rslt.getShort(13) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDate(14) ;
                ((String[]) buf[15])[0] = rslt.getString(15, 100) ;
                ((short[]) buf[16])[0] = rslt.getShort(16) ;
                ((String[]) buf[17])[0] = rslt.getMultimediaFile(17, rslt.getVarchar(4)) ;
                ((String[]) buf[18])[0] = rslt.getMultimediaFile(18, rslt.getVarchar(9)) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
