using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class partsInformation : MonoBehaviour
{
    public string buttonName;
    public GameObject board;
    public TextMesh newText;
    int counter;
    public void start()
    {
        Debug.Log(buttonName);
        panelVisible();
    }
    public void panelVisible(){
        setText();
    }
    public void panelNotVisible(){
        board.gameObject.SetActive(false);
        setNull();
    }
    public void setText(){
        string textMessage = "";
        if(buttonName == "spinnerBtn"){
            textMessage = "Spinner\n\nStreamlined fairing fitted over a propeller\nhub or at the centre of a turbofan engine.";
        }
        else if(buttonName == "fanbladeBtn"){
            textMessage = "Fan Blade\n\nThe fan blades spin to accelerate a mass\nof air into the engine to generate thrust \nthat propels the aircraft forward.";
        }
        else if(buttonName == "fancaseBtn"){
            textMessage = "Fan Case\n\nFan cases are essential to a plane's safe\n operation. The casing has to be strong \nenough to absorb the energy of a blade failure\n and prevent debris from penetrating its material.";
        }
        else if(buttonName == "corecaseBtn"){
            textMessage = "Core Case\n\nThe core consists of high and low pressure,\n multistage compressors, a combustor section\n and high and low pressure, multistage \nturbine units.";
        }
        else if(buttonName == "stationaryvBtn"){
            textMessage = "Stationary Veins\n\nServe to convert this rotational energy\n into static pressure through the change in flow,\nplaying a vital role in the operation and\nefficiency of the entire asset.";
        }
        else if(buttonName == "routerbBtn"){
            textMessage = "Roter Blades\n\nThese blades impel air rearward in the same\nway a propeller does. They are basically small airfoils.\nThe rotor turns at a high speed and impels the\nair through a series of stages.";
        }
        else if(buttonName == "highcBtn"){
            textMessage = "High Pressure Compressor\n\nWhat sets an advanced turbofan engine apart\nis that the blades and disk are manufactured as a\nsingle part—known as a “blisk.” These high-tech\ncomponents not only save space and weigh less than\nconventional rotors with individual blades, but\nthey also provide for better blade aerodynamics.";
        }
        else if(buttonName == "lowcBtn"){
            textMessage = "Low Pressure Compressor\n\nThe front section of a dual-spool compressor,\nalso called an N1 compressor or a low-speed compressor.\nIt is driven by the last stage of a turbine.\nThe high-pressure compressor is called an\nN2 compressor.";
        }
        else if(buttonName == "lowtBtn"){
            textMessage = "Low Pressure Turbine\n\nThe low-pressure turbine drives the low-pressure\n compressor and the fan that in turn generates the\n bulk of the thrust.";
        }
        else if(buttonName == "hightBtn"){
            textMessage = "High Pressure Turbine\n\nIn a turbine, the energy contained in the gas flow\nemerging at high pressure and temperature from the\ncombustor is converted into mechanical energy.";
        }
        else if(buttonName == "shaftBtn"){
            textMessage = "Shaft\n\nconnects the turbine to the compressor, and runs\nmost of the length of the engine.";
        }
        else if(buttonName == "exhaustcBtn"){
            textMessage = "Exhaust Cone\n\nto collect and direct discharge gases from\nthe turbine wheel.";
        }
        else if(buttonName == "fueliBtn"){
            textMessage = "Fuel Injector\n\nA fuel injector for a gas turbine engine consists of\na hollow body adapted to be supplied with compressed\nair and having a number of fuel orifices in the\nnternal surface of the body.";
        }
        else if(buttonName == "igniterpBtn"){
            textMessage = "Igniter Plug\n\nThe igniter plug of a turbine engine ignition system\ndiffers considerably from the spark plug of a\nreciprocating engine ignition system. ";
        }
        else if(buttonName == "combustorcBtn"){
            textMessage = "Combustion Chamber\n\nA Combustion Chamber is the area within the Cylinder\nwhere the fuel/air mix is ignited. As the Piston\ncompresses the fuel/air mix and makes contact with\nthe Spark Plug, the mixture is combusted and\npushed out of the Combustion Chamber in the\nform of energy.";
        }
        else if(buttonName == "inletBtn"){
            textMessage = "Inlet\n\nThe inlet is a duct which is required to ensure\nsmooth airflow into the engine despite air approaching\nthe inlet from directions other than straight ahead.\nThis occurs on the ground from cross winds and in\nflight with aircraft pitch and yaw motions.";
        }
        else if(buttonName == "propellerBtn"){
            textMessage = "Propeller\n\nThe purpose of the propeller is to provide a method\nof propulsion so the aircraft is able to move forward\nthrough the air. The propeller itself consists of two\nor more blades connected together by a central\nhub that attaches the blades to the engine shaft.";
        }
        else if(buttonName == "gearboxBtn"){
            textMessage = "Gearbox\n\nThe speed reduction gearbox is a type of transmission\nsystem used in turboprop engines. It's used to lower\nthe engine's revolutions per minute (RPM). Turboprop engines\nturn propellers by outputting RPM. The higher the RPM output,\nthe faster the propellers will turn.";
        }
        else if(buttonName == "fuelnozzleBtn"){
            textMessage = "Fuel Nozzle\n\nThere are two types of fuel nozzles in the aircraft\nfuel system of PT6 engines. Simplex fuel nozzles have a primary\nand secondary nozzle with a single orifice. Duplex fuel\nnozzles have two passages and two concentric points in the\ntip that spray fuel.";
        }
        else if(buttonName == "stageccBtn"){
            textMessage = "Centrifugal Compressor\n\nCentrifugal compressor imparts kinetic energy into\nthe airstream by increasing the velocity of the air\nusing a rotating element and then converts this kinetic\nenergy into potential energy in the form of\npressure.";
        }
        else if(buttonName == "turbineBtn"){
            textMessage = "Turbine\n\nTurbines are used in wind power, hydropower, in heat engines,\nand for propulsion. Turbines are extremely important\nbecause of the fact that nearly all electricity is produced\nby turning mechanical energy from a turbine\ninto electrical energy via a generator.";
        }
        else if(buttonName == "exhaustBtn"){
            textMessage = "Exhausy\n\nAircraft exhaust systems carry out two significant functions.\nFirst, they help in venting exhaust gases away from the fuselage\nand engine while decreasing noise. Second, they also indirectly\nsupply carburetor and cabin heat.";
        }
        else if(buttonName == "compressorBtn"){
            textMessage = "Compressor\n\nThe compressor section of the gas turbine engine has many\nfunctions.Its primary function is to supply air in sufficient\nquantity to satisfy the requirements of the combustion burners.\nA secondary function of the compressor is to supply bleed-air\nfor various purposes in the engine and aircraft.";
        }
        newText.GetComponent<TextMesh>().text = textMessage;
    }
    public void setNull(){
        newText.text = "";
    }
    public void btnClick(){
        counter++;
        if(counter%2==1){
            board.gameObject.SetActive(true);
        }
        else{
            board.gameObject.SetActive(false);
        }
    }
}
