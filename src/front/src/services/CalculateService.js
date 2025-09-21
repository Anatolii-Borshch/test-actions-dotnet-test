class CalculateService {
    factorial(n) {
        if (n <= 0 || !Number.isInteger(n))
            throw new Error("n must be a positive integer");

        let result = 1;
        for (let i = 1; i <= n; i++) {
            result *= i;
        }

        return result;
    }

    arraySum(array) {
        if (!Array.isArray(array) || array.length === 0)
            throw new Error("array must not be empty");
        
        let sum = 0;
        for (let item of array) {
            sum += item;
        }
        
        return sum;
    }

    isPatronimic(str) {
        if (typeof str !== 'string' || str.length === 0)
            throw new Error("str must not be empty");
        
        let left = 0;
        let right = str.length - 1;

        while (left < right) {
            if (str[left] !== str[right])
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }
}

module.exports = CalculateService;