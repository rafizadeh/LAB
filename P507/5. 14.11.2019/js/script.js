// string classi
let str = new String("Kamran Vusal Selcan");
console.log(str);

// custom yaratdigimiz string classi
class customString {
    constructor() {
        let str = [];
        
        this.elem = str;

        this.len = 0;

        this.fullString = arguments[0];

        for (let i = 0; i < Infinity; i++) {
            if (arguments[0][i] !== undefined) {
                str[i] = arguments[0][i];
                this.len++;
            } 
            else 
            {
                break;
            }
        }
    }
    // stringleri birleshdirmek uchun metod
    customConcat(str3){
        return this.elem = this.fullString + str3.fullString;
    }
}



let strg = new customString("Kenan, Sadiq / Selcan . Vusal.... ");
let strn = new customString("Selcan . Vusal");
console.log(strg.customConcat(strn));
