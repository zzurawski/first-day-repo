
//Owner Questions and Answers
string[] commonOwnerQs = {
    "What is the name of the property owner?", "What is the street address of the property owner?", 
    "What is the city of the property owner?", "What is the state of the property owner?", "What is the zip code of the property owner?", "What is the phone number of the owner?"
};

commonOwnerQs[0] = "Anup Garg";


//Building location Questions and Answers
string[] commonLocaQs = {
    "What is the street address of the property?", "What is the city the property is located in?", "What state is the property located in?", "What is the zip code of the property?"
};

Console.WriteLine(commonLocaQs[0]);
string streetLoca = Console.ReadLine();

Console.WriteLine(commonLocaQs[1]);
string cityLoca = Console.ReadLine();

Console.WriteLine(commonLocaQs[2]);
string stateLoca = Console.ReadLine();

Console.WriteLine(commonLocaQs[3]);
string zipLoca = Convert.ToInt32(Console.ReadLine());


//Contractor Questions and Answers
string[] commonContractorQs = {
    "What is the name of the contractor?", "What is the street address of the contractor?", "What is the city of the conractor?",
    "What is the state for the contractor", "What is the zip code of the contractor?",
    "What is the license number of the contractor", "What is the expiration for the license?", "What is the contractors phone number?"
};

Console.WriteLine(commonContractorQs[0]);
string nameContractor = Console.ReadLine();

Console.WriteLine(commonContractorQs[1]);
string streetContractor = Console.ReadLine();

Console.WriteLine(commonContractorQs[2]);
string cityContractor = Console.ReadLine();

Console.WriteLine(commonContractorQs[3]);
string stateContractor = Console.ReadLine();

Console.WriteLine(commonContractorQs[4]);
string zipContractor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(commonContractorQs[5]);
string licenseContractor = Console.ReadLine();

Console.WriteLine(commonContractorQs[6]);
string expContractor = Console.ReadLine();

Console.WriteLine(commonContractorQs[7]);
string phoneContractor = Console.ReadLine();


//CER Risk Assessor Questions and Answers
string[] clearanceExamReportRiskAssessorQs = {
    "What is the Risk Assessor's name?", "What is the Risk Assessor License number?", "What is the expiration of the Risk Assesor License?",
    "What is the Risk Assessor employer street address?", "What city is the Risk Assessor located in?", "What state is the Risk Assessor located in?",
    "What is the zip code for the Risk Assessor?", "What is the company of the Risk Assessor?", "What is the telephone for the Risk Assessor's company?"
};

Console.WriteLine(clearanceExamReportRiskAssessorQs[0]);
string riskAssessorName = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[1]);
string riskAssessorLicense = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[2]);
string riskAssessorEXP = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[3]);
string riskAssessorStreet = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[4]);
string riskAssessorCity = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[5]);
string riskAssessorState = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[6]);
string riskAssessorZip = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[7]);
string riskAssessorCompany = Console.ReadLine();

Console.WriteLine(clearanceExamReportRiskAssessorQs[8]);
string riskAssessorPhone = Console.ReadLine();



bool[] clearanceExamReportRequiringQs = {
    "lead abatement", "lead hazard control order", "essential maintenance practices", "lead safe renovation", "interim controls", "paint stabilization"
};

Console.WriteLine("Activity conducted requiring clearance involve: " + clearanceExamReportRequiringQs[])
bool leadAbatement = GetInput(inputType);
if (leadAbatement.ToLower() == "yes")
{
  value = true;
}
else
{
  value = false;
}



bool[] clearanceExamReportPerformed = {
    "visual assessment", "dust sample collection", "soil sample collection", "water sample collection"
};

//CER Dates
string[] clearanceExamReportDates = {
    "Start date of lead hazard control", "Completion date of lead hazard control",
};

Console.WriteLine(clearanceExamReportDates[0]);
string startDateCER = Console.ReadLine();

Console.WriteLine(clearanceExamReportDates[1]);
string endDateCER = Console.ReadLine();


//any forms??
bool[] clearanceExamReportForms = {
    "Is there a form describing the lead hazard work attached?", "Are lab results attached?",
    "Is there a diagram of the floor plans attached?", "Is the Visual Assessment Form attached?"
};


//Hazards identified on CER
string[] clearanceExamReportHazardsA = {
    "Yes", "No", "N/A"
};

Console.WriteLine("Were all hazards identified? (Input yes, no, or anything else for N/A)");
string hazardsIdentified = Console.ReadLine();

if (hazardsIdentified == "yes") {
    hazardsIdentified = clearanceExamReportHazardsA[0];
} else if (hazardsIdentified == "no") {
    hazardsIdentified = clearanceExamReportHazardsA[1];
} else {
    hazardsIdentified = clearanceExamReportHazardsA[2];
};


//Did you pass the clearance Exam
string[] clearanceExamReportResults = {
    "Pass", "Fail", "Repeat"
};

Console.WriteLine("Did you pass, fail or repeat the clearance examination? (input P, F, or R)");
string resultsCER = Console.ReadLine();

if (!resultsCER.Equals("P")) {
    resultsCER = clearanceExamReportResults[0];
} else if (resultsCER.Equals("F")) {
    resultsCER = clearanceExamReportResults[1];
} else {
    resultsCER = clearanceExamReportResults[2];
}




