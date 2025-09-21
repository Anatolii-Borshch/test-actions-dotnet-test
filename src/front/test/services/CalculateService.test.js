const CalculateService = require('../../src/services/CalculateService');

let service;

beforeEach(() => {
    service = new CalculateService();
});

describe('CalculateService', () => {

    describe('factorial', () => {
        test('calculates factorial correctly', () => {
            expect(service.factorial(1)).toBe(1);
            expect(service.factorial(3)).toBe(6);
            expect(service.factorial(5)).toBe(120);
        });

        test('throws error for non-positive or non-integer', () => {
            expect(() => service.factorial(0)).toThrow("n must be a positive integer");
            expect(() => service.factorial(-5)).toThrow("n must be a positive integer");
            expect(() => service.factorial(2.5)).toThrow("n must be a positive integer");
        });
    });

    describe('arraySum', () => {
        test('calculates sum correctly', () => {
            expect(service.arraySum([1,2,3])).toBe(6);
            expect(service.arraySum([10, -2, 5])).toBe(13);
        });

        test('throws error for empty or invalid array', () => {
            expect(() => service.arraySum([])).toThrow("array must not be empty");
            expect(() => service.arraySum(null)).toThrow("array must not be empty");
            expect(() => service.arraySum(123)).toThrow("array must not be empty");
        });
    });

    describe('isPatronimic', () => {
        test('detects palindromes correctly', () => {
            expect(service.isPatronimic("abba")).toBe(true);
            expect(service.isPatronimic("racecar")).toBe(true);
            expect(service.isPatronimic("hello")).toBe(false);
        });

        test('throws error for empty or non-string input', () => {
            expect(() => service.isPatronimic("")).toThrow("str must not be empty");
            expect(() => service.isPatronimic(null)).toThrow("str must not be empty");
            expect(() => service.isPatronimic(123)).toThrow("str must not be empty");
        });
    });

});
