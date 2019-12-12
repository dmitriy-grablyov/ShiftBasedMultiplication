# Useless project - multiplication over addition

This example shows how a multiplication of 2 integer (unsigned) number may be done over shifting and addition

It does not consider the sign and works for int type, but when needed can be expanded to the datatypes of wider range 

It also does not consider an overflow after shifting, but pay attention at the interesting fact: if multiplication results into a number 
that is bigger than `uint` can hold, then result will be wrong, but it will be the same as default multiplication implementation gives.

Try multiplying `99999` and `99999`. Whereas the correct result is `9999800001`, the program will produce `1409865409` for both 
custom multiplication and default `*` opertion.

By controlling the overflow and managing arrays of numbers it is theoretically possible to operate on numbers of any range.
