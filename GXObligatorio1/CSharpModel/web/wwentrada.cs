/*
               File: WWEntrada
        Description: Entradas
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:51:4.76
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
   public class wwentrada : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wwentrada( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public wwentrada( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_25 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_25_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_25_idx = GetNextPar( );
               AV14Update = GetNextPar( );
               AV15Delete = GetNextPar( );
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
               AV13EntradaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV19Pgmname = GetNextPar( );
               AV14Update = GetNextPar( );
               AV15Delete = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13EntradaId, AV19Pgmname, AV14Update, AV15Delete) ;
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

      public override short ExecuteStartEvent( )
      {
         PA1C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1C2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202162151480", false, true);
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
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwentrada.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         }
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19Pgmname, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vENTRADAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13EntradaId), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_25", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_25), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV19Pgmname));
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19Pgmname, "")), context));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwentrada.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWEntrada" ;
      }

      public override String GetPgmdesc( )
      {
         return "Entradas" ;
      }

      protected void WB1C0( )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "BodyContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-7 col-sm-2 col-sm-offset-1", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Entradas", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_WWEntrada.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-5 col-sm-3 col-sm-push-6 WWActionsCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnAdd";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(25), 2, 0)+","+"null"+");", "Insert", bttBtninsert_Jsonclick, 5, "Insert", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWEntrada.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-sm-pull-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEntradaid_Internalname, "Entrada Id", "col-sm-3 FilterSearchAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_25_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEntradaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13EntradaId), 4, 0, ".", "")), ((edtavEntradaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13EntradaId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV13EntradaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Id", edtavEntradaid_Jsonclick, 0, "FilterSearchAttribute", "", "", "", "", 1, edtavEntradaid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_WWEntrada.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 ViewGridCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "ContainerFluid WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"25\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Pais Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Pais Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Pais Bandera") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Ciudad Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Venta Ciudad Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Pais Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Pais Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Pais Bandera") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Ciudad Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Ciudad Nombre") ;
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
               GridContainer.AddObjectProperty("Class", "WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39EntradaId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtEntradaId_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( A38VentaFecha));
               GridContainer.AddColumnProperties(GridColumn);
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24VentaPaisId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A25VentaPaisNombre));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( A26VentaPaisBandera));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27VentaCiudadId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A28VentaCiudadNombre));
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
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV14Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV15Delete));
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
         if ( wbEnd == 25 )
         {
            wbEnd = 0;
            nRC_GXsfl_25 = (int)(nGXsfl_25_idx-1);
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 25 )
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
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Entradas", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1C0( ) ;
      }

      protected void WS1C2( )
      {
         START1C2( ) ;
         EVT1C2( ) ;
      }

      protected void EVT1C2( )
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
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E111C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRIDPAGING");
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_25_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_25_idx), 4, 0), 4, "0");
                              SubsflControlProps_252( ) ;
                              A39EntradaId = (short)(context.localUtil.CToN( cgiGet( edtEntradaId_Internalname), ".", ","));
                              A37VentaId = (short)(context.localUtil.CToN( cgiGet( edtVentaId_Internalname), ".", ","));
                              A38VentaFecha = cgiGet( edtVentaFecha_Internalname);
                              AssignProp("", false, edtVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), !bGXsfl_25_Refreshing);
                              AssignProp("", false, edtVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
                              A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                              A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
                              A36EspectaculoFecha = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtEspectaculoFecha_Internalname), 0));
                              A24VentaPaisId = (short)(context.localUtil.CToN( cgiGet( edtVentaPaisId_Internalname), ".", ","));
                              A25VentaPaisNombre = cgiGet( edtVentaPaisNombre_Internalname);
                              A26VentaPaisBandera = cgiGet( edtVentaPaisBandera_Internalname);
                              AssignProp("", false, edtVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), !bGXsfl_25_Refreshing);
                              AssignProp("", false, edtVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
                              A27VentaCiudadId = (short)(context.localUtil.CToN( cgiGet( edtVentaCiudadId_Internalname), ".", ","));
                              A28VentaCiudadNombre = cgiGet( edtVentaCiudadNombre_Internalname);
                              A19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ","));
                              A20EspectaculoPaisNombre = cgiGet( edtEspectaculoPaisNombre_Internalname);
                              A21EspectaculoPaisBandera = cgiGet( edtEspectaculoPaisBandera_Internalname);
                              AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_25_Refreshing);
                              AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
                              A22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ","));
                              A23EspectaculoCiudadNombre = cgiGet( edtEspectaculoCiudadNombre_Internalname);
                              AV14Update = cgiGet( edtavUpdate_Internalname);
                              AssignAttri("", false, edtavUpdate_Internalname, AV14Update);
                              AV15Delete = cgiGet( edtavDelete_Internalname);
                              AssignAttri("", false, edtavDelete_Internalname, AV15Delete);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E121C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E131C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E141C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Entradaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vENTRADAID"), ".", ",") != Convert.ToDecimal( AV13EntradaId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void WE1C2( )
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

      protected void PA1C2( )
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavEntradaid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
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
         SubsflControlProps_252( ) ;
         while ( nGXsfl_25_idx <= nRC_GXsfl_25 )
         {
            sendrow_252( ) ;
            nGXsfl_25_idx = ((subGrid_Islastpage==1)&&(nGXsfl_25_idx+1>subGrid_fnc_Recordsperpage( )) ? 1 : nGXsfl_25_idx+1);
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_25_idx), 4, 0), 4, "0");
            SubsflControlProps_252( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( GridContainer)) ;
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13EntradaId ,
                                       String AV19Pgmname ,
                                       String AV14Update ,
                                       String AV15Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID_nCurrentRecord = 0;
         RF1C2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ENTRADAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A39EntradaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ENTRADAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39EntradaId), 4, 0, ".", "")));
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
         RF1C2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV19Pgmname = "WWEntrada";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         AssignProp("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_25_Refreshing);
         edtavDelete_Enabled = 0;
         AssignProp("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_25_Refreshing);
      }

      protected void RF1C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 25;
         /* Execute user event: Refresh */
         E131C2 ();
         nGXsfl_25_idx = 1;
         sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_25_idx), 4, 0), 4, "0");
         SubsflControlProps_252( ) ;
         bGXsfl_25_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_252( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13EntradaId ,
                                                 A39EntradaId } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H001C2 */
            pr_default.execute(0, new Object[] {AV13EntradaId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_25_idx = 1;
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_25_idx), 4, 0), 4, "0");
            SubsflControlProps_252( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_fnc_Recordsperpage( ) ) ) ) )
            {
               A23EspectaculoCiudadNombre = H001C2_A23EspectaculoCiudadNombre[0];
               A22EspectaculoCiudadId = H001C2_A22EspectaculoCiudadId[0];
               A40004EspectaculoPaisBandera_GXI = H001C2_A40004EspectaculoPaisBandera_GXI[0];
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40004EspectaculoPaisBandera_GXI = H001C2_n40004EspectaculoPaisBandera_GXI[0];
               A20EspectaculoPaisNombre = H001C2_A20EspectaculoPaisNombre[0];
               A19EspectaculoPaisId = H001C2_A19EspectaculoPaisId[0];
               A28VentaCiudadNombre = H001C2_A28VentaCiudadNombre[0];
               A27VentaCiudadId = H001C2_A27VentaCiudadId[0];
               A40001VentaPaisBandera_GXI = H001C2_A40001VentaPaisBandera_GXI[0];
               AssignProp("", false, edtVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               n40001VentaPaisBandera_GXI = H001C2_n40001VentaPaisBandera_GXI[0];
               A25VentaPaisNombre = H001C2_A25VentaPaisNombre[0];
               A24VentaPaisId = H001C2_A24VentaPaisId[0];
               A36EspectaculoFecha = H001C2_A36EspectaculoFecha[0];
               A35EspectaculoNombre = H001C2_A35EspectaculoNombre[0];
               A34EspectaculoId = H001C2_A34EspectaculoId[0];
               A40000VentaFecha_GXI = H001C2_A40000VentaFecha_GXI[0];
               AssignProp("", false, edtVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A37VentaId = H001C2_A37VentaId[0];
               A39EntradaId = H001C2_A39EntradaId[0];
               A21EspectaculoPaisBandera = H001C2_A21EspectaculoPaisBandera[0];
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A26VentaPaisBandera = H001C2_A26VentaPaisBandera[0];
               AssignProp("", false, edtVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               A38VentaFecha = H001C2_A38VentaFecha[0];
               AssignProp("", false, edtVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A27VentaCiudadId = H001C2_A27VentaCiudadId[0];
               A24VentaPaisId = H001C2_A24VentaPaisId[0];
               A34EspectaculoId = H001C2_A34EspectaculoId[0];
               A40000VentaFecha_GXI = H001C2_A40000VentaFecha_GXI[0];
               AssignProp("", false, edtVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A38VentaFecha = H001C2_A38VentaFecha[0];
               AssignProp("", false, edtVentaFecha_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.convertURL( context.PathToRelativeUrl( A38VentaFecha))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaFecha_Internalname, "SrcSet", context.GetImageSrcSet( A38VentaFecha), true);
               A40001VentaPaisBandera_GXI = H001C2_A40001VentaPaisBandera_GXI[0];
               AssignProp("", false, edtVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               n40001VentaPaisBandera_GXI = H001C2_n40001VentaPaisBandera_GXI[0];
               A25VentaPaisNombre = H001C2_A25VentaPaisNombre[0];
               A26VentaPaisBandera = H001C2_A26VentaPaisBandera[0];
               AssignProp("", false, edtVentaPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A26VentaPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtVentaPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A26VentaPaisBandera), true);
               A28VentaCiudadNombre = H001C2_A28VentaCiudadNombre[0];
               A22EspectaculoCiudadId = H001C2_A22EspectaculoCiudadId[0];
               A19EspectaculoPaisId = H001C2_A19EspectaculoPaisId[0];
               A36EspectaculoFecha = H001C2_A36EspectaculoFecha[0];
               A35EspectaculoNombre = H001C2_A35EspectaculoNombre[0];
               A40004EspectaculoPaisBandera_GXI = H001C2_A40004EspectaculoPaisBandera_GXI[0];
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               n40004EspectaculoPaisBandera_GXI = H001C2_n40004EspectaculoPaisBandera_GXI[0];
               A20EspectaculoPaisNombre = H001C2_A20EspectaculoPaisNombre[0];
               A21EspectaculoPaisBandera = H001C2_A21EspectaculoPaisBandera[0];
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), !bGXsfl_25_Refreshing);
               AssignProp("", false, edtEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
               A23EspectaculoCiudadNombre = H001C2_A23EspectaculoCiudadNombre[0];
               E141C2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 25;
            WB1C0( ) ;
         }
         bGXsfl_25_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1C2( )
      {
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV19Pgmname));
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV19Pgmname, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_ENTRADAID"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, context.localUtil.Format( (decimal)(A39EntradaId), "ZZZ9"), context));
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV13EntradaId ,
                                              A39EntradaId } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H001C3 */
         pr_default.execute(1, new Object[] {AV13EntradaId});
         GRID_nRecordCount = H001C3_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13EntradaId, AV19Pgmname, AV14Update, AV15Delete) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13EntradaId, AV19Pgmname, AV14Update, AV15Delete) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13EntradaId, AV19Pgmname, AV14Update, AV15Delete) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13EntradaId, AV19Pgmname, AV14Update, AV15Delete) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13EntradaId, AV19Pgmname, AV14Update, AV15Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP1C0( )
      {
         /* Before Start, stand alone formulas. */
         AV19Pgmname = "WWEntrada";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         AssignProp("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavUpdate_Enabled), 5, 0), !bGXsfl_25_Refreshing);
         edtavDelete_Enabled = 0;
         AssignProp("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtavDelete_Enabled), 5, 0), !bGXsfl_25_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E121C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_25 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_25"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavEntradaid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavEntradaid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vENTRADAID");
               GX_FocusControl = edtavEntradaid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13EntradaId = 0;
               AssignAttri("", false, "AV13EntradaId", StringUtil.LTrimStr( (decimal)(AV13EntradaId), 4, 0));
            }
            else
            {
               AV13EntradaId = (short)(context.localUtil.CToN( cgiGet( edtavEntradaid_Internalname), ".", ","));
               AssignAttri("", false, "AV13EntradaId", StringUtil.LTrimStr( (decimal)(AV13EntradaId), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vENTRADAID"), ".", ",") != Convert.ToDecimal( AV13EntradaId )) )
            {
               GRID_nFirstRecordOnPage = 0;
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
         E121C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E121C2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV19Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV14Update = "Update";
         AssignAttri("", false, edtavUpdate_Internalname, AV14Update);
         AV15Delete = "Delete";
         AssignAttri("", false, edtavDelete_Internalname, AV15Delete);
         Form.Caption = "Entradas";
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131C2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      private void E141C2( )
      {
         /* Grid_Load Routine */
         edtavUpdate_Link = formatLink("entrada.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A39EntradaId);
         edtavDelete_Link = formatLink("entrada.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A39EntradaId);
         edtEntradaId_Link = formatLink("viewentrada.aspx") + "?" + UrlEncode("" +A39EntradaId) + "," + UrlEncode(StringUtil.RTrim(""));
         edtEspectaculoNombre_Link = formatLink("viewespectaculo.aspx") + "?" + UrlEncode("" +A34EspectaculoId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 25;
         }
         sendrow_252( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_25_Refreshing )
         {
            context.DoAjaxLoad(25, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E111C2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("entrada.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            AV8GridState.FromXml(AV6Session.Get(AV19Pgmname+"GridState"), null, "GridState", "GXObligatorio1");
            if ( AV8GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13EntradaId = (short)(NumberUtil.Val( ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value, "."));
               AssignAttri("", false, "AV13EntradaId", StringUtil.LTrimStr( (decimal)(AV13EntradaId), 4, 0));
            }
            if ( AV8GridState.gxTpr_Currentpage > 0 )
            {
               AV10GridPageCount = subGrid_fnc_Pagecount( );
               if ( ( AV10GridPageCount > 0 ) && ( AV10GridPageCount < AV8GridState.gxTpr_Currentpage ) )
               {
                  subgrid_gotopage( AV10GridPageCount) ;
               }
               else
               {
                  subgrid_gotopage( AV8GridState.gxTpr_Currentpage) ;
               }
            }
         }
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV8GridState.FromXml(AV6Session.Get(AV19Pgmname+"GridState"), null, "GridState", "GXObligatorio1");
         AV8GridState.gxTpr_Currentpage = (short)(subGrid_fnc_Currentpage( ));
         AV8GridState.gxTpr_Filtervalues.Clear();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV13EntradaId), 4, 0);
         AV8GridState.gxTpr_Filtervalues.Add(AV9GridStateFilterValue, 0);
         AV6Session.Set(AV19Pgmname+"GridState", AV8GridState.ToXml(false, true, "GridState", "GXObligatorio1"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context);
         AV11TrnContext.gxTpr_Callerobject = AV19Pgmname;
         AV11TrnContext.gxTpr_Callerondelete = true;
         AV11TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV11TrnContext.gxTpr_Transactionname = "Entrada";
         AV6Session.Set("TrnContext", AV11TrnContext.ToXml(false, true, "TransactionContext", "GXObligatorio1"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA1C2( ) ;
         WS1C2( ) ;
         WE1C2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202162151529", true, true);
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
            context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
            context.AddJavascriptSource("wwentrada.js", "?20202162151529", false, true);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_252( )
      {
         edtEntradaId_Internalname = "ENTRADAID_"+sGXsfl_25_idx;
         edtVentaId_Internalname = "VENTAID_"+sGXsfl_25_idx;
         edtVentaFecha_Internalname = "VENTAFECHA_"+sGXsfl_25_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_25_idx;
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE_"+sGXsfl_25_idx;
         edtEspectaculoFecha_Internalname = "ESPECTACULOFECHA_"+sGXsfl_25_idx;
         edtVentaPaisId_Internalname = "VENTAPAISID_"+sGXsfl_25_idx;
         edtVentaPaisNombre_Internalname = "VENTAPAISNOMBRE_"+sGXsfl_25_idx;
         edtVentaPaisBandera_Internalname = "VENTAPAISBANDERA_"+sGXsfl_25_idx;
         edtVentaCiudadId_Internalname = "VENTACIUDADID_"+sGXsfl_25_idx;
         edtVentaCiudadNombre_Internalname = "VENTACIUDADNOMBRE_"+sGXsfl_25_idx;
         edtEspectaculoPaisId_Internalname = "ESPECTACULOPAISID_"+sGXsfl_25_idx;
         edtEspectaculoPaisNombre_Internalname = "ESPECTACULOPAISNOMBRE_"+sGXsfl_25_idx;
         edtEspectaculoPaisBandera_Internalname = "ESPECTACULOPAISBANDERA_"+sGXsfl_25_idx;
         edtEspectaculoCiudadId_Internalname = "ESPECTACULOCIUDADID_"+sGXsfl_25_idx;
         edtEspectaculoCiudadNombre_Internalname = "ESPECTACULOCIUDADNOMBRE_"+sGXsfl_25_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_25_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_25_idx;
      }

      protected void SubsflControlProps_fel_252( )
      {
         edtEntradaId_Internalname = "ENTRADAID_"+sGXsfl_25_fel_idx;
         edtVentaId_Internalname = "VENTAID_"+sGXsfl_25_fel_idx;
         edtVentaFecha_Internalname = "VENTAFECHA_"+sGXsfl_25_fel_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_25_fel_idx;
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE_"+sGXsfl_25_fel_idx;
         edtEspectaculoFecha_Internalname = "ESPECTACULOFECHA_"+sGXsfl_25_fel_idx;
         edtVentaPaisId_Internalname = "VENTAPAISID_"+sGXsfl_25_fel_idx;
         edtVentaPaisNombre_Internalname = "VENTAPAISNOMBRE_"+sGXsfl_25_fel_idx;
         edtVentaPaisBandera_Internalname = "VENTAPAISBANDERA_"+sGXsfl_25_fel_idx;
         edtVentaCiudadId_Internalname = "VENTACIUDADID_"+sGXsfl_25_fel_idx;
         edtVentaCiudadNombre_Internalname = "VENTACIUDADNOMBRE_"+sGXsfl_25_fel_idx;
         edtEspectaculoPaisId_Internalname = "ESPECTACULOPAISID_"+sGXsfl_25_fel_idx;
         edtEspectaculoPaisNombre_Internalname = "ESPECTACULOPAISNOMBRE_"+sGXsfl_25_fel_idx;
         edtEspectaculoPaisBandera_Internalname = "ESPECTACULOPAISBANDERA_"+sGXsfl_25_fel_idx;
         edtEspectaculoCiudadId_Internalname = "ESPECTACULOCIUDADID_"+sGXsfl_25_fel_idx;
         edtEspectaculoCiudadNombre_Internalname = "ESPECTACULOCIUDADNOMBRE_"+sGXsfl_25_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_25_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_25_fel_idx;
      }

      protected void sendrow_252( )
      {
         SubsflControlProps_252( ) ;
         WB1C0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_25_idx <= subGrid_fnc_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_25_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " class=\""+"WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_25_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEntradaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A39EntradaId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A39EntradaId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtEntradaId_Link,(String)"",(String)"",(String)"",(String)edtEntradaId_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37VentaId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A37VentaId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A38VentaFecha_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000VentaFecha_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A38VentaFecha)) ? A40000VentaFecha_GXI : context.PathToRelativeUrl( A38VentaFecha));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaFecha_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A38VentaFecha_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoNombre_Internalname,StringUtil.RTrim( A35EspectaculoNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtEspectaculoNombre_Link,(String)"",(String)"",(String)"",(String)edtEspectaculoNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoFecha_Internalname,context.localUtil.Format(A36EspectaculoFecha, "99/99/99"),context.localUtil.Format( A36EspectaculoFecha, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoFecha_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaPaisId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24VentaPaisId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A24VentaPaisId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaPaisId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaPaisNombre_Internalname,StringUtil.RTrim( A25VentaPaisNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaPaisNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A26VentaPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40001VentaPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A26VentaPaisBandera)) ? A40001VentaPaisBandera_GXI : context.PathToRelativeUrl( A26VentaPaisBandera));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaPaisBandera_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A26VentaPaisBandera_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaCiudadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27VentaCiudadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A27VentaCiudadId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaCiudadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVentaCiudadNombre_Internalname,StringUtil.RTrim( A28VentaCiudadNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVentaCiudadNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoPaisId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoPaisId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoPaisNombre_Internalname,StringUtil.RTrim( A20EspectaculoPaisNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoPaisNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A21EspectaculoPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40004EspectaculoPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40004EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoPaisBandera_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn WWOptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A21EspectaculoPaisBandera_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoCiudadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoCiudadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoCiudadNombre_Internalname,StringUtil.RTrim( A23EspectaculoCiudadNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoCiudadNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "TextActionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV14Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"TextActionAttribute",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "TextActionAttribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV15Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"TextActionAttribute",(String)"",(String)ROClassString,(String)"WWTextActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true,(String)""});
            send_integrity_lvl_hashes1C2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_25_idx = ((subGrid_Islastpage==1)&&(nGXsfl_25_idx+1>subGrid_fnc_Recordsperpage( )) ? 1 : nGXsfl_25_idx+1);
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_25_idx), 4, 0), 4, "0");
            SubsflControlProps_252( ) ;
         }
         /* End function sendrow_252 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         bttBtninsert_Internalname = "BTNINSERT";
         edtavEntradaid_Internalname = "vENTRADAID";
         divTabletop_Internalname = "TABLETOP";
         edtEntradaId_Internalname = "ENTRADAID";
         edtVentaId_Internalname = "VENTAID";
         edtVentaFecha_Internalname = "VENTAFECHA";
         edtEspectaculoId_Internalname = "ESPECTACULOID";
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = "ESPECTACULOFECHA";
         edtVentaPaisId_Internalname = "VENTAPAISID";
         edtVentaPaisNombre_Internalname = "VENTAPAISNOMBRE";
         edtVentaPaisBandera_Internalname = "VENTAPAISBANDERA";
         edtVentaCiudadId_Internalname = "VENTACIUDADID";
         edtVentaCiudadNombre_Internalname = "VENTACIUDADNOMBRE";
         edtEspectaculoPaisId_Internalname = "ESPECTACULOPAISID";
         edtEspectaculoPaisNombre_Internalname = "ESPECTACULOPAISNOMBRE";
         edtEspectaculoPaisBandera_Internalname = "ESPECTACULOPAISBANDERA";
         edtEspectaculoCiudadId_Internalname = "ESPECTACULOCIUDADID";
         edtEspectaculoCiudadNombre_Internalname = "ESPECTACULOCIUDADNOMBRE";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         divGridtable_Internalname = "GRIDTABLE";
         divGridcell_Internalname = "GRIDCELL";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtEspectaculoCiudadNombre_Jsonclick = "";
         edtEspectaculoCiudadId_Jsonclick = "";
         edtEspectaculoPaisNombre_Jsonclick = "";
         edtEspectaculoPaisId_Jsonclick = "";
         edtVentaCiudadNombre_Jsonclick = "";
         edtVentaCiudadId_Jsonclick = "";
         edtVentaPaisNombre_Jsonclick = "";
         edtVentaPaisId_Jsonclick = "";
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoId_Jsonclick = "";
         edtVentaId_Jsonclick = "";
         edtEntradaId_Jsonclick = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         edtEspectaculoNombre_Link = "";
         edtEntradaId_Link = "";
         subGrid_Header = "";
         edtavDelete_Enabled = 0;
         edtavUpdate_Enabled = 0;
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavEntradaid_Jsonclick = "";
         edtavEntradaid_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Entradas";
         subGrid_Rows = 10;
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV13EntradaId',fld:'vENTRADAID',pic:'ZZZ9'},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E141C2',iparms:[{av:'A39EntradaId',fld:'ENTRADAID',pic:'ZZZ9',hsh:true},{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtEntradaId_Link',ctrl:'ENTRADAID',prop:'Link'},{av:'edtEspectaculoNombre_Link',ctrl:'ESPECTACULONOMBRE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E111C2',iparms:[{av:'A39EntradaId',fld:'ENTRADAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13EntradaId',fld:'vENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13EntradaId',fld:'vENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13EntradaId',fld:'vENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14Update',fld:'vUPDATE',pic:''},{av:'AV15Delete',fld:'vDELETE',pic:''},{av:'AV19Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV13EntradaId',fld:'vENTRADAID',pic:'ZZZ9'}]");
         setEventMetadata("GRID_LASTPAGE",",oparms:[]}");
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
         AV14Update = "";
         AV15Delete = "";
         AV19Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblTitletext_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A38VentaFecha = "";
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         A25VentaPaisNombre = "";
         A26VentaPaisBandera = "";
         A28VentaCiudadNombre = "";
         A20EspectaculoPaisNombre = "";
         A21EspectaculoPaisBandera = "";
         A23EspectaculoCiudadNombre = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         A40000VentaFecha_GXI = "";
         A40001VentaPaisBandera_GXI = "";
         A40004EspectaculoPaisBandera_GXI = "";
         scmdbuf = "";
         H001C2_A23EspectaculoCiudadNombre = new String[] {""} ;
         H001C2_A22EspectaculoCiudadId = new short[1] ;
         H001C2_A40004EspectaculoPaisBandera_GXI = new String[] {""} ;
         H001C2_n40004EspectaculoPaisBandera_GXI = new bool[] {false} ;
         H001C2_A20EspectaculoPaisNombre = new String[] {""} ;
         H001C2_A19EspectaculoPaisId = new short[1] ;
         H001C2_A28VentaCiudadNombre = new String[] {""} ;
         H001C2_A27VentaCiudadId = new short[1] ;
         H001C2_A40001VentaPaisBandera_GXI = new String[] {""} ;
         H001C2_n40001VentaPaisBandera_GXI = new bool[] {false} ;
         H001C2_A25VentaPaisNombre = new String[] {""} ;
         H001C2_A24VentaPaisId = new short[1] ;
         H001C2_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         H001C2_A35EspectaculoNombre = new String[] {""} ;
         H001C2_A34EspectaculoId = new short[1] ;
         H001C2_A40000VentaFecha_GXI = new String[] {""} ;
         H001C2_A37VentaId = new short[1] ;
         H001C2_A39EntradaId = new short[1] ;
         H001C2_A21EspectaculoPaisBandera = new String[] {""} ;
         H001C2_A26VentaPaisBandera = new String[] {""} ;
         H001C2_A38VentaFecha = new String[] {""} ;
         H001C3_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV7HTTPRequest = new GxHttpRequest( context);
         AV8GridState = new SdtGridState(context);
         AV6Session = context.GetSession();
         AV9GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         sImgUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwentrada__default(),
            new Object[][] {
                new Object[] {
               H001C2_A23EspectaculoCiudadNombre, H001C2_A22EspectaculoCiudadId, H001C2_A40004EspectaculoPaisBandera_GXI, H001C2_n40004EspectaculoPaisBandera_GXI, H001C2_A20EspectaculoPaisNombre, H001C2_A19EspectaculoPaisId, H001C2_A28VentaCiudadNombre, H001C2_A27VentaCiudadId, H001C2_A40001VentaPaisBandera_GXI, H001C2_n40001VentaPaisBandera_GXI,
               H001C2_A25VentaPaisNombre, H001C2_A24VentaPaisId, H001C2_A36EspectaculoFecha, H001C2_A35EspectaculoNombre, H001C2_A34EspectaculoId, H001C2_A40000VentaFecha_GXI, H001C2_A37VentaId, H001C2_A39EntradaId, H001C2_A21EspectaculoPaisBandera, H001C2_A26VentaPaisBandera,
               H001C2_A38VentaFecha
               }
               , new Object[] {
               H001C3_AGRID_nRecordCount
               }
            }
         );
         AV19Pgmname = "WWEntrada";
         /* GeneXus formulas. */
         AV19Pgmname = "WWEntrada";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short GRID_nEOF ;
      private short AV13EntradaId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A39EntradaId ;
      private short A37VentaId ;
      private short A34EspectaculoId ;
      private short A24VentaPaisId ;
      private short A27VentaCiudadId ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid_Backstyle ;
      private int nRC_GXsfl_25 ;
      private int nGXsfl_25_idx=1 ;
      private int subGrid_Rows ;
      private int edtavEntradaid_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV10GridPageCount ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_25_idx="0001" ;
      private String AV14Update ;
      private String AV15Delete ;
      private String AV19Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String edtavEntradaid_Internalname ;
      private String edtavEntradaid_Jsonclick ;
      private String divGridcell_Internalname ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String subGrid_Header ;
      private String edtEntradaId_Link ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Link ;
      private String A25VentaPaisNombre ;
      private String A28VentaCiudadNombre ;
      private String A20EspectaculoPaisNombre ;
      private String A23EspectaculoCiudadNombre ;
      private String edtavUpdate_Link ;
      private String edtavDelete_Link ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtEntradaId_Internalname ;
      private String edtVentaId_Internalname ;
      private String edtVentaFecha_Internalname ;
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoNombre_Internalname ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtVentaPaisId_Internalname ;
      private String edtVentaPaisNombre_Internalname ;
      private String edtVentaPaisBandera_Internalname ;
      private String edtVentaCiudadId_Internalname ;
      private String edtVentaCiudadNombre_Internalname ;
      private String edtEspectaculoPaisId_Internalname ;
      private String edtEspectaculoPaisNombre_Internalname ;
      private String edtEspectaculoPaisBandera_Internalname ;
      private String edtEspectaculoCiudadId_Internalname ;
      private String edtEspectaculoCiudadNombre_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_25_fel_idx="0001" ;
      private String ROClassString ;
      private String edtEntradaId_Jsonclick ;
      private String edtVentaId_Jsonclick ;
      private String sImgUrl ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtVentaPaisId_Jsonclick ;
      private String edtVentaPaisNombre_Jsonclick ;
      private String edtVentaCiudadId_Jsonclick ;
      private String edtVentaCiudadNombre_Jsonclick ;
      private String edtEspectaculoPaisId_Jsonclick ;
      private String edtEspectaculoPaisNombre_Jsonclick ;
      private String edtEspectaculoCiudadId_Jsonclick ;
      private String edtEspectaculoCiudadNombre_Jsonclick ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_25_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool n40004EspectaculoPaisBandera_GXI ;
      private bool n40001VentaPaisBandera_GXI ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool A38VentaFecha_IsBlob ;
      private bool A26VentaPaisBandera_IsBlob ;
      private bool A21EspectaculoPaisBandera_IsBlob ;
      private String A40000VentaFecha_GXI ;
      private String A40001VentaPaisBandera_GXI ;
      private String A40004EspectaculoPaisBandera_GXI ;
      private String A38VentaFecha ;
      private String A26VentaPaisBandera ;
      private String A21EspectaculoPaisBandera ;
      private IGxSession AV6Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001C2_A23EspectaculoCiudadNombre ;
      private short[] H001C2_A22EspectaculoCiudadId ;
      private String[] H001C2_A40004EspectaculoPaisBandera_GXI ;
      private bool[] H001C2_n40004EspectaculoPaisBandera_GXI ;
      private String[] H001C2_A20EspectaculoPaisNombre ;
      private short[] H001C2_A19EspectaculoPaisId ;
      private String[] H001C2_A28VentaCiudadNombre ;
      private short[] H001C2_A27VentaCiudadId ;
      private String[] H001C2_A40001VentaPaisBandera_GXI ;
      private bool[] H001C2_n40001VentaPaisBandera_GXI ;
      private String[] H001C2_A25VentaPaisNombre ;
      private short[] H001C2_A24VentaPaisId ;
      private DateTime[] H001C2_A36EspectaculoFecha ;
      private String[] H001C2_A35EspectaculoNombre ;
      private short[] H001C2_A34EspectaculoId ;
      private String[] H001C2_A40000VentaFecha_GXI ;
      private short[] H001C2_A37VentaId ;
      private short[] H001C2_A39EntradaId ;
      private String[] H001C2_A21EspectaculoPaisBandera ;
      private String[] H001C2_A26VentaPaisBandera ;
      private String[] H001C2_A38VentaFecha ;
      private long[] H001C3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GXWebForm Form ;
      private SdtGridState AV8GridState ;
      private SdtGridState_FilterValue AV9GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwentrada__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001C2( IGxContext context ,
                                             short AV13EntradaId ,
                                             short A39EntradaId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [4] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T7.[CiudadNombre] AS EspectaculoCiudadNombre, T5.[EspectaculoCiudadId] AS EspectaculoCiudadId, T6.[PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, T6.[PaisNombre] AS EspectaculoPaisNombre, T5.[EspectaculoPaisId] AS EspectaculoPaisId, T4.[CiudadNombre] AS VentaCiudadNombre, T2.[VentaCiudadId] AS VentaCiudadId, T3.[PaisBandera_GXI] AS VentaPaisBandera_GXI, T3.[PaisNombre] AS VentaPaisNombre, T2.[VentaPaisId] AS VentaPaisId, T5.[EspectaculoFecha], T5.[EspectaculoNombre], T2.[EspectaculoId], T2.[VentaFecha_GXI], T1.[VentaId], T1.[EntradaId], T6.[PaisBandera] AS EspectaculoPaisBandera, T3.[PaisBandera] AS VentaPaisBandera, T2.[VentaFecha]";
         sFromString = " FROM (((((([Entrada] T1 INNER JOIN [Venta] T2 ON T2.[VentaId] = T1.[VentaId]) INNER JOIN [Pais] T3 ON T3.[PaisId] = T2.[VentaPaisId]) INNER JOIN [PaisCiudad] T4 ON T4.[PaisId] = T2.[VentaPaisId] AND T4.[CiudadId] = T2.[VentaCiudadId]) INNER JOIN [Espectaculo] T5 ON T5.[EspectaculoId] = T2.[EspectaculoId]) INNER JOIN [Pais] T6 ON T6.[PaisId] = T5.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T7 ON T7.[PaisId] = T5.[EspectaculoPaisId] AND T7.[CiudadId] = T5.[EspectaculoCiudadId])";
         sOrderString = "";
         if ( ! (0==AV13EntradaId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[EntradaId] >= @AV13EntradaId)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[EntradaId] >= @AV13EntradaId)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         sOrderString = sOrderString + " ORDER BY T1.[EntradaId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001C3( IGxContext context ,
                                             short AV13EntradaId ,
                                             short A39EntradaId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [1] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (((((([Entrada] T1 INNER JOIN [Venta] T2 ON T2.[VentaId] = T1.[VentaId]) INNER JOIN [Pais] T6 ON T6.[PaisId] = T2.[VentaPaisId]) INNER JOIN [PaisCiudad] T7 ON T7.[PaisId] = T2.[VentaPaisId] AND T7.[CiudadId] = T2.[VentaCiudadId]) INNER JOIN [Espectaculo] T3 ON T3.[EspectaculoId] = T2.[EspectaculoId]) INNER JOIN [Pais] T4 ON T4.[PaisId] = T3.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T5 ON T5.[PaisId] = T3.[EspectaculoPaisId] AND T5.[CiudadId] = T3.[EspectaculoCiudadId])";
         if ( ! (0==AV13EntradaId) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[EntradaId] >= @AV13EntradaId)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[EntradaId] >= @AV13EntradaId)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
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
                     return conditional_H001C2(context, (short)dynConstraints[0] , (short)dynConstraints[1] );
               case 1 :
                     return conditional_H001C3(context, (short)dynConstraints[0] , (short)dynConstraints[1] );
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
          Object[] prmH001C2 ;
          prmH001C2 = new Object[] {
          new Object[] {"@AV13EntradaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH001C3 ;
          prmH001C3 = new Object[] {
          new Object[] {"@AV13EntradaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H001C3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001C3,1, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 100) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getString(6, 100) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaUri(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((String[]) buf[10])[0] = rslt.getString(9, 100) ;
                ((short[]) buf[11])[0] = rslt.getShort(10) ;
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(11) ;
                ((String[]) buf[13])[0] = rslt.getString(12, 100) ;
                ((short[]) buf[14])[0] = rslt.getShort(13) ;
                ((String[]) buf[15])[0] = rslt.getMultimediaUri(14) ;
                ((short[]) buf[16])[0] = rslt.getShort(15) ;
                ((short[]) buf[17])[0] = rslt.getShort(16) ;
                ((String[]) buf[18])[0] = rslt.getMultimediaFile(17, rslt.getVarchar(3)) ;
                ((String[]) buf[19])[0] = rslt.getMultimediaFile(18, rslt.getVarchar(8)) ;
                ((String[]) buf[20])[0] = rslt.getMultimediaFile(19, rslt.getVarchar(14)) ;
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
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[1]);
                }
                return;
       }
    }

 }

}
