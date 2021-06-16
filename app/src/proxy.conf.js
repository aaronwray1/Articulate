const PROXY_CONFIG = [
    {
        context: [
            "/articulate",
        ],
        target: "http://articulate:83",
        secure: false
    }
]

module.exports = PROXY_CONFIG;