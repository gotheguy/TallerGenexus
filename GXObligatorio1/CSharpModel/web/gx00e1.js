/*!   GeneXus C# 16_0_7-138086 on 2/16/2020 21:49:14.63
*/
gx.evt.autoSkip=!1;gx.define("gx00e1",!1,function(){var n,t;this.ServerClass="gx00e1";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7pEspectaculoId=gx.fn.getIntegerValue("vPESPECTACULOID",",");this.AV8pLocalidadId=gx.fn.getIntegerValue("vPLOCALIDADID",",");this.AV7pEspectaculoId=gx.fn.getIntegerValue("vPESPECTACULOID",",")};this.e171q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e111q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("LOCALIDADIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("LOCALIDADIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCLOCALIDADID","Visible",!0)):(gx.fn.setCtrlProperty("LOCALIDADIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCLOCALIDADID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("LOCALIDADIDFILTERCONTAINER","Class")',ctrl:"LOCALIDADIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADID","Visible")',ctrl:"vCLOCALIDADID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e121q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("LOCALIDADNOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("LOCALIDADNOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCLOCALIDADNOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("LOCALIDADNOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCLOCALIDADNOMBRE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("LOCALIDADNOMBREFILTERCONTAINER","Class")',ctrl:"LOCALIDADNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADNOMBRE","Visible")',ctrl:"vCLOCALIDADNOMBRE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e131q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("LOCALIDADCAPACIDADFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("LOCALIDADCAPACIDADFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCLOCALIDADCAPACIDAD","Visible",!0)):(gx.fn.setCtrlProperty("LOCALIDADCAPACIDADFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCLOCALIDADCAPACIDAD","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("LOCALIDADCAPACIDADFILTERCONTAINER","Class")',ctrl:"LOCALIDADCAPACIDADFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADCAPACIDAD","Visible")',ctrl:"vCLOCALIDADCAPACIDAD",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e141q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("LOCALIDADPRECIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("LOCALIDADPRECIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCLOCALIDADPRECIO","Visible",!0)):(gx.fn.setCtrlProperty("LOCALIDADPRECIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCLOCALIDADPRECIO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("LOCALIDADPRECIOFILTERCONTAINER","Class")',ctrl:"LOCALIDADPRECIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADPRECIO","Visible")',ctrl:"vCLOCALIDADPRECIO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e151q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("LOCALIDADESVENDIDASFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("LOCALIDADESVENDIDASFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCLOCALIDADESVENDIDAS","Visible",!0)):(gx.fn.setCtrlProperty("LOCALIDADESVENDIDASFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCLOCALIDADESVENDIDAS","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("LOCALIDADESVENDIDASFILTERCONTAINER","Class")',ctrl:"LOCALIDADESVENDIDASFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADESVENDIDAS","Visible")',ctrl:"vCLOCALIDADESVENDIDAS",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e161q1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("LOCALIDADESDISPONIBLESFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("LOCALIDADESDISPONIBLESFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCLOCALIDADESDISPONIBLES","Visible",!0)):(gx.fn.setCtrlProperty("LOCALIDADESDISPONIBLESFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCLOCALIDADESDISPONIBLES","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("LOCALIDADESDISPONIBLESFILTERCONTAINER","Class")',ctrl:"LOCALIDADESDISPONIBLESFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADESDISPONIBLES","Visible")',ctrl:"vCLOCALIDADESDISPONIBLES",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e201q2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e211q1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81];this.GXLastCtrlId=81;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00e1",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(11,76,"LOCALIDADID","Id","","LocalidadId","int",0,"px",4,4,"right",null,[],11,"LocalidadId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(12,77,"LOCALIDADNOMBRE","Nombre","","LocalidadNombre","char",0,"px",100,80,"left",null,[],12,"LocalidadNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(34,78,"ESPECTACULOID","Espectaculo Id","","EspectaculoId","int",0,"px",4,4,"right",null,[],34,"EspectaculoId",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"LOCALIDADIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLLOCALIDADIDFILTER",format:1,grid:0,evt:"e111q1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCLOCALIDADID",gxz:"ZV6cLocalidadId",gxold:"OV6cLocalidadId",gxvar:"AV6cLocalidadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cLocalidadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cLocalidadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCLOCALIDADID",gx.O.AV6cLocalidadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cLocalidadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCLOCALIDADID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"LOCALIDADNOMBREFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLLOCALIDADNOMBREFILTER",format:1,grid:0,evt:"e121q1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCLOCALIDADNOMBRE",gxz:"ZV10cLocalidadNombre",gxold:"OV10cLocalidadNombre",gxvar:"AV10cLocalidadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cLocalidadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10cLocalidadNombre=n)},v2c:function(){gx.fn.setControlValue("vCLOCALIDADNOMBRE",gx.O.AV10cLocalidadNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cLocalidadNombre=this.val())},val:function(){return gx.fn.getControlValue("vCLOCALIDADNOMBRE")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"LOCALIDADCAPACIDADFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLLOCALIDADCAPACIDADFILTER",format:1,grid:0,evt:"e131q1_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:5,dec:0,sign:!1,pic:"ZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCLOCALIDADCAPACIDAD",gxz:"ZV11cLocalidadCapacidad",gxold:"OV11cLocalidadCapacidad",gxvar:"AV11cLocalidadCapacidad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11cLocalidadCapacidad=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11cLocalidadCapacidad=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCLOCALIDADCAPACIDAD",gx.O.AV11cLocalidadCapacidad,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11cLocalidadCapacidad=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCLOCALIDADCAPACIDAD",",")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"LOCALIDADPRECIOFILTERCONTAINER",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"LBLLOCALIDADPRECIOFILTER",format:1,grid:0,evt:"e141q1_client"};n[43]={id:43,fld:"",grid:0};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,lvl:0,type:"decimal",len:9,dec:2,sign:!1,pic:"ZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCLOCALIDADPRECIO",gxz:"ZV12cLocalidadPrecio",gxold:"OV12cLocalidadPrecio",gxvar:"AV12cLocalidadPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV12cLocalidadPrecio=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.ZV12cLocalidadPrecio=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("vCLOCALIDADPRECIO",gx.O.AV12cLocalidadPrecio,2,".")},c2v:function(){this.val()!==undefined&&(gx.O.AV12cLocalidadPrecio=this.val())},val:function(){return gx.fn.getDecimalValue("vCLOCALIDADPRECIO",",",".")},nac:gx.falseFn};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"LOCALIDADESVENDIDASFILTERCONTAINER",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"LBLLOCALIDADESVENDIDASFILTER",format:1,grid:0,evt:"e151q1_client"};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,lvl:0,type:"int",len:5,dec:0,sign:!1,pic:"ZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCLOCALIDADESVENDIDAS",gxz:"ZV13cLocalidadesVendidas",gxold:"OV13cLocalidadesVendidas",gxvar:"AV13cLocalidadesVendidas",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13cLocalidadesVendidas=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV13cLocalidadesVendidas=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCLOCALIDADESVENDIDAS",gx.O.AV13cLocalidadesVendidas,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13cLocalidadesVendidas=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCLOCALIDADESVENDIDAS",",")},nac:gx.falseFn};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"LOCALIDADESDISPONIBLESFILTERCONTAINER",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"LBLLOCALIDADESDISPONIBLESFILTER",format:1,grid:0,evt:"e161q1_client"};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"",grid:0};n[65]={id:65,fld:"",grid:0};n[66]={id:66,lvl:0,type:"int",len:5,dec:0,sign:!1,pic:"ZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCLOCALIDADESDISPONIBLES",gxz:"ZV14cLocalidadesDisponibles",gxold:"OV14cLocalidadesDisponibles",gxvar:"AV14cLocalidadesDisponibles",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV14cLocalidadesDisponibles=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV14cLocalidadesDisponibles=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCLOCALIDADESDISPONIBLES",gx.O.AV14cLocalidadesDisponibles,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14cLocalidadesDisponibles=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCLOCALIDADESDISPONIBLES",",")},nac:gx.falseFn};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"GRIDTABLE",grid:0};n[69]={id:69,fld:"",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTNTOGGLE",grid:0,evt:"e171q1_client"};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"",grid:0};n[75]={id:75,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV17Linkselection_GXI)},c2v:function(n){gx.O.AV17Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV17Linkselection_GXI",nac:gx.falseFn};n[76]={id:76,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADID",gxz:"Z11LocalidadId",gxold:"O11LocalidadId",gxvar:"A11LocalidadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11LocalidadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("LOCALIDADID",n||gx.fn.currentGridRowImpl(74),gx.O.A11LocalidadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A11LocalidadId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("LOCALIDADID",n||gx.fn.currentGridRowImpl(74),",")},nac:gx.falseFn};n[77]={id:77,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LOCALIDADNOMBRE",gxz:"Z12LocalidadNombre",gxold:"O12LocalidadNombre",gxvar:"A12LocalidadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A12LocalidadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z12LocalidadNombre=n)},v2c:function(n){gx.fn.setGridControlValue("LOCALIDADNOMBRE",n||gx.fn.currentGridRowImpl(74),gx.O.A12LocalidadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A12LocalidadNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("LOCALIDADNOMBRE",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[78]={id:78,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOID",gxz:"Z34EspectaculoId",gxold:"O34EspectaculoId",gxvar:"A34EspectaculoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z34EspectaculoId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOID",n||gx.fn.currentGridRowImpl(74),gx.O.A34EspectaculoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("ESPECTACULOID",n||gx.fn.currentGridRowImpl(74),",")},nac:gx.falseFn};n[79]={id:79,fld:"",grid:0};n[80]={id:80,fld:"",grid:0};n[81]={id:81,fld:"BTN_CANCEL",grid:0,evt:"e211q1_client"};this.AV6cLocalidadId=0;this.ZV6cLocalidadId=0;this.OV6cLocalidadId=0;this.AV10cLocalidadNombre="";this.ZV10cLocalidadNombre="";this.OV10cLocalidadNombre="";this.AV11cLocalidadCapacidad=0;this.ZV11cLocalidadCapacidad=0;this.OV11cLocalidadCapacidad=0;this.AV12cLocalidadPrecio=0;this.ZV12cLocalidadPrecio=0;this.OV12cLocalidadPrecio=0;this.AV13cLocalidadesVendidas=0;this.ZV13cLocalidadesVendidas=0;this.OV13cLocalidadesVendidas=0;this.AV14cLocalidadesDisponibles=0;this.ZV14cLocalidadesDisponibles=0;this.OV14cLocalidadesDisponibles=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z11LocalidadId=0;this.O11LocalidadId=0;this.Z12LocalidadNombre="";this.O12LocalidadNombre="";this.Z34EspectaculoId=0;this.O34EspectaculoId=0;this.AV6cLocalidadId=0;this.AV10cLocalidadNombre="";this.AV11cLocalidadCapacidad=0;this.AV12cLocalidadPrecio=0;this.AV13cLocalidadesVendidas=0;this.AV14cLocalidadesDisponibles=0;this.AV7pEspectaculoId=0;this.AV8pLocalidadId=0;this.A16LocalidadesDisponibles=0;this.A15LocalidadesVendidas=0;this.A14LocalidadPrecio=0;this.A13LocalidadCapacidad=0;this.AV5LinkSelection="";this.A11LocalidadId=0;this.A12LocalidadNombre="";this.A34EspectaculoId=0;this.Events={e201q2_client:["ENTER",!0],e211q1_client:["CANCEL",!0],e171q1_client:["'TOGGLE'",!1],e111q1_client:["LBLLOCALIDADIDFILTER.CLICK",!1],e121q1_client:["LBLLOCALIDADNOMBREFILTER.CLICK",!1],e131q1_client:["LBLLOCALIDADCAPACIDADFILTER.CLICK",!1],e141q1_client:["LBLLOCALIDADPRECIOFILTER.CLICK",!1],e151q1_client:["LBLLOCALIDADESVENDIDASFILTER.CLICK",!1],e161q1_client:["LBLLOCALIDADESDISPONIBLESFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cLocalidadId",fld:"vCLOCALIDADID",pic:"ZZZ9"},{av:"AV10cLocalidadNombre",fld:"vCLOCALIDADNOMBRE",pic:""},{av:"AV11cLocalidadCapacidad",fld:"vCLOCALIDADCAPACIDAD",pic:"ZZZZ9"},{av:"AV12cLocalidadPrecio",fld:"vCLOCALIDADPRECIO",pic:"ZZZZZ9.99"},{av:"AV13cLocalidadesVendidas",fld:"vCLOCALIDADESVENDIDAS",pic:"ZZZZ9"},{av:"AV14cLocalidadesDisponibles",fld:"vCLOCALIDADESDISPONIBLES",pic:"ZZZZ9"},{av:"AV7pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLLOCALIDADIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("LOCALIDADIDFILTERCONTAINER","Class")',ctrl:"LOCALIDADIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("LOCALIDADIDFILTERCONTAINER","Class")',ctrl:"LOCALIDADIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADID","Visible")',ctrl:"vCLOCALIDADID",prop:"Visible"}]];this.EvtParms["LBLLOCALIDADNOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("LOCALIDADNOMBREFILTERCONTAINER","Class")',ctrl:"LOCALIDADNOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("LOCALIDADNOMBREFILTERCONTAINER","Class")',ctrl:"LOCALIDADNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADNOMBRE","Visible")',ctrl:"vCLOCALIDADNOMBRE",prop:"Visible"}]];this.EvtParms["LBLLOCALIDADCAPACIDADFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("LOCALIDADCAPACIDADFILTERCONTAINER","Class")',ctrl:"LOCALIDADCAPACIDADFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("LOCALIDADCAPACIDADFILTERCONTAINER","Class")',ctrl:"LOCALIDADCAPACIDADFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADCAPACIDAD","Visible")',ctrl:"vCLOCALIDADCAPACIDAD",prop:"Visible"}]];this.EvtParms["LBLLOCALIDADPRECIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("LOCALIDADPRECIOFILTERCONTAINER","Class")',ctrl:"LOCALIDADPRECIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("LOCALIDADPRECIOFILTERCONTAINER","Class")',ctrl:"LOCALIDADPRECIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADPRECIO","Visible")',ctrl:"vCLOCALIDADPRECIO",prop:"Visible"}]];this.EvtParms["LBLLOCALIDADESVENDIDASFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("LOCALIDADESVENDIDASFILTERCONTAINER","Class")',ctrl:"LOCALIDADESVENDIDASFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("LOCALIDADESVENDIDASFILTERCONTAINER","Class")',ctrl:"LOCALIDADESVENDIDASFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADESVENDIDAS","Visible")',ctrl:"vCLOCALIDADESVENDIDAS",prop:"Visible"}]];this.EvtParms["LBLLOCALIDADESDISPONIBLESFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("LOCALIDADESDISPONIBLESFILTERCONTAINER","Class")',ctrl:"LOCALIDADESDISPONIBLESFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("LOCALIDADESDISPONIBLESFILTERCONTAINER","Class")',ctrl:"LOCALIDADESDISPONIBLESFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCLOCALIDADESDISPONIBLES","Visible")',ctrl:"vCLOCALIDADESDISPONIBLES",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A11LocalidadId",fld:"LOCALIDADID",pic:"ZZZ9",hsh:!0}],[{av:"AV8pLocalidadId",fld:"vPLOCALIDADID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cLocalidadId",fld:"vCLOCALIDADID",pic:"ZZZ9"},{av:"AV10cLocalidadNombre",fld:"vCLOCALIDADNOMBRE",pic:""},{av:"AV11cLocalidadCapacidad",fld:"vCLOCALIDADCAPACIDAD",pic:"ZZZZ9"},{av:"AV12cLocalidadPrecio",fld:"vCLOCALIDADPRECIO",pic:"ZZZZZ9.99"},{av:"AV13cLocalidadesVendidas",fld:"vCLOCALIDADESVENDIDAS",pic:"ZZZZ9"},{av:"AV14cLocalidadesDisponibles",fld:"vCLOCALIDADESDISPONIBLES",pic:"ZZZZ9"},{av:"AV7pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cLocalidadId",fld:"vCLOCALIDADID",pic:"ZZZ9"},{av:"AV10cLocalidadNombre",fld:"vCLOCALIDADNOMBRE",pic:""},{av:"AV11cLocalidadCapacidad",fld:"vCLOCALIDADCAPACIDAD",pic:"ZZZZ9"},{av:"AV12cLocalidadPrecio",fld:"vCLOCALIDADPRECIO",pic:"ZZZZZ9.99"},{av:"AV13cLocalidadesVendidas",fld:"vCLOCALIDADESVENDIDAS",pic:"ZZZZ9"},{av:"AV14cLocalidadesDisponibles",fld:"vCLOCALIDADESDISPONIBLES",pic:"ZZZZ9"},{av:"AV7pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cLocalidadId",fld:"vCLOCALIDADID",pic:"ZZZ9"},{av:"AV10cLocalidadNombre",fld:"vCLOCALIDADNOMBRE",pic:""},{av:"AV11cLocalidadCapacidad",fld:"vCLOCALIDADCAPACIDAD",pic:"ZZZZ9"},{av:"AV12cLocalidadPrecio",fld:"vCLOCALIDADPRECIO",pic:"ZZZZZ9.99"},{av:"AV13cLocalidadesVendidas",fld:"vCLOCALIDADESVENDIDAS",pic:"ZZZZ9"},{av:"AV14cLocalidadesDisponibles",fld:"vCLOCALIDADESDISPONIBLES",pic:"ZZZZ9"},{av:"AV7pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cLocalidadId",fld:"vCLOCALIDADID",pic:"ZZZ9"},{av:"AV10cLocalidadNombre",fld:"vCLOCALIDADNOMBRE",pic:""},{av:"AV11cLocalidadCapacidad",fld:"vCLOCALIDADCAPACIDAD",pic:"ZZZZ9"},{av:"AV12cLocalidadPrecio",fld:"vCLOCALIDADPRECIO",pic:"ZZZZZ9.99"},{av:"AV13cLocalidadesVendidas",fld:"vCLOCALIDADESVENDIDAS",pic:"ZZZZ9"},{av:"AV14cLocalidadesDisponibles",fld:"vCLOCALIDADESDISPONIBLES",pic:"ZZZZ9"},{av:"AV7pEspectaculoId",fld:"vPESPECTACULOID",pic:"ZZZ9"}],[]];this.setVCMap("AV7pEspectaculoId","vPESPECTACULOID",0,"int",4,0);this.setVCMap("AV8pLocalidadId","vPLOCALIDADID",0,"int",4,0);this.setVCMap("AV7pEspectaculoId","vPESPECTACULOID",0,"int",4,0);this.setVCMap("AV7pEspectaculoId","vPESPECTACULOID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);t.addRefreshingVar({rfrVar:"AV7pEspectaculoId"});t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[36]);t.addRefreshingParm(this.GXValidFnc[46]);t.addRefreshingParm(this.GXValidFnc[56]);t.addRefreshingParm(this.GXValidFnc[66]);t.addRefreshingParm({rfrVar:"AV7pEspectaculoId"});this.Initialize()});gx.wi(function(){gx.createParentObj(gx00e1)})