using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsigurariDeViataSiBunuri
{
    public partial class Adelurance_System : Form
    {
        string connectionName;
        Client c;
        Insurance i;
        List<Insurance> insurances = new List<Insurance>();
        bool auto = false;
        bool house = false;
        bool health = false;
        bool life = false;
        bool travel = false;
        bool accidents = false;
        int age;

        public Adelurance_System(Client c)
        {
            InitializeComponent();
            this.c = c;
            tbName.Text = c.FamilyName + " " + c.GivenName;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lbCounty.Visible = false;
            lbStreet.Visible = false;
            lbPostalCode.Visible = false;
            lbStartDuration.Visible = false;
            lbTown.Visible = false;
            lbValidityPeriod.Visible = false;
            btnCalculateOffer.Visible = false;
            tbCounty.Visible = false;
            tbTown.Visible = false;
            tbStreet.Visible = false;
            tbPostalCode.Visible = false;
            dateStartDuration.Visible = false;
            cbValidityPeriod.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            pbLogo.Visible = false;
            dateOfDeparture.Visible = false;
            dateOfReturning.Visible = false;
            cbType.Visible = false;
            cbValidityPeriod.Items.Add("3");
            cbValidityPeriod.Items.Add("6");
            cbValidityPeriod.Items.Add("9");
            cbValidityPeriod.Items.Add("12");
            cbValidityPeriod.Items.Add("24");
            cbValidityPeriod.Items.Add("36");
            lbDeclaration.Visible = false;
            cbTypeH.Visible = false;
            cbFieldH.Visible = false;
            cbFieldH.Items.Add("Specialist doctors");
            cbFieldH.Items.Add("Dentistry");
            cbFieldH.Items.Add("Pharmacy");
            cbFieldH.Items.Add("Family doctor");
            connectionName = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DB.accdb";
        }

        private void rbEng_CheckedChanged(object sender, EventArgs e)
        {
            lbDeclaration.Text = "Click here to download the self-statement";
            lbTitle.Text = "INSURANCES";
            btnAuto.Text = "Auto";
            btnHouse.Text = "House";
            btnHealth.Text = "Health";
            btnLife.Text = "Life";
            btnTravel.Text = "Travel";
            btnAccidents.Text = "Accidents";
            tabChr.Text = "Characteristics";
            tabAdv.Text = "Advantages";
            tabDoc.Text = "Documents";
            tabOffer.Text = "Offer";
            btnCalculateOffer.Text = "Calculate insurance";
            lbCounty.Text = "County";
            lbTown.Text = "Town";
            lbStreet.Text = "Street and street number";
            lbPostalCode.Text = "Postal code";
            lbStartDuration.Text = "Start duration of insurance";
            lbValidityPeriod.Text = "Validity period";
            if(auto == true)
            {
                btnAuto.PerformClick();
            }
            else if(house == true)
            {
                btnHouse.PerformClick();
            }
            else if (health == true)
            {
                btnHealth.PerformClick();
            }
            else if (life == true)
            {
                btnLife.PerformClick();
            }
            else if (travel == true)
            {
                btnTravel.PerformClick();
            }
            else if (accidents == true)
            {
                btnAccidents.PerformClick();
            }
        }

        private void rbRom_CheckedChanged(object sender, EventArgs e)
        {
            lbDeclaration.Text = "Click aici pentru a descarca declaratia pe propria-raspundere";
            lbTitle.Text = "ASIGURARI";
            btnAuto.Text = "Auto";
            btnHouse.Text = "Casa";
            btnHealth.Text = "Sanatate";
            btnLife.Text = "Viata";
            btnTravel.Text = "Calatorie";
            btnAccidents.Text = "Accidente";
            tabChr.Text = "Caracteristici";
            tabAdv.Text = "Avantage";
            tabDoc.Text = "Documente";
            tabOffer.Text = "Oferta";
            btnCalculateOffer.Text = "Calculare asigurare";
            lbCounty.Text = "Judet";
            lbTown.Text = "Localitate";
            lbStreet.Text = "Strada si numarul";
            lbPostalCode.Text = "Cod postal";
            lbStartDuration.Text = "Durata de incepere a asigurarii";
            lbValidityPeriod.Text = "Perioada de valabilitate";
            if (auto == true)
            {
                btnAuto.PerformClick();
            }
            else if (house == true)
            {
                btnHouse.PerformClick();
            }
            else if (health == true)
            {
                btnHealth.PerformClick();
            }
            else if (life == true)
            {
                btnLife.PerformClick();
            }
            else if (travel == true)
            {
                btnTravel.PerformClick();
            }
            else if (accidents == true)
            {
                btnAccidents.PerformClick();
            }
        }

        private void makeLabelsAndTextboxVisible()
        {
            if(auto == false && house == false && health == false
                && life == false && travel == false && accidents == false)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lbCounty.Visible = true;
                lbStreet.Visible = true;
                lbPostalCode.Visible = true;
                lbStartDuration.Visible = true;
                lbTown.Visible = true;
                lbValidityPeriod.Visible = true;
                btnCalculateOffer.Visible = true;
                tbCounty.Visible = true;
                tbTown.Visible = true;
                tbStreet.Visible = true;
                tbPostalCode.Visible = true;
                dateStartDuration.Visible = true;
                cbValidityPeriod.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                cbType.Visible = false;
                dateOfDeparture.Visible = false;
                dateOfReturning.Visible = false;
                lbDeclaration.Visible = false;
                cbTypeH.Visible = false;
                cbFieldH.Visible = false;
            }
        }

        private void leftSideVisible()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            pbLogo.Visible = false;
            dateOfDeparture.Visible = false;
            dateOfReturning.Visible = false;
            cbType.Visible = false;
            lbDeclaration.Visible = false;
            cbTypeH.Visible = false;
            cbFieldH.Visible = false;
        }

        private void leftSideInvisible()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            pbLogo.Visible = true;
            dateOfDeparture.Visible = false;
            dateOfReturning.Visible = false;
            cbType.Visible = false;
            lbDeclaration.Visible = false;
            cbTypeH.Visible = false;
            cbFieldH.Visible = false;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            makeLabelsAndTextboxVisible();
            leftSideVisible();
            cbType.Visible = true;
            textBox6.Visible = false;
            auto = true;
            house = false;
            health = false;
            life = false;
            travel = false;
            accidents = false;
            if(rbEng.Checked)
            {
                cbType.Items.Clear();
                cbType.Items.Add("Manual");
                cbType.Items.Add("Automatic");
                cbFieldH.Items.Clear();
                cbFieldH.Items.Add("Specialist doctors");
                cbFieldH.Items.Add("Dentistry");
                cbFieldH.Items.Add("Pharmacy");
                cbFieldH.Items.Add("Family doctor");
                cbTypeH.Items.Clear();
                //Chr
                lbTabChr.Text = "CASCO PERFECTO protects you in the next situations:" + Environment.NewLine;
                lbTabChr.Text += "✓ Driving by other drivers;" + Environment.NewLine;
                lbTabChr.Text += "✓ Exchange vehicle;" + Environment.NewLine;
                lbTabChr.Text += "✓ Extended roadsisde assistance;" + Environment.NewLine;
                lbTabChr.Text += "✓ Damage to person;" + Environment.NewLine;
                lbTabChr.Text += "✓ Coverage of damage caused exclusively to rims and tires;" + Environment.NewLine;
                lbTabChr.Text += "✓ Coverage of engine water damage;" + Environment.NewLine;
                lbTabChr.Text += "✓ Coverage of damage caused outside public roads." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "If you want to be convinced that CASCO Perfecto insurance is exactly what you need, here are the benefits included:" + Environment.NewLine;
                lbTabAdv.Text += "○ Dedicated phone number - you can call it non-stop, in case of an accident, and an operator will help you with all the information you need;" + Environment.NewLine;
                lbTabAdv.Text += "○ Car exchange during the repair - if your car is immovable, we offer you a spare one for a maximum period of 10 days;" + Environment.NewLine;
                lbTabAdv.Text += "○ Finding damage within 24 hours for accidents in Romania - if the accident is reported during the working days, the inspector will come to the place established with you, depending on your schedule;" + Environment.NewLine;
                lbTabAdv.Text += "○ Don't wait for payment - in case of damage, your car will be repaired with original parts, without having to wait for payment;" + Environment.NewLine;
                lbTabAdv.Text += "○ Reimbursement of expenses directly with the car service - and the car will be repaired to you in the shortest time;" + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Necessary documents:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Risk inspection" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Step 1: The car is photographed from 4 angles;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Step 2: Photograph of the identification number / chassis series;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Step 3: Photograph of the dashboard of the car, indicating the number of KM traveled;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Step 4: Each wheel of the car is photographed individually;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Step 5: Pre-existing damage is photographed;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Step 6: In case you benefited from a compensation, take pictures of the repaired parts." + Environment.NewLine;
                lbTabDoc.Text += "∇ License copy" + Environment.NewLine;
                lbTabDoc.Text += "∇ ID card copy" + Environment.NewLine;
                lbTabDoc.Text += "∇ Car heel copy" + Environment.NewLine;
                //Offer
                label1.Text = "Registration Number";
                label2.Text = "Chassis Series";
                label3.Text = "Brand";
                label4.Text = "Model";
                label5.Text = "Year of manufacture";
                label6.Text = "Type";
            }
            else
            {
                cbType.Items.Clear();
                cbType.Items.Add("Manuala");
                cbType.Items.Add("Automata");
                cbFieldH.Items.Clear();
                cbFieldH.Items.Add("Medici specialisti");
                cbFieldH.Items.Add("Stomatologie");
                cbFieldH.Items.Add("Farmacie");
                cbFieldH.Items.Add("Medici de familie");
                cbTypeH.Items.Clear();
                //Chr
                lbTabChr.Text = "CASCO PERFECTO te protejeaza in urmatoarele situatii:" + Environment.NewLine;
                lbTabChr.Text += "✓ Conducerea de catre alti soferi;" + Environment.NewLine;
                lbTabChr.Text += "✓ Autoturism la schimb;" + Environment.NewLine;
                lbTabChr.Text += "✓ Asistenta rutiera extinsa;" + Environment.NewLine;
                lbTabChr.Text += "✓ Personal injuries;" + Environment.NewLine;
                lbTabChr.Text += "✓ Acoperirea daunelor produse exclusiv jantelor si anvelopelor;" + Environment.NewLine;
                lbTabChr.Text += "✓ Acoperirea daunelor produse de aspirarea apei la motor;" + Environment.NewLine;
                lbTabChr.Text += "✓ Acoperirea daunelor produse in afara drumurilor publice." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "Daca vrei sa te convingi ca asigurarea CASCO Perfecto este exact ceea ce ai nevoie, iata in continuare avantajele incluse:" + Environment.NewLine;
                lbTabAdv.Text += "○ Numar de telefon dedicat – il poti apela non-stop, in caz de accident, iar un operator te va ajuta cu toate informatiile de care ai nevoie;" + Environment.NewLine;
                lbTabAdv.Text += "○ Autoturism la schimb pe durata reparatiei – daca masina ta este nedeplasabila, iti oferim una la schimb pentru o perioada de maxim 10 zile;" + Environment.NewLine;
                lbTabAdv.Text += "○ Constatarea daunei in maxim 24 h pentru accidente pe teritoriul Romaniei – daca accidentul este sesizat in cursul zilelor lucratoare, inspectorul va veni la locul stabilit impreuna cu tine, in functie de programul tau;" + Environment.NewLine;
                lbTabAdv.Text += "○ Nu astepti acceptul de plata – in caz de dauna, masina ta va fi reparata cu piese originale, fara sa fie nevoie sa astepti acceptul de plata;" + Environment.NewLine;
                lbTabAdv.Text += "○ Decontarea cheltuielilor direct cu service-ul auto – iar masina va ajunge reparata la tine in cel mai scurt timp;" + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documente necesare:" + Environment.NewLine;
                lbTabDoc.Text += "Inspecție de risc" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Pasul 1: Se fotografiază mașina din cele 4 unghiuri;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Pasul 2: Se fotografiază numărul de identificare / serie șasiu; " + Environment.NewLine;
                lbTabDoc.Text += "\t➖Pasul 3: Se fotografiază bordul mașinii, indicând numărul de KM parcurși; " + Environment.NewLine;
                lbTabDoc.Text += "\t➖Pasul 4: Se fotografiază fiecare roată a mașinii, individual;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Pasul 5: Se fotografiază avariile preexistente;" + Environment.NewLine;
                lbTabDoc.Text += "\t➖Pasul 6: În cazul în care ați beneficiat de o despăgubire în regie proprie, se fotografiază reperele reparate." + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa permis" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa buletin" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa talonul masinii" + Environment.NewLine;
                //Offer
                label1.Text = "Numar de inmatriculare";
                label2.Text = "Serie de sasiu";
                label3.Text = "Marca";
                label4.Text = "Model";
                label5.Text = "An fabricatie";
                label6.Text = "Tip";
            }
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            makeLabelsAndTextboxVisible();
            leftSideVisible();
            auto = false;
            house = true;
            health = false;
            life = false;
            travel = false;
            accidents = false;
            if (rbEng.Checked)
            {
                //Chr
                lbTabChr.Text = "Whether you live in a block of flats or at home, with this insurance, you benefit from a complete package of insured risks such as:" + Environment.NewLine;
                lbTabChr.Text += "✓ Fire, lightning, explosion;" + Environment.NewLine;
                lbTabChr.Text += "✓ Falling of aircrafts;" + Environment.NewLine;
                lbTabChr.Text += "✓ Hitting third-party road vehicles;" + Environment.NewLine;
                lbTabChr.Text += "✓ Smoke, gas, vapors (accidental);" + Environment.NewLine;
                lbTabChr.Text += "✓ Demolition and debris removal costs;" + Environment.NewLine;
                lbTabChr.Text += "✓ Natural disasters: earthquakes, floods, alluvium, atmospheric phenomena, including hail, landslides, landslides, landslides, heavy snowfall." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ Insurance is deductible - except for the earthquake, in risk areas;" + Environment.NewLine;
                lbTabAdv.Text += "○ No maximum compensation limit - for the risks of theft, robbery or damage to water installations;" + Environment.NewLine;
                lbTabAdv.Text += "○ Quick compensation - in case of damage;" + Environment.NewLine;
                lbTabAdv.Text += "○ Quick fixes - Complete Plus gives you the confidence that you will recover your losses quickly and protect you against any risk." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documents required:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copy of ID card" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copy of title deed or, as appropriate, certificate of inheritance or succession" + Environment.NewLine;
                //Offer
                label1.Text = "Construction type";
                label2.Text = "Structure";
                label3.Text = "Environment";
                label4.Text = "Construction year";
                label5.Text = "Surface";
                label6.Text = "Number of rooms";
            }
            else
            {
                //Chr
                lbTabChr.Text = "Fie că stai la bloc sau la casă, prin aceasta asigurare, beneficiezi de un pachet complet de riscuri asigurate precum:" + Environment.NewLine;
                lbTabChr.Text += "✓ Incendiu, trasnet, explozie;" + Environment.NewLine;
                lbTabChr.Text += "✓ Caderea aparatelor de zbor;" + Environment.NewLine;
                lbTabChr.Text += "✓ Lovirea de catre autovehicule rutiere ale tertilor;" + Environment.NewLine;
                lbTabChr.Text += "✓ Fum, gaz, vapori (din eveniment accidental);" + Environment.NewLine;
                lbTabChr.Text += "✓ Costuri de demolare si indepartare a resturilor;" + Environment.NewLine;
                lbTabChr.Text += "✓ Calamitati naturale: cutremur, inundatii, aluviuni, fenomene atmosferice, inclusiv grindina, prabusirea, alunecarea, surparea terenului, greutatea stratului de zapada." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ Asigurarea este fara fransiza – cu exceptia cutremurului, in zonele de risc;" + Environment.NewLine;
                lbTabAdv.Text += "○ Fara limita maxima de despagubire – pentru riscurile de furt, talharie sau avarii la instalatiile de apa;" + Environment.NewLine;
                lbTabAdv.Text += "○ Despagubire rapida – in cazul producerii unor daune;" + Environment.NewLine;
                lbTabAdv.Text += "○ Solutii rapide – Completa Plus iti ofera siguranta ca iti vei recupera repede pierderile si te protejeaza impotriva oricarui risc." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documente necesare:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa buletin" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa actul de proprietate sau, dupa caz, certificatul de mostenitor sau de succesiune" + Environment.NewLine;
                //Offer
                label1.Text = "Tip constructie";
                label2.Text = "Structura";
                label3.Text = "Mediul";
                label4.Text = "An constructie";
                label5.Text = "Suprafata";
                label6.Text = "Numar camere";
            }
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            makeLabelsAndTextboxVisible();
            leftSideVisible();
            cbTypeH.Visible = true;
            cbFieldH.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            auto = false;
            house = false;
            health = true;
            life = false;
            travel = false;
            accidents = false;
            if (rbEng.Checked)
            {
                //Chr
                lbTabChr.Text = "Generali PROTECT is a private health insurance that provides you with quality medical services when you need them." + Environment.NewLine;
                lbTabChr.Text += "✓ Starting with 50 lei / month, you choose the coverage you want to benefit from" + Environment.NewLine;
                lbTabChr.Text += "✓ You have hospitalization and surgery in both state and private hospitals." + Environment.NewLine;
                lbTabChr.Text += "✓ Get rid of your daily expenses because of the fixed amount you get if you need hospitalization or surgery at a state hospital." + Environment.NewLine;
                lbTabChr.Text += "✓ You benefit from a second medical opinion obtained from specialists in the European Union, if you are diagnosed with a serious illness." + Environment.NewLine;
                lbTabChr.Text += "✓ You have coverage for 40 serious illnesses, from heart attack, cancer, stroke, to respiratory failure and Alzheimer's." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ You have a prevention package in the SanoPass platform, which gives you access to the services of over 1000 clinics in the country." + Environment.NewLine;
                lbTabAdv.Text += "○ You have direct settlement - so we take care of the whole settlement process with the medical partners in the network approved by Generali, or you can take care of this process yourself after you make all the payments for the medical services you need , to the providers of medical services that are not part of the network approved by Generali. " + Environment.NewLine;
                lbTabAdv.Text += "○ If you need post-hospital recovery services, you can pay for them as well." + Environment.NewLine;
                lbTabAdv.Text += "○ You can include loved ones in your chosen insurance package, whether it's a spouse, children or other family members." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documents required:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copy of ID" + Environment.NewLine;
                lbTabDoc.Text += "∇ Health Card" + Environment.NewLine;
                lbTabDoc.Text += "∇ Birth certificate for children up to 18 years old" + Environment.NewLine;
                lbTabDoc.Text += "∇ Certificate issued by the institutions subordinated to the Ministry of Internal Affairs for detained, arrested or detained persons who are in detention and pre-trial detention centers, foreigners in accommodation centers for return or expulsion, as well as those who they are victims of human trafficking, who are in the process of establishing their identity and are housed in specially arranged centers according to the law, which show that they are in this situation" + Environment.NewLine;
                lbTabDoc.Text += "∇ Medical recommendation";
                //Offer
                label1.Text = "Health card number";
                label2.Text = "Type of graduate studies";
                label3.Text = "Occupation";
                label4.Text = "Field of insurance";
                label5.Text = "Type of insurance";
                label6.Text = "Have you had one in the past?";
            }
            else
            {
                //Chr
                lbTabChr.Text = "Generali PROTECT este o asigurare privata de sanatate prin care beneficiezi de servicii medicale de calitate, la momentul cand ai nevoie." + Environment.NewLine;
                lbTabChr.Text += "✓ Incepand cu 50 de lei / luna, alegi acoperirile de care doresti sa beneficiezi" + Environment.NewLine;
                lbTabChr.Text += "✓ Ai spitalizare si interventii chirurgicale atat in spitale de stat cat si private." + Environment.NewLine;
                lbTabChr.Text += "✓ Scapi de grija cheltuielilor zilnice datorita sumei fixe de care beneficiezi daca ai nevoie de spitalizare sau de o interventie chirurgicala intr-un spital de stat." + Environment.NewLine;
                lbTabChr.Text += "✓ Beneficiezi de a 2-a opinie medicala obtinuta de la specialisti din Uniunea Europeana, in cazul in care esti diagnosticat cu o boala grava." + Environment.NewLine;
                lbTabChr.Text += "✓ Ai acoperire in cazul a 40 de boli grave, de la infarct, cancer, AVC, pana la insuficienta respiratorie si Alzheimer." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ Ai la dispozitie un pachet de preventie in platforma SanoPass, care iti ofera acces la serviciile a peste 1000 de clinici din tara." + Environment.NewLine;
                lbTabAdv.Text += "○ Ai decontare directa – deci noi ne ocupam de tot procesul de decontare cu partenerii medicali din reteaua agreata de Generali, sau poti sa te ocupi tu de acest proces dupa ce faci toate platile pentru serviciile medicale de care ai nevoie, la prestatorii de servicii medicale care nu fac parte din reteaua agreata de Generali." + Environment.NewLine;
                lbTabAdv.Text += "○ Daca ai nevoie de servicii de recuperare postspitalizare, poti sa le decontezi si pe acestea." + Environment.NewLine;
                lbTabAdv.Text += "○ Poti sa incluzi in pachetul de asigurare ales si pe cei dragi, fie ca este vorba despre sot / sotie, copii sau alti membri ai familiei." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documente necesare:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa actul de identitate" + Environment.NewLine;
                lbTabDoc.Text += "∇ Cardul de sanatate" + Environment.NewLine;
                lbTabDoc.Text += "∇ Certificat de nastere pentru copiii in varsta de pana la 18 ani" + Environment.NewLine;
                lbTabDoc.Text += "∇ Adeverinta eliberata de institutiile din subordinea Ministerului Afacerilor Interne pentru persoanele retinute, arestate sau detinute care se afla in centrele de retinere si arestare preventiva, strainii aflati in centrele de cazare in vederea returnarii ori expulzarii, precum si cei care sunt victime ale traficului de persoane, care se afla in timpul procedurilor necesare stabilirii identitatii si sunt cazati in centrele special amenajate potrivit legii, din care sa rezulte ca se afla in aceasta situatie" + Environment.NewLine;
                lbTabDoc.Text += "∇ Recomandare medicala";
                //Offer
                label1.Text = "Numar card de asigurare";
                label2.Text = "Tip studii absolvite";
                label3.Text = "Ocupatie";
                label4.Text = "Domeniul de activitate al asigurarii";
                label5.Text = "Tipul asigurarii";
                label6.Text = "Ati mai beneficiat in trecut?";
            }
        }

        private void btnLife_Click(object sender, EventArgs e)
        {
            makeLabelsAndTextboxVisible();
            leftSideInvisible();
            lbDeclaration.Visible = true;
            auto = false;
            house = false;
            health = false;
            life = true;
            travel = false;
            accidents = false;
            if (rbEng.Checked)
            {
                //Chr
                lbTabChr.Text = "Take your CLASIC PLUS, the insurance that offers protection in case of death due to any cause (accident or illness) and has the following characteristics:" + Environment.NewLine;
                lbTabChr.Text += "✓ The duration of the insurance can be between 1 and 30 years;" + Environment.NewLine;
                lbTabChr.Text += "✓ The maximum age of the insured upon entering the insurance is 70 years;" + Environment.NewLine;
                lbTabChr.Text += "✓ Accidental death;" + Environment.NewLine;
                lbTabChr.Text += "✓ Death in traffic accident;" + Environment.NewLine;
                lbTabChr.Text += "✓ Permanent disability due to accident or any other cause;" + Environment.NewLine;
                lbTabChr.Text += "✓ Serious illness;" + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "You can transfer credit insurance;" + Environment.NewLine;
                lbTabAdv.Text += "○ Covers can also be purchased in the form of Insurance Packages, in which case we will reward you with more free coverages for the entire duration of the contract" + Environment.NewLine;
                lbTabAdv.Text += "○ If the annual insurance premium is over 1500 lei, we grant you the free exemption clause from the payment of premiums in case of disability - more precisely, we take over the payment in your place until the end of the contract and you benefit further of all the coverings you wanted; " + Environment.NewLine;
                lbTabAdv.Text += "○ Your loyalty is rewarded: you receive free coverage every year and starting with the 6th year of insurance, you can choose free coverage yourself;" + Environment.NewLine;
                lbTabAdv.Text += "○ After the first 3 years of insurance, at each anniversary of the contract you can change the coverage, increase or decrease the insured amount / insurance premium according to your needs." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documents required:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Insurance Request" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copy to ID Card" + Environment.NewLine;
                //Offer
            }
            else
            {
                //Chr
                lbTabChr.Text = "Ia-ti CLASIC PLUS, asigurarea ce ofera protectie in cazul decesului din orice cauza (accident sau imbolnavire) si are urmatoarele caracteristici:" + Environment.NewLine;
                lbTabChr.Text += "✓ Durata asigurarii poate fi intre 1 si 30 de ani;" + Environment.NewLine;
                lbTabChr.Text += "✓ Varsta maxima a asiguratului la intrarea in asigurare este de 70 ani;" + Environment.NewLine;
                lbTabChr.Text += "✓ Deces din accident;" + Environment.NewLine;
                lbTabChr.Text += "✓ Deces din accident de circulatie;" + Environment.NewLine;
                lbTabChr.Text += "✓ Invaliditate permanenta din accident sau din orice cauza;" + Environment.NewLine;
                lbTabChr.Text += "✓ Boli grave;" + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "Poti cesiona asigurarea pentru obtinerea unui credit;" + Environment.NewLine;
                lbTabAdv.Text += "○ Acoperirile pot fi achizitionate si sub forma de Pachete de asigurare, caz in care te bonusam cu mai multe acoperiri gratuite pe intreaga perioada a contractului" + Environment.NewLine;
                lbTabAdv.Text += "○ Daca prima de asigurare anuala este peste 1500 lei, iti acordam gratuit clauza de Exonerare de la plata primelor in caz de invaliditate- mai precis, noi preluam plata in locul tau pana la finalul contractului iar tu beneficiezi mai departe de toate acoperirile pe care ti le-ai dorit;" + Environment.NewLine;
                lbTabAdv.Text += "○ Fidelitatea ta este resplatita: anual primesti acoperiri gratuite si incepand cu anul 6 de asigurare, poti sa-ti alegi singur acoperiri gratuite;" + Environment.NewLine;
                lbTabAdv.Text += "○ Dupa primii 3 ani de asigurare, la fiecare aniversare a contractului poti modifica acoperirile, creste sau scadea suma asigurata / prima de asigurare conform necesitatilor tale." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documente necesare:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Cerere de asigurare" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa cardul de identitate" + Environment.NewLine;
                //Offer
            }
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            makeLabelsAndTextboxVisible();
            leftSideVisible();
            dateOfDeparture.Visible = true;
            dateOfReturning.Visible = true;
            textBox5.Visible = false;
            textBox6.Visible = false;
            auto = false;
            house = false;
            health = false;
            life = false;
            travel = true;
            accidents = false;
            if (rbEng.Checked)
            {
                //Chr
                lbTabChr.Text = "Tourist Plus Premium Insurance offers you:" + Environment.NewLine;
                lbTabChr.Text += "✓ 24/7 support;" + Environment.NewLine;
                lbTabChr.Text += "✓ insured amount of up to 50,000 euros, depending on the chosen territoriality;" + Environment.NewLine;
                lbTabChr.Text += "✓ medical expenses are taken over directly;" + Environment.NewLine;
                lbTabChr.Text += "✓ additional coverage for travel cancellation, trip interruption, baggage, civil liability, airline bankruptcy, etc .;" + Environment.NewLine;
                lbTabChr.Text += "✓ coverage of a maximum of 120 consecutive days for tourism or 365 days for business purposes for each trip." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ the most complex travel insurance product on the market, which covers, in addition to the basic risks, a number of additional risks, in case of cancellation of the trip due to unforeseen events, from delay, loss or damage to luggage , interruption of travel and even civil liability abroad; " + Environment.NewLine;
                lbTabAdv.Text += "○ covers special risks, such as: bankruptcy of airlines, inadequate services on board the plane, pregnancy before departure, cancellation of connecting flights, etc .;" + Environment.NewLine;
                lbTabAdv.Text += "○ direct settlement of medical expenses." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documents required:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copy of the travel document" + Environment.NewLine;
                lbTabDoc.Text += "∇ Documents proving the trip from which the period will appear" + Environment.NewLine;
                lbTabDoc.Text += "∇ Self-Statement" + Environment.NewLine;
                //Offer
                label1.Text = "Purpose of the trip";
                label2.Text = "Destination continent";
                label3.Text = "Destination country";
                label4.Text = "Number of travelers";
                label5.Text = "Date of departure";
                label6.Text = "Return Date";
            }
            else
            {
                //Chr
                lbTabChr.Text = "Asigurarea Turist Plus Premium iti ofera:" + Environment.NewLine;
                lbTabChr.Text += "✓ asistenta 24/24 h;" + Environment.NewLine;
                lbTabChr.Text += "✓ suma asigurata de pana la 50.000 euro, in functie de teritorialitatea aleasa;" + Environment.NewLine;
                lbTabChr.Text += "✓ cheltuielile medicale sunt preluate direct;" + Environment.NewLine;
                lbTabChr.Text += "✓ acoperiri suplimentare pentru situatii de anulare a calatoriei, intreruperea calatoriei, bagaje, raspundere civila, faliment companie aeriana etc.;" + Environment.NewLine;
                lbTabChr.Text += "✓ acoperire de maxim 120 zile consecutive in scop turistic sau 365 zile in scop business pentru fiecare calatorie." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ cel mai complex produs de asigurare a calatoriei din piata, care acopera pe langa riscurile de baza, o serie de riscuri suplimentare, in cazul anularii calatoriei ca urmare a unor evenimente neprevazute, de la intarzierea, pierderea ori deteriorarea bagajelor, intreruperea calatoriei si pana la raspunderi civile in afara tarii;" + Environment.NewLine;
                lbTabAdv.Text += "○ acopera riscuri speciale, cum ar fi: falimentul companiilor aeriene, servicii necorespunzatoare la bordul avionului, sarcina inainte de plecarea in calatorie, anularea zborurilor de legatura etc.;" + Environment.NewLine;
                lbTabAdv.Text += "○ decontare directa a cheltuielilor medicale." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documente necesare:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa actul de identitate cu care se calatoreste" + Environment.NewLine;
                lbTabDoc.Text += "∇ Acte doveditoare calatoriei din care sa reiasa perioada" + Environment.NewLine;
                lbTabDoc.Text += "∇ Declaratie pe propria raspundere" + Environment.NewLine;
                //Offer
                label1.Text = "Scopul calatoriei";
                label2.Text = "Continentul de destinatie";
                label3.Text = "Tara de destinatie";
                label4.Text = "Numarul de calatori";
                label5.Text = "Data plecarii";
                label6.Text = "Data intoarcerii";
            }
        }

        private void btnAccidents_Click(object sender, EventArgs e)
        {
            makeLabelsAndTextboxVisible();
            leftSideInvisible();
            auto = false;
            house = false;
            health = false;
            life = false;
            travel = false;
            accidents = true;
            if (rbEng.Checked)
            {
                //Chr
                lbTabChr.Text = "Choose this insurance package and benefit from:" + Environment.NewLine;
                lbTabChr.Text += "✓ Insurance in case of surgery;" + Environment.NewLine;
                lbTabChr.Text += "✓ Insurance in case of severe burns;" + Environment.NewLine;
                lbTabChr.Text += "✓ Daily allowance for each day of hospitalization;" + Environment.NewLine;
                lbTabChr.Text += "✓ Insurance for the risk of permanent disability;" + Environment.NewLine;
                lbTabChr.Text += "✓ Insurance in case of death." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ You choose the beneficiary, the insured amount and the contract period;" + Environment.NewLine;
                lbTabAdv.Text += "○ We guarantee you the insured amount;" + Environment.NewLine;
                lbTabAdv.Text += "○ You enjoy a flexible payment system: you pay annually, semi-annually or quarterly;" + Environment.NewLine;
                lbTabAdv.Text += "○ You can secure yourself and your family." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documents required:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copy of ID" + Environment.NewLine;
                lbTabDoc.Text += "∇ Self-Statement" + Environment.NewLine;
                //Offer
            }
            else
            {
                //Chr
                lbTabChr.Text = "Alege acest pachet de asigurare si beneficiezi de:" + Environment.NewLine;
                lbTabChr.Text += "✓ Asigurare in cazul unor interventii chirurgicale;" + Environment.NewLine;
                lbTabChr.Text += "✓ Asigurare in cazurile de arsuri grave;" + Environment.NewLine;
                lbTabChr.Text += "✓ Indemnizatie pe zi pentru fiecare zi de spitalizare;" + Environment.NewLine;
                lbTabChr.Text += "✓ Asigurare pentru riscul de invaliditate permanenta;" + Environment.NewLine;
                lbTabChr.Text += "✓ Asigurare in cazul decesului." + Environment.NewLine;
                //Adv
                lbTabAdv.Text = "○ Tu alegi beneficiarul, suma asigurata si perioada contractului;" + Environment.NewLine;
                lbTabAdv.Text += "○ Iti garantam suma asigurata;" + Environment.NewLine;
                lbTabAdv.Text += "○ Te bucuri de un sistem de plata flexibil: platesti anual, semestrial sau trimestrial;" + Environment.NewLine;
                lbTabAdv.Text += "○ Te poti asigura pe tine cat si pe familia ta." + Environment.NewLine;
                //Doc
                lbTabDoc.Text = "Documente necesare:" + Environment.NewLine;
                lbTabDoc.Text += "∇ Copie dupa actul de identitate" + Environment.NewLine;
                lbTabDoc.Text += "∇ Declaratia pe propria raspundere" + Environment.NewLine;
                //Offer
            }
        }

        private void insertClient()
        {
            OleDbConnection connection = new OleDbConnection(connectionName);
            OleDbCommand insertClientCommand = new OleDbCommand();
            try
            {
                connection.Open();
                insertClientCommand.CommandText = $"UPDATE clients SET country='{tbCounty.Text}', town='{tbTown.Text}', street='{tbStreet.Text}', postalcode='{tbPostalCode.Text}'" +
                    $"WHERE CNP='{c.CNP}'";
                insertClientCommand.Connection = connection;
                insertClientCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (rbEng.Checked)
                {
                    MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                }
                else
                {
                    MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                }
            }
            finally
            {
                connection.Close();
            }
        }

        private bool verifyData()
        {
            if(tbCounty.Text == "")
            {
                if(rbEng.Checked)
                {
                    errorProvider.SetError(tbCounty, "You didn't introduce the county!");
                }
                else
                {
                    errorProvider.SetError(tbCounty, "Nu ati introdus judetul!");
                }
            }
            else if (tbTown.Text == "")
            {
                if (rbEng.Checked)
                {
                    errorProvider.SetError(tbTown, "You didn't introduce the town!");
                }
                else
                {
                    errorProvider.SetError(tbTown, "Nu ati introdus orasul!");
                }
            }
            else if (tbStreet.Text == "")
            {
                if (rbEng.Checked)
                {
                    errorProvider.SetError(tbStreet, "You didn't introduce the street!");
                }
                else
                {
                    errorProvider.SetError(tbStreet, "Nu ati introdus strada!");
                }
            }
            else if (tbPostalCode.Text == "")
            {
                if (rbEng.Checked)
                {
                    errorProvider.SetError(tbPostalCode, "You didn't introduce the postal code!");
                }
                else
                {
                    errorProvider.SetError(tbPostalCode, "Nu ati introdus codul postal!");
                }
            }
            else if (cbValidityPeriod.Text == "")
            {
                if (rbEng.Checked)
                {
                    errorProvider.SetError(cbValidityPeriod, "You didn't choose the validity period!");
                }
                else
                {
                    errorProvider.SetError(cbValidityPeriod, "Nu ati ales perioada de valabilitate!");
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        private void btnCalculateOffer_Click(object sender, EventArgs e)
        {
            if(!verifyData())
            {
                if (auto == true)
                {
                    if(textBox1.Text == "")
                    {
                        if(rbEng.Checked)
                        {
                            errorProvider.SetError(textBox1, "You didn't introduce the registration number");
                        }
                        else
                        {
                            errorProvider.SetError(textBox1, "Nu ati introdus numarul de inregistrare");
                        }
                    } 
                    else if (textBox2.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox2, "You didn't introduce the chassis series");
                        }
                        else
                        {
                            errorProvider.SetError(textBox2, "Nu ati introdus seria de sasiu");
                        }
                    }
                    else if (textBox3.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox3, "You didn't introduce the brand");
                        }
                        else
                        {
                            errorProvider.SetError(textBox3, "Nu ati introdus marca");
                        }
                    }
                    else if (textBox4.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox4, "You didn't introduce the model");
                        }
                        else
                        {
                            errorProvider.SetError(textBox4, "Nu ati introdus modelul");
                        }
                    }
                    else if (textBox5.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox5, "You didn't introduce the year of manufacture");
                        }
                        else
                        {
                            errorProvider.SetError(textBox5, "Nu ati introdus anul de fabricatie");
                        }
                    }
                    else if (cbType.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(cbType, "You didn't choose the type");
                        }
                        else
                        {
                            errorProvider.SetError(cbType, "Nu ati ales tipul");
                        }
                    }
                }
                else if (house == true)
                {
                    if (textBox1.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox1, "You didn't introduce the construction type");
                        }
                        else
                        {
                            errorProvider.SetError(textBox1, "Nu ati introdus tipul constructiei");
                        }
                    }
                    else if (textBox2.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox2, "You didn't introduce the structure");
                        }
                        else
                        {
                            errorProvider.SetError(textBox2, "Nu ati introdus structura");
                        }
                    }
                    else if (textBox3.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox3, "You didn't introduce the environment");
                        }
                        else
                        {
                            errorProvider.SetError(textBox3, "Nu ati introdus mediul");
                        }
                    }
                    else if (textBox4.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox4, "You didn't introduce the construction year");
                        }
                        else
                        {
                            errorProvider.SetError(textBox4, "Nu ati introdus anul constructiei");
                        }
                    }
                    else if (textBox5.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox5, "You didn't introduce the surface");
                        }
                        else
                        {
                            errorProvider.SetError(textBox5, "Nu ati introdus suprafata");
                        }
                    }
                    else if (textBox6.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox6, "You didn't introduce the number of rooms");
                        }
                        else
                        {
                            errorProvider.SetError(textBox6, "Nu ati introdus numarul camerelor");
                        }
                    }
                }
                else if (health == true)
                {
                    if (textBox1.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox1, "You didn't introduce the health card number");
                        }
                        else
                        {
                            errorProvider.SetError(textBox1, "Nu ati introdus numarul cardului de sanatate");
                        }
                    }
                    else if (textBox2.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox2, "You didn't introduce the type of graduate studies");
                        }
                        else
                        {
                            errorProvider.SetError(textBox2, "Nu ati introdus tipul studiilor absolvite");
                        }
                    }
                    else if (textBox3.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox3, "You didn't introduce the occupation");
                        }
                        else
                        {
                            errorProvider.SetError(textBox3, "Nu ati introdus ocupatia");
                        }
                    }
                    else if (textBox4.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox4, "You didn't introduce the field of insurance");
                        }
                        else
                        {
                            errorProvider.SetError(textBox4, "Nu ati introdus domeniul de asigurare");
                        }
                    }
                    else if (textBox5.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox5, "You didn't introduce the type of insurance");
                        }
                        else
                        {
                            errorProvider.SetError(textBox5, "Nu ati introdus tipul de asigurare");
                        }
                    }
                    else if (textBox6.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox6, "You didn't introduce if you have a health insurance in the past");
                        }
                        else
                        {
                            errorProvider.SetError(textBox6, "Nu ati introdus daca ati avut o asigurare de sanatate in trecut");
                        }
                    }
                }
                else if (travel == true)
                {
                    if (textBox1.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox1, "You didn't introduce the purpose of the trip");
                        }
                        else
                        {
                            errorProvider.SetError(textBox1, "Nu ati introdus motivul calatoriei");
                        }
                    }
                    else if (textBox2.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox2, "You didn't introduce the destination continent");
                        }
                        else
                        {
                            errorProvider.SetError(textBox2, "Nu ati introdus continentul destinatiei");
                        }
                    }
                    else if (textBox3.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox3, "You didn't introduce the destination country");
                        }
                        else
                        {
                            errorProvider.SetError(textBox3, "Nu ati introdus tara de destinatie");
                        }
                    }
                    else if (textBox4.Text == "")
                    {
                        if (rbEng.Checked)
                        {
                            errorProvider.SetError(textBox4, "You didn't introduce the number of travelers");
                        }
                        else
                        {
                            errorProvider.SetError(textBox4, "Nu ati introdus numarul de calatori");
                        }
                    }
                }
            }
            else
            {
                errorProvider.Clear();
                insertClient();
                if(auto == true)
                {
                    i = new Insurance("Autovehicle", int.Parse(cbValidityPeriod.Text));
                    i.Price = calculateAutoInsurance();
                    if(proceedWithInsurance() == true)
                    {
                        scheduleTime();
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand insertAutoCommand = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            if (rbRom.Checked)
                            {
                                if (cbType.Text == "Automata")
                                {
                                    insertAutoCommand.CommandText = $"INSERT INTO autovehicle(CNP, RegistrationNumber, ChassisSeries, Brand, Model, ManufactureYear, Type, Period, Price)" +
                                    $"VALUES('{c.CNP}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', 'Automatic', '{i.Period}', '{i.Price}')";
                                }
                                else
                                {
                                    insertAutoCommand.CommandText = $"INSERT INTO autovehicle(CNP, RegistrationNumber, ChassisSeries, Brand, Model, ManufactureYear, Type, Period, Price)" +
                                    $"VALUES('{c.CNP}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', 'Manual', '{i.Period}', '{i.Price}')";
                                }
                            }
                            else
                            {
                                insertAutoCommand.CommandText = $"INSERT INTO autovehicle(CNP, RegistrationNumber, ChassisSeries, Brand, Model, ManufactureYear, Type, Period, Price)" +
                                                            $"VALUES('{c.CNP}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{cbType.Text}', '{i.Period}', '{i.Price}')";
                            }
                            insertAutoCommand.Connection = connection;
                            insertAutoCommand.ExecuteNonQuery();
                            insuranceAddded();
                            insurances.Add(i);
                        }
                        catch (Exception ex)
                        {
                            if (rbEng.Checked)
                            {
                                MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                            }
                            else
                            {
                                MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else if(house == true)
                {
                    i = new Insurance("House", int.Parse(cbValidityPeriod.Text));
                    i.Price = calculateHouseInsurance();
                    if(proceedWithInsurance() == true)
                    {
                        scheduleTime();
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand insertCommand = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            insertCommand.CommandText = $"INSERT INTO house(CNP, ConstructionType, Structure, Environment, ConstructionYear, Surface, NbRooms, Period, Price)" +
                                $"VALUES('{c.CNP}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}', '{i.Period}', '{i.Price}')";
                            insertCommand.Connection = connection;
                            insertCommand.ExecuteNonQuery();
                            insuranceAddded();
                            insurances.Add(i);
                        }
                        catch (Exception ex)
                        {
                            if (rbEng.Checked)
                            {
                                MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                            }
                            else
                            {
                                MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else if(health == true)
                {
                    i = new Insurance("Health", int.Parse(cbValidityPeriod.Text));
                    i.Price = calculateHealthInsurance();
                    if(proceedWithInsurance() == true)
                    {
                        scheduleTime();
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand insertCommand = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            insertCommand.CommandText = $"INSERT INTO health(CNP, NbHealthCard, TypeStudies, Occupation, InsuranceField, InsuranceType, HadInThePast, Period, Price)" +
                                $"VALUES('{c.CNP}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{cbFieldH.Text}', '{cbTypeH.Text}', '{textBox6.Text}', '{i.Period}', '{i.Price}')";
                            insertCommand.Connection = connection;
                            insertCommand.ExecuteNonQuery();
                            insuranceAddded();
                            insurances.Add(i);
                        }
                        catch (Exception ex)
                        {
                            if (rbEng.Checked)
                            {
                                MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                            }
                            else
                            {
                                MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else if(life == true)
                {
                    i = new Insurance("Life", int.Parse(cbValidityPeriod.Text));
                    age = System.DateTime.Now.Year - c.DateOfBirth.Year;
                    i.Price = calculateLifeInsurance();
                    if(proceedWithInsurance() == true)
                    {
                        scheduleTime();
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand insertCommand = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            insertCommand.CommandText = $"INSERT INTO life(CNP, Period, Price, Age)" +
                                    $"VALUES('{c.CNP}', '{i.Period}', '{i.Price}', '{age}')";
                            insertCommand.Connection = connection;
                            insertCommand.ExecuteNonQuery();
                            insuranceAddded();
                            insurances.Add(i);
                        }
                        catch (Exception ex)
                        {
                            if (rbEng.Checked)
                            {
                                MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                            }
                            else
                            {
                                MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else if(travel == true)
                {
                    i = new Insurance("Travel", int.Parse(cbValidityPeriod.Text));
                    i.Price = calculateTravelInsurance();
                    if(proceedWithInsurance() == true)
                    {
                        scheduleTime();
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand insertCommand = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            insertCommand.CommandText = $"INSERT INTO travel(CNP, Purpose, Continent, Country, NbTravelers, Departure, Arrival, Period, Price)" +
                                    $"VALUES('{c.CNP}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', @Departure, @Arrival, '{i.Period}', '{i.Price}')";
                            insertCommand.Parameters.Add("@Departure", OleDbType.Date).Value = dateOfDeparture.Value;
                            insertCommand.Parameters.Add("@Arrival", OleDbType.Date).Value = dateOfReturning.Value;
                            insertCommand.Connection = connection;
                            insertCommand.ExecuteNonQuery();
                            insuranceAddded();
                            insurances.Add(i);
                        }
                        catch (Exception ex)
                        {
                            if (rbEng.Checked)
                            {
                                MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                            }
                            else
                            {
                                MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else if(accidents == true)
                {
                    i = new Insurance("Accidents", int.Parse(cbValidityPeriod.Text));
                    i.Price = calculateAccidentsInsurance();
                    if(proceedWithInsurance() == true && checkInsurance("Accidents") == false)
                    {
                        OleDbConnection connection = new OleDbConnection(connectionName);
                        OleDbCommand insertCommand = new OleDbCommand();
                        try
                        {
                            connection.Open();
                            insertCommand.CommandText = $"INSERT INTO accidents(CNP, Period, Price)" +
                                    $"VALUES('{c.CNP}', '{i.Period}', '{i.Price}')";
                            insertCommand.Connection = connection;
                            insertCommand.ExecuteNonQuery();
                            insuranceAddded();
                            insurances.Add(i);
                        }
                        catch (Exception ex)
                        {
                            if (rbEng.Checked)
                            {
                                MessageBox.Show("There has been an erorr introducing your data! Check the fields again!");
                            }
                            else
                            {
                                MessageBox.Show("S-a produs o eroare la introducerea datelor! Verificati din nou campurile!");
                            }
                        }
                        finally
                        {
                            connection.Close();
                            scheduleTime();
                        }
                    }
                }
            }
        }

        private bool checkInsurance(string table)
        {
            bool exist = false;
            OleDbConnection connection = new OleDbConnection(connectionName);
            OleDbCommand query = new OleDbCommand();
            try
            {
                connection.Open();
                query.CommandText = "SELECT COUNT(CNP) FROM " + table
                    + $" WHERE CNP='{c.CNP}'";
                query.Connection = connection;
                int count = (int)query.ExecuteScalar();
                if(count == 1)
                {
                    exist = true;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return exist;
        }

        private void insuranceAddded()
        {
            if (rbEng.Checked)
            {
                MessageBox.Show("Your insurance request was successfully added!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Cererea dvs pt asigurare a fost adaugata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void scheduleTime()
        {
            Meeting m = new Meeting(c);
            m.ShowDialog();
        }

        private bool proceedWithInsurance()
        {
            DialogResult r;
            if (rbEng.Checked)
            {
                r = MessageBox.Show("The calculated price for your insurance is " 
                    + i.Price 
                    + " for a period of " + i.Period + " months." +
                    "\nDo you wish to proceed with the insurance?",
                    "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                r = MessageBox.Show("Pretul calculat pentru asigurarea dvs. este de "
                    + i.Price
                    + " pentru o perioada de " + i.Period + " luni." +
                    "\nVreti sa continuati cu asigurarea?",
                    "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if(r ==  DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private double calculateAutoInsurance()
        {
            double price = 0;
            price = i.Period * 10 * 0.001 * int.Parse(textBox5.Text);
            return price;
        }

        private double calculateHouseInsurance()
        {
            double price = 0;
            price = i.Period * 8 * 0.0001 * int.Parse(textBox4.Text) * int.Parse(textBox5.Text) * int.Parse(textBox6.Text);
            return price;
        }

        private double calculateHealthInsurance()
        {
            double price = 0;
            price = i.Period * 60.5;
            return price;
        }

        private double calculateLifeInsurance()
        {
            double price = 0;
            price = i.Period * 1.63 * age;
            return price;
        }

        private double calculateTravelInsurance()
        {
            double price = 0;
            price = i.Period * 75.8;
            return price;
        }

        private double calculateAccidentsInsurance()
        {
            double price = 0;
            price = i.Period * 122.98;
            return price;
        }

        private void lbDeclaration_Click(object sender, EventArgs e)
        {
            DialogResult r;
            if (rbEng.Checked)
            {
                r = MessageBox.Show("The file will open in your default browser", "Open file", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                r = MessageBox.Show("Fisierul se va deschida in browserul dvs. principal", "Deschidere fisier", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            if(r == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("E:\\Facultate\\An 2 Sem 2\\Programarea aplicatiilor windows PAW\\Seminar\\Proiect\\Self-statement - Life Insurance.pdf");
            }
        }

        private void cbFieldH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbEng.Checked)
            {
                if((String)cbFieldH.SelectedItem == "Specialist doctors")
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Cardiology");
                    cbTypeH.Items.Add("Epidemiology");
                    cbTypeH.Items.Add("Psychiatry");
                }
                else if ((String)cbFieldH.SelectedItem == "Dentistry")
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Anesthesia");
                    cbTypeH.Items.Add("Dentists");
                    cbTypeH.Items.Add("Hygiene");
                }
                else if ((String)cbFieldH.SelectedItem == "Pharmacy")
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Closed circuit pharmacies");
                    cbTypeH.Items.Add("Open circuit pharmacies");
                }
                else
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Family doctor");
                    cbTypeH.Items.Add("General practitioner");
                }
            }
            else
            {
                if ((String)cbFieldH.SelectedItem == "Medici specialisti")
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Cardiologie");
                    cbTypeH.Items.Add("Epidemiologie");
                    cbTypeH.Items.Add("Psihiatrie");
                }
                else if ((String)cbFieldH.SelectedItem == "Stomatologie")
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Anestezie");
                    cbTypeH.Items.Add("Dentisti");
                    cbTypeH.Items.Add("Igiena");
                }
                else if ((String)cbFieldH.SelectedItem == "Farmacie")
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Farmacii cu circuit inchis");
                    cbTypeH.Items.Add("Farmacii cu circuit deschis");
                }
                else
                {
                    cbTypeH.Items.Clear();
                    cbTypeH.Items.Add("Doctor de familie");
                    cbTypeH.Items.Add("Medic de medicina generala");
                }
            }
        }

        private void seeRecentlyAdddedInsurancesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info inf = new Info(insurances);
            inf.ShowDialog();
        }

        private void seeOwnedInsurancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insurances.Clear();
            OleDbConnection connection = new OleDbConnection(connectionName);
            OleDbCommand queryAuto = new OleDbCommand();
            OleDbCommand queryHouse = new OleDbCommand();
            OleDbCommand queryHealth = new OleDbCommand();
            OleDbCommand queryLife = new OleDbCommand();
            OleDbCommand queryTravel = new OleDbCommand();
            OleDbCommand queryAccidents = new OleDbCommand();
            try
            {
                connection.Open();
                queryAuto.CommandText = $"SELECT period, price FROM autovehicle WHERE CNP='{c.CNP}'";
                queryAuto.Connection = connection;
                OleDbDataReader reader = queryAuto.ExecuteReader();
                while (reader.Read())
                {
                    i = new Insurance("Auto", double.Parse(reader["price"].ToString()),
                        int.Parse(reader["period"].ToString()));
                    insurances.Add(i);
                }
                queryHouse.CommandText = $"SELECT period, price FROM house WHERE CNP='{c.CNP}'";
                queryHouse.Connection = connection;
                reader = queryHouse.ExecuteReader();
                while (reader.Read())
                {
                    i = new Insurance("House", double.Parse(reader["price"].ToString()),
                        int.Parse(reader["period"].ToString()));
                    insurances.Add(i);
                }
                queryHealth.CommandText = $"SELECT period, price FROM health WHERE CNP='{c.CNP}'";
                queryHealth.Connection = connection;
                reader = queryHealth.ExecuteReader();
                while (reader.Read())
                {
                    i = new Insurance("Health", double.Parse(reader["price"].ToString()),
                        int.Parse(reader["period"].ToString()));
                    insurances.Add(i);
                }
                queryLife.CommandText = $"SELECT period, price FROM life WHERE CNP='{c.CNP}'";
                queryLife.Connection = connection;
                reader = queryLife.ExecuteReader();
                while (reader.Read())
                {
                    i = new Insurance("Life", double.Parse(reader["price"].ToString()),
                        int.Parse(reader["period"].ToString()));
                    insurances.Add(i);
                }
                queryTravel.CommandText = $"SELECT period, price FROM travel WHERE CNP='{c.CNP}'";
                queryTravel.Connection = connection;
                reader = queryTravel.ExecuteReader();
                while (reader.Read())
                {
                    i = new Insurance("Travel", double.Parse(reader["price"].ToString()),
                        int.Parse(reader["period"].ToString()));
                    insurances.Add(i);
                }
                queryAccidents.CommandText = $"SELECT period, price FROM accidents WHERE CNP='{c.CNP}'";
                queryAccidents.Connection = connection;
                reader = queryAccidents.ExecuteReader();
                while (reader.Read())
                {
                    i = new Insurance("Accidents", double.Parse(reader["price"].ToString()),
                        int.Parse(reader["period"].ToString()));
                    insurances.Add(i);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            Info inf = new Info(insurances);
            inf.ShowDialog();
        }
    }
}