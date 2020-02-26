/*
               File: Gx0080
        Description: Selection List Venta
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:27.56
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
   public class gx0080 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0080( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0080( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pVentaId )
      {
         this.AV12pVentaId = 0 ;
         executePrivate();
         aP0_pVentaId=this.AV12pVentaId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_74 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cVentaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cVentaFecha = context.localUtil.ParseDateParm( GetNextPar( ));
               AV8cEspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cVentaCantidadEntradas = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10cLocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11cSectorId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV12pVentaId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV12pVentaId", StringUtil.LTrimStr( (decimal)(AV12pVentaId), 4, 0));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA2J2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2J2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202022521452763", false, true);
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
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0080.aspx") + "?" + UrlEncode("" +AV12pVentaId)+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCVENTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cVentaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVENTAFECHA", context.localUtil.Format(AV7cVentaFecha, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVENTACANTIDADENTRADAS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cVentaCantidadEntradas), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLOCALIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cLocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSECTORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cSectorId), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPVENTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pVentaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "VENTAIDFILTERCONTAINER_Class", StringUtil.RTrim( divVentaidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VENTAFECHAFILTERCONTAINER_Class", StringUtil.RTrim( divVentafechafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESPECTACULOIDFILTERCONTAINER_Class", StringUtil.RTrim( divEspectaculoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VENTACANTIDADENTRADASFILTERCONTAINER_Class", StringUtil.RTrim( divVentacantidadentradasfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LOCALIDADIDFILTERCONTAINER_Class", StringUtil.RTrim( divLocalidadidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SECTORIDFILTERCONTAINER_Class", StringUtil.RTrim( divSectoridfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE2J2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2J2( ) ;
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
         return formatLink("gx0080.aspx") + "?" + UrlEncode("" +AV12pVentaId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0080" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Venta" ;
      }

      protected void WB2J0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVentaidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divVentaidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblventaidfilter_Internalname, "Venta Id", "", "", lblLblventaidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e112j1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCventaid_Internalname, "Venta Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCventaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cVentaId), 4, 0, ".", "")), ((edtavCventaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cVentaId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cVentaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCventaid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCventaid_Visible, edtavCventaid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divVentafechafiltercontainer_Internalname, 1, 0, "px", 0, "px", divVentafechafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblventafechafilter_Internalname, "Venta Fecha", "", "", lblLblventafechafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e122j1_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCventafecha_Internalname, "Venta Fecha", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCventafecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCventafecha_Internalname, context.localUtil.Format(AV7cVentaFecha, "99/99/9999"), context.localUtil.Format( AV7cVentaFecha, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCventafecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCventafecha_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0080.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divEspectaculoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEspectaculoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblespectaculoidfilter_Internalname, "Espectaculo Id", "", "", lblLblespectaculoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e132j1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCespectaculoid_Internalname, "Espectaculo Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCespectaculoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cEspectaculoId), 4, 0, ".", "")), ((edtavCespectaculoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cEspectaculoId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cEspectaculoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCespectaculoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCespectaculoid_Visible, edtavCespectaculoid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divVentacantidadentradasfiltercontainer_Internalname, 1, 0, "px", 0, "px", divVentacantidadentradasfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblventacantidadentradasfilter_Internalname, "Venta Cantidad Entradas", "", "", lblLblventacantidadentradasfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e142j1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCventacantidadentradas_Internalname, "Venta Cantidad Entradas", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCventacantidadentradas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cVentaCantidadEntradas), 4, 0, ".", "")), ((edtavCventacantidadentradas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cVentaCantidadEntradas), "ZZZ9")) : context.localUtil.Format( (decimal)(AV9cVentaCantidadEntradas), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCventacantidadentradas_Jsonclick, 0, "Attribute", "", "", "", "", edtavCventacantidadentradas_Visible, edtavCventacantidadentradas_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divLocalidadidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divLocalidadidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllocalidadidfilter_Internalname, "Localidad Id", "", "", lblLbllocalidadidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e152j1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClocalidadid_Internalname, "Localidad Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClocalidadid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cLocalidadId), 4, 0, ".", "")), ((edtavClocalidadid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cLocalidadId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10cLocalidadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClocalidadid_Jsonclick, 0, "Attribute", "", "", "", "", edtavClocalidadid_Visible, edtavClocalidadid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divSectoridfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSectoridfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsectoridfilter_Internalname, "Sector Id", "", "", lblLblsectoridfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e162j1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCsectorid_Internalname, "Sector Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCsectorid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cSectorId), 4, 0, ".", "")), ((edtavCsectorid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cSectorId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV11cSectorId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCsectorid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCsectorid_Visible, edtavCsectorid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e172j1_client"+"'", TempTags, "", 2, "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Cantidad Entradas") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Localidad Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Sector Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A38VentaFecha, "99/99/9999"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtVentaFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A43VentaCantidadEntradas), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (int)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0080.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START2J2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Selection List Venta", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2J0( ) ;
      }

      protected void WS2J2( )
      {
         START2J2( ) ;
         EVT2J2( ) ;
      }

      protected void EVT2J2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A37VentaId = (short)(context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ","));
                              A38VentaFecha = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtVentaFecha_Internalname), 0));
                              A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                              A43VentaCantidadEntradas = (short)(context.localUtil.CToN( cgiGet( edtVentaCantidadEntradas_Internalname), ".", ","));
                              A11LocalidadId = (short)(context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ","));
                              A17SectorId = (short)(context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ","));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E182J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E192J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cventaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCVENTAID"), ".", ",") != Convert.ToDecimal( AV6cVentaId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cventafecha Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCVENTAFECHA"), 0) != AV7cVentaFecha )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cespectaculoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOID"), ".", ",") != Convert.ToDecimal( AV8cEspectaculoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cventacantidadentradas Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCVENTACANTIDADENTRADAS"), ".", ",") != Convert.ToDecimal( AV9cVentaCantidadEntradas )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clocalidadid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADID"), ".", ",") != Convert.ToDecimal( AV10cLocalidadId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Csectorid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSECTORID"), ".", ",") != Convert.ToDecimal( AV11cSectorId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E202J2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
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

      protected void WE2J2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA2J2( )
      {
         if ( nDonePA == 0 )
         {
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cVentaId ,
                                        DateTime AV7cVentaFecha ,
                                        short AV8cEspectaculoId ,
                                        short AV9cVentaCantidadEntradas ,
                                        short AV10cLocalidadId ,
                                        short AV11cSectorId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF2J2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_VENTAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "VENTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")));
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
         RF2J2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF2J2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cVentaFecha ,
                                                 AV8cEspectaculoId ,
                                                 AV9cVentaCantidadEntradas ,
                                                 AV10cLocalidadId ,
                                                 AV11cSectorId ,
                                                 A38VentaFecha ,
                                                 A34EspectaculoId ,
                                                 A43VentaCantidadEntradas ,
                                                 A11LocalidadId ,
                                                 A17SectorId ,
                                                 AV6cVentaId } ,
                                                 new int[]{
                                                 TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H002J2 */
            pr_default.execute(0, new Object[] {AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A17SectorId = H002J2_A17SectorId[0];
               A11LocalidadId = H002J2_A11LocalidadId[0];
               A43VentaCantidadEntradas = H002J2_A43VentaCantidadEntradas[0];
               A34EspectaculoId = H002J2_A34EspectaculoId[0];
               A38VentaFecha = H002J2_A38VentaFecha[0];
               A37VentaId = H002J2_A37VentaId[0];
               /* Execute user event: Load */
               E192J2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB2J0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2J2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_VENTAID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9"), context));
      }

      protected int subGrid1_fnc_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_fnc_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cVentaFecha ,
                                              AV8cEspectaculoId ,
                                              AV9cVentaCantidadEntradas ,
                                              AV10cLocalidadId ,
                                              AV11cSectorId ,
                                              A38VentaFecha ,
                                              A34EspectaculoId ,
                                              A43VentaCantidadEntradas ,
                                              A11LocalidadId ,
                                              A17SectorId ,
                                              AV6cVentaId } ,
                                              new int[]{
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H002J3 */
         pr_default.execute(1, new Object[] {AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId});
         GRID1_nRecordCount = H002J3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_fnc_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_fnc_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_fnc_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_fnc_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVentaId, AV7cVentaFecha, AV8cEspectaculoId, AV9cVentaCantidadEntradas, AV10cLocalidadId, AV11cSectorId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP2J0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E182J2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_74 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ".", ","));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCventaid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCventaid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVENTAID");
               GX_FocusControl = edtavCventaid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cVentaId = 0;
               AssignAttri("", false, "AV6cVentaId", StringUtil.LTrimStr( (decimal)(AV6cVentaId), 4, 0));
            }
            else
            {
               AV6cVentaId = (short)(context.localUtil.CToN( cgiGet( edtavCventaid_Internalname), ".", ","));
               AssignAttri("", false, "AV6cVentaId", StringUtil.LTrimStr( (decimal)(AV6cVentaId), 4, 0));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCventafecha_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Venta Fecha"}), 1, "vCVENTAFECHA");
               GX_FocusControl = edtavCventafecha_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cVentaFecha = DateTime.MinValue;
               AssignAttri("", false, "AV7cVentaFecha", context.localUtil.Format(AV7cVentaFecha, "99/99/9999"));
            }
            else
            {
               AV7cVentaFecha = context.localUtil.CToD( cgiGet( edtavCventafecha_Internalname), 1);
               AssignAttri("", false, "AV7cVentaFecha", context.localUtil.Format(AV7cVentaFecha, "99/99/9999"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCespectaculoid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCespectaculoid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCESPECTACULOID");
               GX_FocusControl = edtavCespectaculoid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cEspectaculoId = 0;
               AssignAttri("", false, "AV8cEspectaculoId", StringUtil.LTrimStr( (decimal)(AV8cEspectaculoId), 4, 0));
            }
            else
            {
               AV8cEspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtavCespectaculoid_Internalname), ".", ","));
               AssignAttri("", false, "AV8cEspectaculoId", StringUtil.LTrimStr( (decimal)(AV8cEspectaculoId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCventacantidadentradas_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCventacantidadentradas_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVENTACANTIDADENTRADAS");
               GX_FocusControl = edtavCventacantidadentradas_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cVentaCantidadEntradas = 0;
               AssignAttri("", false, "AV9cVentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(AV9cVentaCantidadEntradas), 4, 0));
            }
            else
            {
               AV9cVentaCantidadEntradas = (short)(context.localUtil.CToN( cgiGet( edtavCventacantidadentradas_Internalname), ".", ","));
               AssignAttri("", false, "AV9cVentaCantidadEntradas", StringUtil.LTrimStr( (decimal)(AV9cVentaCantidadEntradas), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClocalidadid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClocalidadid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLOCALIDADID");
               GX_FocusControl = edtavClocalidadid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cLocalidadId = 0;
               AssignAttri("", false, "AV10cLocalidadId", StringUtil.LTrimStr( (decimal)(AV10cLocalidadId), 4, 0));
            }
            else
            {
               AV10cLocalidadId = (short)(context.localUtil.CToN( cgiGet( edtavClocalidadid_Internalname), ".", ","));
               AssignAttri("", false, "AV10cLocalidadId", StringUtil.LTrimStr( (decimal)(AV10cLocalidadId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsectorid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsectorid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSECTORID");
               GX_FocusControl = edtavCsectorid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cSectorId = 0;
               AssignAttri("", false, "AV11cSectorId", StringUtil.LTrimStr( (decimal)(AV11cSectorId), 4, 0));
            }
            else
            {
               AV11cSectorId = (short)(context.localUtil.CToN( cgiGet( edtavCsectorid_Internalname), ".", ","));
               AssignAttri("", false, "AV11cSectorId", StringUtil.LTrimStr( (decimal)(AV11cSectorId), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCVENTAID"), ".", ",") != Convert.ToDecimal( AV6cVentaId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vCVENTAFECHA"), 1) != AV7cVentaFecha )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOID"), ".", ",") != Convert.ToDecimal( AV8cEspectaculoId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCVENTACANTIDADENTRADAS"), ".", ",") != Convert.ToDecimal( AV9cVentaCantidadEntradas )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADID"), ".", ",") != Convert.ToDecimal( AV10cLocalidadId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSECTORID"), ".", ",") != Convert.ToDecimal( AV11cSectorId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
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
         E182J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E182J2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Venta", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E192J2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV16Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E202J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E202J2( )
      {
         /* Enter Routine */
         AV12pVentaId = A37VentaId;
         AssignAttri("", false, "AV12pVentaId", StringUtil.LTrimStr( (decimal)(AV12pVentaId), 4, 0));
         context.setWebReturnParms(new Object[] {(short)AV12pVentaId});
         context.setWebReturnParmsMetadata(new Object[] {"AV12pVentaId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pVentaId = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV12pVentaId", StringUtil.LTrimStr( (decimal)(AV12pVentaId), 4, 0));
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
         PA2J2( ) ;
         WS2J2( ) ;
         WE2J2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022521452843", true, true);
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
         context.AddJavascriptSource("gx0080.js", "?202022521452844", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtVentaId_Internalname = "VENTAID_"+sGXsfl_74_idx;
         edtVentaFecha_Internalname = "VENTAFECHA_"+sGXsfl_74_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_74_idx;
         edtVentaCantidadEntradas_Internalname = "VENTACANTIDADENTRADAS_"+sGXsfl_74_idx;
         edtLocalidadId_Internalname = "LOCALIDADID_"+sGXsfl_74_idx;
         edtSectorId_Internalname = "SECTORID_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtVentaId_Internalname = "VENTAID_"+sGXsfl_74_fel_idx;
         edtVentaFecha_Internalname = "VENTAFECHA_"+sGXsfl_74_fel_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_74_fel_idx;
         edtVentaCantidadEntradas_Internalname = "VENTACANTIDADENTRADAS_"+sGXsfl_74_fel_idx;
         edtLocalidadId_Internalname = "LOCALIDADID_"+sGXsfl_74_fel_idx;
         edtSectorId_Internalname = "SECTORID_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB2J0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtVentaFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtVentaFecha_Internalname, "Link", edtVentaFecha_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaFecha_Internalname,context.localUtil.Format(A38VentaFecha, "99/99/9999"),context.localUtil.Format( A38VentaFecha, "99/99/9999"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtVentaFecha_Link,(String)"",(String)"",(String)"",(String)edtVentaFecha_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaCantidadEntradas_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A43VentaCantidadEntradas), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A43VentaCantidadEntradas), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaCantidadEntradas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSectorId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A17SectorId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSectorId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            send_integrity_lvl_hashes2J2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1);
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_74_idx), 4, 0), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblventaidfilter_Internalname = "LBLVENTAIDFILTER";
         edtavCventaid_Internalname = "vCVENTAID";
         divVentaidfiltercontainer_Internalname = "VENTAIDFILTERCONTAINER";
         lblLblventafechafilter_Internalname = "LBLVENTAFECHAFILTER";
         edtavCventafecha_Internalname = "vCVENTAFECHA";
         divVentafechafiltercontainer_Internalname = "VENTAFECHAFILTERCONTAINER";
         lblLblespectaculoidfilter_Internalname = "LBLESPECTACULOIDFILTER";
         edtavCespectaculoid_Internalname = "vCESPECTACULOID";
         divEspectaculoidfiltercontainer_Internalname = "ESPECTACULOIDFILTERCONTAINER";
         lblLblventacantidadentradasfilter_Internalname = "LBLVENTACANTIDADENTRADASFILTER";
         edtavCventacantidadentradas_Internalname = "vCVENTACANTIDADENTRADAS";
         divVentacantidadentradasfiltercontainer_Internalname = "VENTACANTIDADENTRADASFILTERCONTAINER";
         lblLbllocalidadidfilter_Internalname = "LBLLOCALIDADIDFILTER";
         edtavClocalidadid_Internalname = "vCLOCALIDADID";
         divLocalidadidfiltercontainer_Internalname = "LOCALIDADIDFILTERCONTAINER";
         lblLblsectoridfilter_Internalname = "LBLSECTORIDFILTER";
         edtavCsectorid_Internalname = "vCSECTORID";
         divSectoridfiltercontainer_Internalname = "SECTORIDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtVentaId_Internalname = "VENTAID";
         edtVentaFecha_Internalname = "VENTAFECHA";
         edtEspectaculoId_Internalname = "ESPECTACULOID";
         edtVentaCantidadEntradas_Internalname = "VENTACANTIDADENTRADAS";
         edtLocalidadId_Internalname = "LOCALIDADID";
         edtSectorId_Internalname = "SECTORID";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtSectorId_Jsonclick = "";
         edtLocalidadId_Jsonclick = "";
         edtVentaCantidadEntradas_Jsonclick = "";
         edtEspectaculoId_Jsonclick = "";
         edtVentaFecha_Jsonclick = "";
         edtVentaId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtVentaFecha_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCsectorid_Jsonclick = "";
         edtavCsectorid_Enabled = 1;
         edtavCsectorid_Visible = 1;
         edtavClocalidadid_Jsonclick = "";
         edtavClocalidadid_Enabled = 1;
         edtavClocalidadid_Visible = 1;
         edtavCventacantidadentradas_Jsonclick = "";
         edtavCventacantidadentradas_Enabled = 1;
         edtavCventacantidadentradas_Visible = 1;
         edtavCespectaculoid_Jsonclick = "";
         edtavCespectaculoid_Enabled = 1;
         edtavCespectaculoid_Visible = 1;
         edtavCventafecha_Jsonclick = "";
         edtavCventafecha_Enabled = 1;
         edtavCventaid_Jsonclick = "";
         edtavCventaid_Enabled = 1;
         edtavCventaid_Visible = 1;
         divSectoridfiltercontainer_Class = "AdvancedContainerItem";
         divLocalidadidfiltercontainer_Class = "AdvancedContainerItem";
         divVentacantidadentradasfiltercontainer_Class = "AdvancedContainerItem";
         divEspectaculoidfiltercontainer_Class = "AdvancedContainerItem";
         divVentafechafiltercontainer_Class = "AdvancedContainerItem";
         divVentaidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Venta";
         subGrid1_Rows = 10;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cVentaId',fld:'vCVENTAID',pic:'ZZZ9'},{av:'AV7cVentaFecha',fld:'vCVENTAFECHA',pic:''},{av:'AV8cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV9cVentaCantidadEntradas',fld:'vCVENTACANTIDADENTRADAS',pic:'ZZZ9'},{av:'AV10cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV11cSectorId',fld:'vCSECTORID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E172J1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLVENTAIDFILTER.CLICK","{handler:'E112J1',iparms:[{av:'divVentaidfiltercontainer_Class',ctrl:'VENTAIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLVENTAIDFILTER.CLICK",",oparms:[{av:'divVentaidfiltercontainer_Class',ctrl:'VENTAIDFILTERCONTAINER',prop:'Class'},{av:'edtavCventaid_Visible',ctrl:'vCVENTAID',prop:'Visible'}]}");
         setEventMetadata("LBLVENTAFECHAFILTER.CLICK","{handler:'E122J1',iparms:[{av:'divVentafechafiltercontainer_Class',ctrl:'VENTAFECHAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLVENTAFECHAFILTER.CLICK",",oparms:[{av:'divVentafechafiltercontainer_Class',ctrl:'VENTAFECHAFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLESPECTACULOIDFILTER.CLICK","{handler:'E132J1',iparms:[{av:'divEspectaculoidfiltercontainer_Class',ctrl:'ESPECTACULOIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLESPECTACULOIDFILTER.CLICK",",oparms:[{av:'divEspectaculoidfiltercontainer_Class',ctrl:'ESPECTACULOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCespectaculoid_Visible',ctrl:'vCESPECTACULOID',prop:'Visible'}]}");
         setEventMetadata("LBLVENTACANTIDADENTRADASFILTER.CLICK","{handler:'E142J1',iparms:[{av:'divVentacantidadentradasfiltercontainer_Class',ctrl:'VENTACANTIDADENTRADASFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLVENTACANTIDADENTRADASFILTER.CLICK",",oparms:[{av:'divVentacantidadentradasfiltercontainer_Class',ctrl:'VENTACANTIDADENTRADASFILTERCONTAINER',prop:'Class'},{av:'edtavCventacantidadentradas_Visible',ctrl:'vCVENTACANTIDADENTRADAS',prop:'Visible'}]}");
         setEventMetadata("LBLLOCALIDADIDFILTER.CLICK","{handler:'E152J1',iparms:[{av:'divLocalidadidfiltercontainer_Class',ctrl:'LOCALIDADIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLOCALIDADIDFILTER.CLICK",",oparms:[{av:'divLocalidadidfiltercontainer_Class',ctrl:'LOCALIDADIDFILTERCONTAINER',prop:'Class'},{av:'edtavClocalidadid_Visible',ctrl:'vCLOCALIDADID',prop:'Visible'}]}");
         setEventMetadata("LBLSECTORIDFILTER.CLICK","{handler:'E162J1',iparms:[{av:'divSectoridfiltercontainer_Class',ctrl:'SECTORIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSECTORIDFILTER.CLICK",",oparms:[{av:'divSectoridfiltercontainer_Class',ctrl:'SECTORIDFILTERCONTAINER',prop:'Class'},{av:'edtavCsectorid_Visible',ctrl:'vCSECTORID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E202J2',iparms:[{av:'A37VentaId',fld:'VENTAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV12pVentaId',fld:'vPVENTAID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cVentaId',fld:'vCVENTAID',pic:'ZZZ9'},{av:'AV7cVentaFecha',fld:'vCVENTAFECHA',pic:''},{av:'AV8cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV9cVentaCantidadEntradas',fld:'vCVENTACANTIDADENTRADAS',pic:'ZZZ9'},{av:'AV10cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV11cSectorId',fld:'vCSECTORID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cVentaId',fld:'vCVENTAID',pic:'ZZZ9'},{av:'AV7cVentaFecha',fld:'vCVENTAFECHA',pic:''},{av:'AV8cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV9cVentaCantidadEntradas',fld:'vCVENTACANTIDADENTRADAS',pic:'ZZZ9'},{av:'AV10cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV11cSectorId',fld:'vCSECTORID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cVentaId',fld:'vCVENTAID',pic:'ZZZ9'},{av:'AV7cVentaFecha',fld:'vCVENTAFECHA',pic:''},{av:'AV8cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV9cVentaCantidadEntradas',fld:'vCVENTACANTIDADENTRADAS',pic:'ZZZ9'},{av:'AV10cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV11cSectorId',fld:'vCSECTORID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cVentaId',fld:'vCVENTAID',pic:'ZZZ9'},{av:'AV7cVentaFecha',fld:'vCVENTAFECHA',pic:''},{av:'AV8cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV9cVentaCantidadEntradas',fld:'vCVENTACANTIDADENTRADAS',pic:'ZZZ9'},{av:'AV10cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV11cSectorId',fld:'vCSECTORID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("VALIDV_CVENTAFECHA","{handler:'Validv_Cventafecha',iparms:[]");
         setEventMetadata("VALIDV_CVENTAFECHA",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Sectorid',iparms:[]");
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
         AV7cVentaFecha = DateTime.MinValue;
         AV8cEspectaculoId = 1;
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblventaidfilter_Jsonclick = "";
         TempTags = "";
         lblLblventafechafilter_Jsonclick = "";
         lblLblespectaculoidfilter_Jsonclick = "";
         lblLblventacantidadentradasfilter_Jsonclick = "";
         lblLbllocalidadidfilter_Jsonclick = "";
         lblLblsectoridfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A38VentaFecha = DateTime.MinValue;
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         scmdbuf = "";
         H002J2_A17SectorId = new short[1] ;
         H002J2_A11LocalidadId = new short[1] ;
         H002J2_A43VentaCantidadEntradas = new short[1] ;
         H002J2_A34EspectaculoId = new short[1] ;
         H002J2_A38VentaFecha = new DateTime[] {DateTime.MinValue} ;
         H002J2_A37VentaId = new short[1] ;
         H002J3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0080__default(),
            new Object[][] {
                new Object[] {
               H002J2_A17SectorId, H002J2_A11LocalidadId, H002J2_A43VentaCantidadEntradas, H002J2_A34EspectaculoId, H002J2_A38VentaFecha, H002J2_A37VentaId
               }
               , new Object[] {
               H002J3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short GRID1_nEOF ;
      private short AV6cVentaId ;
      private short AV8cEspectaculoId ;
      private short AV9cVentaCantidadEntradas ;
      private short AV10cLocalidadId ;
      private short AV11cSectorId ;
      private short AV12pVentaId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A37VentaId ;
      private short A34EspectaculoId ;
      private short A43VentaCantidadEntradas ;
      private short A11LocalidadId ;
      private short A17SectorId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_74 ;
      private int nGXsfl_74_idx=1 ;
      private int subGrid1_Rows ;
      private int edtavCventaid_Enabled ;
      private int edtavCventaid_Visible ;
      private int edtavCventafecha_Enabled ;
      private int edtavCespectaculoid_Enabled ;
      private int edtavCespectaculoid_Visible ;
      private int edtavCventacantidadentradas_Enabled ;
      private int edtavCventacantidadentradas_Visible ;
      private int edtavClocalidadid_Enabled ;
      private int edtavClocalidadid_Visible ;
      private int edtavCsectorid_Enabled ;
      private int edtavCsectorid_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divVentaidfiltercontainer_Class ;
      private String divVentafechafiltercontainer_Class ;
      private String divEspectaculoidfiltercontainer_Class ;
      private String divVentacantidadentradasfiltercontainer_Class ;
      private String divLocalidadidfiltercontainer_Class ;
      private String divSectoridfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divVentaidfiltercontainer_Internalname ;
      private String lblLblventaidfilter_Internalname ;
      private String lblLblventaidfilter_Jsonclick ;
      private String edtavCventaid_Internalname ;
      private String TempTags ;
      private String edtavCventaid_Jsonclick ;
      private String divVentafechafiltercontainer_Internalname ;
      private String lblLblventafechafilter_Internalname ;
      private String lblLblventafechafilter_Jsonclick ;
      private String edtavCventafecha_Internalname ;
      private String edtavCventafecha_Jsonclick ;
      private String divEspectaculoidfiltercontainer_Internalname ;
      private String lblLblespectaculoidfilter_Internalname ;
      private String lblLblespectaculoidfilter_Jsonclick ;
      private String edtavCespectaculoid_Internalname ;
      private String edtavCespectaculoid_Jsonclick ;
      private String divVentacantidadentradasfiltercontainer_Internalname ;
      private String lblLblventacantidadentradasfilter_Internalname ;
      private String lblLblventacantidadentradasfilter_Jsonclick ;
      private String edtavCventacantidadentradas_Internalname ;
      private String edtavCventacantidadentradas_Jsonclick ;
      private String divLocalidadidfiltercontainer_Internalname ;
      private String lblLbllocalidadidfilter_Internalname ;
      private String lblLbllocalidadidfilter_Jsonclick ;
      private String edtavClocalidadid_Internalname ;
      private String edtavClocalidadid_Jsonclick ;
      private String divSectoridfiltercontainer_Internalname ;
      private String lblLblsectoridfilter_Internalname ;
      private String lblLblsectoridfilter_Jsonclick ;
      private String edtavCsectorid_Internalname ;
      private String edtavCsectorid_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String edtVentaFecha_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtVentaId_Internalname ;
      private String edtVentaFecha_Internalname ;
      private String edtEspectaculoId_Internalname ;
      private String edtVentaCantidadEntradas_Internalname ;
      private String edtLocalidadId_Internalname ;
      private String edtSectorId_Internalname ;
      private String scmdbuf ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtVentaId_Jsonclick ;
      private String edtVentaFecha_Jsonclick ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtVentaCantidadEntradas_Jsonclick ;
      private String edtLocalidadId_Jsonclick ;
      private String edtSectorId_Jsonclick ;
      private DateTime AV7cVentaFecha ;
      private DateTime A38VentaFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV16Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H002J2_A17SectorId ;
      private short[] H002J2_A11LocalidadId ;
      private short[] H002J2_A43VentaCantidadEntradas ;
      private short[] H002J2_A34EspectaculoId ;
      private DateTime[] H002J2_A38VentaFecha ;
      private short[] H002J2_A37VentaId ;
      private long[] H002J3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pVentaId ;
      private GXWebForm Form ;
   }

   public class gx0080__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002J2( IGxContext context ,
                                             DateTime AV7cVentaFecha ,
                                             short AV8cEspectaculoId ,
                                             short AV9cVentaCantidadEntradas ,
                                             short AV10cLocalidadId ,
                                             short AV11cSectorId ,
                                             DateTime A38VentaFecha ,
                                             short A34EspectaculoId ,
                                             short A43VentaCantidadEntradas ,
                                             short A11LocalidadId ,
                                             short A17SectorId ,
                                             short AV6cVentaId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [SectorId], [LocalidadId], [VentaCantidadEntradas], [EspectaculoId], [VentaFecha], [VentaId]";
         sFromString = " FROM [Venta]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([VentaId] >= @AV6cVentaId)";
         if ( ! (DateTime.MinValue==AV7cVentaFecha) )
         {
            sWhereString = sWhereString + " and ([VentaFecha] >= @AV7cVentaFecha)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cEspectaculoId) )
         {
            sWhereString = sWhereString + " and ([EspectaculoId] >= @AV8cEspectaculoId)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cVentaCantidadEntradas) )
         {
            sWhereString = sWhereString + " and ([VentaCantidadEntradas] >= @AV9cVentaCantidadEntradas)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cLocalidadId) )
         {
            sWhereString = sWhereString + " and ([LocalidadId] >= @AV10cLocalidadId)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cSectorId) )
         {
            sWhereString = sWhereString + " and ([SectorId] >= @AV11cSectorId)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [VentaId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H002J3( IGxContext context ,
                                             DateTime AV7cVentaFecha ,
                                             short AV8cEspectaculoId ,
                                             short AV9cVentaCantidadEntradas ,
                                             short AV10cLocalidadId ,
                                             short AV11cSectorId ,
                                             DateTime A38VentaFecha ,
                                             short A34EspectaculoId ,
                                             short A43VentaCantidadEntradas ,
                                             short A11LocalidadId ,
                                             short A17SectorId ,
                                             short AV6cVentaId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Venta]";
         scmdbuf = scmdbuf + " WHERE ([VentaId] >= @AV6cVentaId)";
         if ( ! (DateTime.MinValue==AV7cVentaFecha) )
         {
            sWhereString = sWhereString + " and ([VentaFecha] >= @AV7cVentaFecha)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cEspectaculoId) )
         {
            sWhereString = sWhereString + " and ([EspectaculoId] >= @AV8cEspectaculoId)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cVentaCantidadEntradas) )
         {
            sWhereString = sWhereString + " and ([VentaCantidadEntradas] >= @AV9cVentaCantidadEntradas)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cLocalidadId) )
         {
            sWhereString = sWhereString + " and ([LocalidadId] >= @AV10cLocalidadId)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cSectorId) )
         {
            sWhereString = sWhereString + " and ([SectorId] >= @AV11cSectorId)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H002J2(context, (DateTime)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (DateTime)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H002J3(context, (DateTime)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (DateTime)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmH002J2 ;
          prmH002J2 = new Object[] {
          new Object[] {"@AV6cVentaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cVentaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cVentaCantidadEntradas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cLocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cSectorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002J3 ;
          prmH002J3 = new Object[] {
          new Object[] {"@AV6cVentaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cVentaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cVentaCantidadEntradas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cLocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cSectorId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002J2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002J2,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H002J3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002J3,1, GxCacheFrequency.OFF ,false,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                return;
       }
    }

 }

}
