// Domain modeling - Doctor Treatment plan
// A doctor can issue a patient one of the following treatment plans
// - Ask the patient to drink plenty of fluids and get lots of sleep
// - Ask the patient to come back in X days if they're still not feeling well
// - Issue the patient with a prescription for a particular medicine, for X times a day, for Y days
// - Tell the patient to go straight to hospital
// - Patient with prescription take a particular medicine once a day for y days 

type DoctorTreatmentPlan = 
    | FluidsAndSleep 
    | ComeBackInXDays of int 
    | Prescription of string * int * int 
    | StraightToHospital of string 
    | SpecificPrescription of string * int 


// Domain modeling - Playing Card
// In this case model a Playing card from a standard deck of cards, including Jockers
// Where a Card can either be a normal card (Suit & Value) or a Joker
// Suites are Heart, Diamond, Space, Club.
// Value are 2-10 and the face cards, Jack, Queen, King, Ace


 type Suit =
     | Heart 
     | Diamond
     | Spade
     | Club 


     type Value =
         | Two
         | Three 
         | Four 
         | Five 
         | Six 
         | Seven
         | Eight
         | Nine 
         | Ten 

  //type Card = 
    //| Joker 
    //| NormalCard of Value * Suit 

    type NormalCard = Value * Suit 



 // Domain modeling - Bank Login
 // Users can login to their bank account with one of the following methods
 // - Using their debt card number (int64),
 // - Using their member number (int)
 // - Using their email address (string)
 // For each of those ways they can also choose to use 2 factor authentication device or not
 // 2 factor authentication can be via:
 // - a device (with deviceid (int64)),
 // - sms (with phone number), or
 // - app
 // Write a DU that stores all of these details.



type BankLogin = 
   | DebitCard of int64 
   | MemberNumber of int 
   | EmailAddress of string  

type TwoFactor =
    | Device of int64 
    | SMS of int 
    | App 


    //type UserDetails =  BankLogin * TwoFactor 
    //type NoAuth = Banklogin 

    //type TwoCases = UserDetails
                    //No Auth 


    type TwoCases = 
        | UserDetails of BankLogin * TwoFactor
        | NoAuth of BankLogin 