/*!   GeneXus C# 16_0_7-138086 on 2/16/2020 17:38:11.29
*/
gx.evt.autoSkip=!1;gx.define("localidadsectorwc",!0,function(n){var t,i;this.ServerClass="localidadsectorwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6LocalidadId=gx.fn.getIntegerValue("vLOCALIDADID",",");this.AV6LocalidadId=gx.fn.getIntegerValue("vLOCALIDADID",",")};this.e130u2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e140u2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,13,14,15,16,17,18];this.GXLastCtrlId=18;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"localidadsectorwc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(17,13,"SECTORID","Id","","SectorId","int",0,"px",4,4,"right",null,[],17,"SectorId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(18,14,"SECTORNOMBRE","Nombre","","SectorNombre","char",0,"px",100,80,"left",null,[],18,"SectorNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"GRIDCELL",grid:0};t[6]={id:6,fld:"GRIDTABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[13]={id:13,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECTORID",gxz:"Z17SectorId",gxold:"O17SectorId",gxvar:"A17SectorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17SectorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17SectorId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("SECTORID",n||gx.fn.currentGridRowImpl(12),gx.O.A17SectorId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A17SectorId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("SECTORID",n||gx.fn.currentGridRowImpl(12),",")},nac:gx.falseFn};t[14]={id:14,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECTORNOMBRE",gxz:"Z18SectorNombre",gxold:"O18SectorNombre",gxvar:"A18SectorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A18SectorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z18SectorNombre=n)},v2c:function(n){gx.fn.setGridControlValue("SECTORNOMBRE",n||gx.fn.currentGridRowImpl(12),gx.O.A18SectorNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A18SectorNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("SECTORNOMBRE",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADID",gxz:"Z11LocalidadId",gxold:"O11LocalidadId",gxvar:"A11LocalidadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11LocalidadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("LOCALIDADID",gx.O.A11LocalidadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("LOCALIDADID",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});this.Z17SectorId=0;this.O17SectorId=0;this.Z18SectorNombre="";this.O18SectorNombre="";this.A11LocalidadId=0;this.Z11LocalidadId=0;this.O11LocalidadId=0;this.A11LocalidadId=0;this.AV6LocalidadId=0;this.A17SectorId=0;this.A18SectorNombre="";this.Events={e130u2_client:["ENTER",!0],e140u2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("LOCALIDADID","Visible")',ctrl:"LOCALIDADID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6LocalidadId",fld:"vLOCALIDADID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.setVCMap("AV6LocalidadId","vLOCALIDADID",0,"int",4,0);this.setVCMap("AV6LocalidadId","vLOCALIDADID",0,"int",4,0);this.setVCMap("AV6LocalidadId","vLOCALIDADID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6LocalidadId"});i.addRefreshingParm({rfrVar:"AV6LocalidadId"});this.Initialize()})