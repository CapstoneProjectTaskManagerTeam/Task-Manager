﻿<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="MPMServerSide" generation="1" functional="0" release="0" Id="1435befe-60fd-41c6-afe3-0e8502f83310" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="MPMServerSideGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="WCFServices:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/MPMServerSide/MPMServerSideGroup/LB:WCFServices:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="WCFServices:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/MPMServerSide/MPMServerSideGroup/MapWCFServices:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WCFServicesInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/MPMServerSide/MPMServerSideGroup/MapWCFServicesInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:WCFServices:Endpoint1">
          <toPorts>
            <inPortMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServices/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapWCFServices:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServices/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWCFServicesInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServicesInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="WCFServices" generation="1" functional="0" release="0" software="F:\KhanhVD\Source Code\MPMServerSide\MPMServerSide\csx\Release\roles\WCFServices" entryPoint="base\x86\WaHostBootstrapper.exe" parameters="base\x86\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WCFServices&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;WCFServices&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="WCFServices.svclog" defaultAmount="[1000,1000,1000]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServicesInstances" />
            <sCSPolicyUpdateDomainMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServicesUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServicesFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WCFServicesUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WCFServicesFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WCFServicesInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="b2b12c06-31f3-4027-b019-b121a41cca28" ref="Microsoft.RedDog.Contract\ServiceContract\MPMServerSideContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="3413ea3b-34f7-4aea-b1c6-d9eb55bf9022" ref="Microsoft.RedDog.Contract\Interface\WCFServices:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/MPMServerSide/MPMServerSideGroup/WCFServices:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>