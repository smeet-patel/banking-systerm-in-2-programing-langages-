import urllib.request
import json

#Fast Bank python app
print('')
num = int(0)
CustID = int(0);
accountholder = {num: {'Name':'', 'Email':'','Date of Birth':'','Address':'','Personal Balance':'','Loan Balance':'','Saving Balance':''}}
accountholder[1]= {'Name':'john', 'Email':'1','Date of Birth':'23','Address':'s','Personal Balance':'1','Loan Balance':'2','Saving Balance':'3'}
accountholder[2]= {'Name':'sam', 'Email':'1','Date of Birth':'23','Address':'s','Personal Balance':'1','Loan Balance':'2','Saving Balance':'3'}

#the main meun
def menu():
    print('1. New Customer')
    print('2. Exisiting Customer')
    print('3. Banker')
    print('4. Exchange rate')

menu()

#Banker features
def bankermenu():
    print('1. Print All customer details')
    print('2. Transfer cheeque')
    print('3. Lookup')
    print('4. Menu')
    #print()
    inputbanker = int(input("Type in a number (1-4): "))
    if inputbanker == 1:
        for p_id, p_info in accountholder.items():
            print("\nPerson ID:", p_id)
    
            for key in p_info:
                print(key + ':', p_info[key])
        print()
        #transfer a to b amount
    if inputbanker == 2:
        custfrom =int(input("Enter customer ID which the cheque is from: "))
        custto =int(input("Enter customer ID which the cheque is going to: "))
        amount =float(input("Enter amount: "))
        temp1 = float(accountholder[custfrom]['Personal Balance'])
        temp2 = float(accountholder[custto]['Personal Balance'])
        tempa = float(temp1-amount)
        tempb = float(temp2+amount)
        accountholder[custfrom]['Personal Balance'] = temp1-amount
        accountholder[custto]['Personal Balance']= temp2+amount
        print(accountholder[custfrom])
        print(accountholder[custto])
        print()
        
    if inputbanker == 3:
        custnumbank = int(input("Enter customer ID : "))
        print(accountholder[custnum])
    else:
        menu() 

#customer meun
def customermenu():

    """while True:
        try:
            CustID = int(input("Enter your customer ID: "))
        except ValueError:
            print('Please enter a valid integer')
            continue
        break"""
    custnum =int(input("Your customer number: "))
    print()
    
    print('1. See your details')
    print('2. Remove all details from bank')
    print('3. Edit details')
    print('4. Forcast Saving amount for 12 months time interest')
    print('5. Forcast Loan owing amount in months time with interest')
    print('6. Menu')
    #print()
    inputcust = int(input("Type in a number (1-6): "))
    if inputcust == 1:
        print(accountholder[custnum])
    if inputcust == 2:
        del accountholder[custnum]
        print("Removed " + "all details of customer number" + custnum)
    if inputcust == 3:
        print('Edit your details. Customer name, DOB and balances can be edited. ')
        print('1. edit email')
        print('2. edit address')
        print()
        edit = int(input("Edit number: "))
        if edit == 1:
            newemail = input("New Email: ")
            accountholder[custnum]['Email']= newemail
            print()
        if edit== 2:
            newadd = input("New address: ")
            accountholder[custnum]['email']= newadd
            print()
    if inputcust == 4:
        print("Forcast Saving at 2.1% per year")
        temp1=(float(accountholder[custnum]['Loan Balance'])*1.021)
        print("In one year, your total saving amount at 2.1% interest will be :")
        print(temp1)
        print()
    if inputcust == 5:
        temp2=(float(accountholder[custnum]['Saving Balance'])*1.0445)
        print("Forcast Loan for a amount payable in a years time")
        print("In one year, your loan amount $"+ (accountholder[custnum]['Saving Balance']) +" amount at 4.45% interest will become :")
        print(temp2)
        print()
    else:
        menu()
        


def customer():
    global num
    num= num + 1
    print("Enter Details")
    name = input("Name: ")
    email = input("Email: ")
    dob = input("Address: ")
    address = input("Date of brith: ")
    personal = input("Opening transfered balanced: ")
    loan = input("loan acqusion amount: ")
    saving = input("Saving balance ")
    print(num)
    accountholder[num] ={'Name':name, 'Email':email,'Date of Birth':dob,'Address':address,'Personal Balance':personal,'Loan Balance':loan,'Saving Balance':saving}
    print(accountholder[num])
    menu()

class CurrencyConverter:
    #data.fixer.io was used get the live data
    rates = {}

    def __init__(self, url):
        req = urllib.request.Request(url, headers={'User-Agent': 'howCode Currency Bot'})
        data = urllib.request.urlopen(req).read()
        data = json.loads(data.decode('utf-8'))
        self.rates = data["rates"]

    def convert(self, amount, from_currency, to_currency):
        initial_amount = amount
        if from_currency != "EUR":
            amount = amount / self.rates[from_currency]
        if to_currency == "EUR":
            return initial_amount, from_currency, '=', amount, to_currency
        else:
            return initial_amount, from_currency, '=', amount * self.rates[to_currency], to_currency
            
    def convertrate():
        convertamount = float(input("Enter amount which you wish to convert: "))
        print("Currency codes examples: NZD, USD, INR, SDG, AUD, EUR, GBR")
        CurrencyFrom = input("Input currency code which you wish to convert FROM: ").upper()
        CurrencyTo = input("Input currency code which you wish to convert TO: ").upper()
        #THIS is my personal key, so please to not use else where. 
        converter = CurrencyConverter("http://data.fixer.io/api/latest?access_key=c145deb07bff162f7d930bebbf11ea2b&format=1")
        #converter.convert(convertamount, "NZD", "USD")
        print(converter.convert(convertamount, CurrencyFrom, CurrencyTo))

#main meun

select = 0
while select != 5:
    inputmenu = int(input("Type in a number (1-4) depening on the type of user: "))
    if inputmenu == 1:
        customer()
    elif inputmenu == 2:
        customermenu()
    elif inputmenu == 3:
        bankermenu()
    elif inputmenu == 4:
        CurrencyConverter.convertrate()
    else:
        menu()




    
