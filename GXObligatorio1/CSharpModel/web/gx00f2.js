/*!   GeneXus C# 16_0_7-138086 on 2/25/2020 21:45:28.93
*/
gx.evt.autoSkip=!1;gx.define("gx00f2",!1,function(){var n,t;this.ServerClass="gx00f2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pEspectaculoId=gx.fn.getIntegerValue("vPESPECTACULOID",",");this.AV9pLocalidadId=gx.fn.getIntegerValue("vPLOCALIDADID",",");this.AV10pSectorId=gx.fn.getIntegerValue("vPSECTORID",",");this.AV8pEspectaculoId=gx.fn.getIntegerValue("vPESPECTACULOID",",");this.AV9pLocalidadId=gx.fn.getIntegerValue("vPLOCALIDADID",",")};this.e132h1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e112h1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SECTORIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SECTORIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSECTORID","Visible",!0)):(gx.fn.setCtrlProperty("SECTORIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSECTORID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SECTORIDFILTERCONTAINER","Class")',ctrl:"SECTORIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSECTORID","Visible")',ctrl:"vCSECTORID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e122h1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("SECTORNOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("SECTORNOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCSECTORNOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("SECTORNOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCSECTORNOMBRE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("SECTORNOMBREFILTERCONTAINER","Class")',ctrl:"SECTORNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSECTORNOMBRE","Visible")',ctrl:"vCSECTORNOMBRE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e162h2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e172h1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41,42];this.GXLastCtrlId=42;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00f2",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(17,36,"SECTORID","Id","","SectorId","int",0,"px",4,4,"right",null,[],17,"SectorId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(18,37,"SECTORNOMBRE","Nombre","","SectorNombre","char",0,"px",100,80,"left",null,[],18,"SectorNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(34,38,"ESPECTACULOID","Espectaculo Id","","EspectaculoId","int",0,"px",4,4,"right",null,[],34,"EspectaculoId",!1,0,!1,!1,"Attribute",1,"");t.addSingleLineEdit(11,39,"LOCALIDADID","Localidad Id","","LocalidadId","int",0,"px",4,4,"right",null,[],11,"LocalidadId",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"SECTORIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLSECTORIDFILTER",format:1,grid:0,evt:"e112h1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSECTORID",gxz:"ZV6cSectorId",gxold:"OV6cSectorId",gxvar:"AV6cSectorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cSectorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cSectorId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCSECTORID",gx.O.AV6cSectorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cSectorId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCSECTORID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"SECTORNOMBREFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLSECTORNOMBREFILTER",format:1,grid:0,evt:"e122h1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCSECTORNOMBRE",gxz:"ZV7cSectorNombre",gxold:"OV7cSectorNombre",gxvar:"AV7cSectorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cSectorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cSectorNombre=n)},v2c:function(){gx.fn.setControlValue("vCSECTORNOMBRE",gx.O.AV7cSectorNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cSectorNombre=this.val())},val:function(){return gx.fn.getControlValue("vCSECTORNOMBRE")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0,evt:"e132h1_client"};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV14Linkselection_GXI)},c2v:function(n){gx.O.AV14Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV14Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECTORID",gxz:"Z17SectorId",gxold:"O17SectorId",gxvar:"A17SectorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17SectorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17SectorId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SECTORID",n||gx.fn.currentGridRowImpl(34),gx.O.A17SectorId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A17SectorId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("SECTORID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECTORNOMBRE",gxz:"Z18SectorNombre",gxold:"O18SectorNombre",gxvar:"A18SectorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A18SectorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z18SectorNombre=n)},v2c:function(n){gx.fn.setGridControlValue("SECTORNOMBRE",n||gx.fn.currentGridRowImpl(34),gx.O.A18SectorNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A18SectorNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("SECTORNOMBRE",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOID",gxz:"Z34EspectaculoId",gxold:"O34EspectaculoId",gxvar:"A34EspectaculoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z34EspectaculoId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOID",n||gx.fn.currentGridRowImpl(34),gx.O.A34EspectaculoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("ESPECTACULOID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[39]={id:39,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADID",gxz:"Z11LocalidadId",gxold:"O11LocalidadId",gxvar:"A11LocalidadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11LocalidadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("LOCALIDADID",n||gx.fn.currentGridRowImpl(34),gx.O.A11LocalidadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("LOCALIDADID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"BTN_CANCEL",grid:0,evt:"e172h1_client"};this.AV6cSectorId=0;this.ZV6cSectorId=0;this.OV6cSectorId=0;this.AV7cSectorNombre="";this.ZV7cSectorNombre="";this.OV7cSectorNombre="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z17SectorId=0;this.O17SectorId=0;this.Z18SectorNombre="";this.O18SectorNombre="";this.Z34EspectaculoId=0;this.O34EspectaculoId=0;this.Z11LocalidadId=0;this.O11LocalidadId=0;this.AV6cSectorId=0;this.AV7cSectorNombre="";this.AV8pEspectaculoId=0;this.AV9pLocalidadId=0;this.AV10pSectorId=0;this.AV5LinkSelection="";this.A17SectorId=0;this.A18SectorNombre="";this.A34EspectaculoId=0;this.A11LocalidadId=0;this.Events={e162h2_client:["ENTER",!0],e172h1_client:["CANCEL",!0],e132h1_client:["'TOGGLE'",!1],e112h1_client:["LBLSECTORIDFILTER.CLICK",!1],e122h1_client:["LBLSECTORNOMBREFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cSectorId",fld:"vCSECTORID",pic:"ZZZ9"},{av:"AV7cSectorNombre",fld:"vCSECTORNOMBRE",pic:""},{av:"AV8pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"},{av:"AV9pLocalidadId",fld:"vPLOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLSECTORIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SECTORIDFILTERCONTAINER","Class")',ctrl:"SECTORIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SECTORIDFILTERCONTAINER","Class")',ctrl:"SECTORIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSECTORID","Visible")',ctrl:"vCSECTORID",prop:"Visible"}]];this.EvtParms["LBLSECTORNOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("SECTORNOMBREFILTERCONTAINER","Class")',ctrl:"SECTORNOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("SECTORNOMBREFILTERCONTAINER","Class")',ctrl:"SECTORNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCSECTORNOMBRE","Visible")',ctrl:"vCSECTORNOMBRE",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A17SectorId",fld:"SECTORID",pic:"ZZZ9",hsh:!0}],[{av:"AV10pSectorId",fld:"vPSECTORID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cSectorId",fld:"vCSECTORID",pic:"ZZZ9"},{av:"AV7cSectorNombre",fld:"vCSECTORNOMBRE",pic:""},{av:"AV8pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"},{av:"AV9pLocalidadId",fld:"vPLOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cSectorId",fld:"vCSECTORID",pic:"ZZZ9"},{av:"AV7cSectorNombre",fld:"vCSECTORNOMBRE",pic:""},{av:"AV8pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"},{av:"AV9pLocalidadId",fld:"vPLOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cSectorId",fld:"vCSECTORID",pic:"ZZZ9"},{av:"AV7cSectorNombre",fld:"vCSECTORNOMBRE",pic:""},{av:"AV8pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"},{av:"AV9pLocalidadId",fld:"vPLOCALIDADID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cSectorId",fld:"vCSECTORID",pic:"ZZZ9"},{av:"AV7cSectorNombre",fld:"vCSECTORNOMBRE",pic:""},{av:"AV8pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"},{av:"AV9pLocalidadId",fld:"vPLOCALIDADID",pic:"ZZZ9"}],[]];this.setVCMap("AV8pEspectaculoId","vPESPECTACULOID",0,"int",4,0);this.setVCMap("AV9pLocalidadId","vPLOCALIDADID",0,"int",4,0);this.setVCMap("AV10pSectorId","vPSECTORID",0,"int",4,0);this.setVCMap("AV8pEspectaculoId","vPESPECTACULOID",0,"int",4,0);this.setVCMap("AV9pLocalidadId","vPLOCALIDADID",0,"int",4,0);this.setVCMap("AV8pEspectaculoId","vPESPECTACULOID",0,"int",4,0);this.setVCMap("AV9pLocalidadId","vPLOCALIDADID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar({rfrVar:"AV8pEspectaculoId"});t.addRefreshingVar({rfrVar:"AV9pLocalidadId"});t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm({rfrVar:"AV8pEspectaculoId"});t.addRefreshingParm({rfrVar:"AV9pLocalidadId"});this.Initialize()});gx.wi(function(){gx.createParentObj(gx00f2)})