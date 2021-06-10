const PROXY_CONFIG = [
    {
        context: [
            "/articulate",
        ],
        target: "http://localhost:7993",
        secure: false
    }
]

module.exports = PROXY_CONFIG;